using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using LazyFURS.Models;
using OfficeOpenXml;
using System.Linq;

namespace LazyFURS
{
    internal class Program
    {
        private static readonly HttpClient client = new();
        private static Conversion[] conversionData; // Holds the <currency, dates/rates> data
        private static List<Dividend> dividends;
        private static List<Position> positions;

        private static void Main()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            dividends = new List<Dividend>();
            positions = new List<Position>();

            Console.WriteLine(" __________________________ ");
            Console.WriteLine("|  ______________________  |");
            Console.WriteLine("| | Welcome to LazyFURS! | |");
            Console.WriteLine("| |______________________| |");
            Console.WriteLine("|__________________________|");
            Console.WriteLine();
            Console.WriteLine();

            //Console.Write("Path to your Etoro report: ");
            string filePath = @"D:\Moj\Desktop\etoro-account-statement-1-1-2021-12-31-2021.xlsx"; //Console.ReadLine();

            // TODO Add path verification.

            ReadCurrenciesApiData().GetAwaiter().GetResult();

            FileInfo existingFile = new(filePath);
            using (ExcelPackage package = new(existingFile))
            {
                ReadClosedPosition(package);
                ReadDividends(package);
            } // the using statement automatically calls Dispose() which closes the package.

            Console.WriteLine();
            Console.WriteLine("Read workbook sample complete");
            Console.WriteLine();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        private static async Task ReadCurrenciesApiData()
        {
            HttpResponseMessage response = await client.GetAsync("https://sdw-wsrest.ecb.europa.eu/service/data/EXR/D.USD.EUR.SP00.A?format=csvdata");
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException("Data was not retrieved successfully!");
            }

            string allData = await response.Content.ReadAsStringAsync();
            string[] rowData = allData.Split("\n");

            conversionData = new Conversion[rowData.Length - 2];

            for (int i = 1; i < rowData.Length - 1; i++)
            {
                string[] row = rowData[i].Split(',');
                // Date and rate are at 6th and 7th position
                conversionData[i - 1] = new Conversion(row[6], row[7]);
            }

            conversionData = conversionData.OrderByDescending(x => x.IssuingDate).ToArray();
        }

        private static void ReadClosedPosition(ExcelPackage package)
        {
            ExcelWorksheet closedPositionsSheet = package.Workbook.Worksheets[1];
            int index = 2;// Indexing starts at 1... + we skip the header
            bool isLastRow = false;

            while (!isLastRow)
            {
                if (closedPositionsSheet.Cells[index, 1].Value != null)
                {
                    string[] actionSplit = closedPositionsSheet.Cells[index, 2].Value.ToString().Split(' ');
                    Position calculatePosition = new Position
                    {
                        PositionId = long.Parse(closedPositionsSheet.Cells[index, 1].Value.ToString(), NumberStyles.Number, new CultureInfo("en-GB")),
                        IsLong = actionSplit[0] == "Buy",
                        FullName = actionSplit[1],
                        OpenDate = DateTime.Parse(closedPositionsSheet.Cells[index, 5].Value.ToString()).Date,
                        CloseDate = DateTime.Parse(closedPositionsSheet.Cells[index, 6].Value.ToString()).Date,
                        Leverage = int.Parse(closedPositionsSheet.Cells[index, 7].Value.ToString()),
                        Units = decimal.Parse(closedPositionsSheet.Cells[index, 4].Value.ToString(), NumberStyles.Number, new CultureInfo("en-GB")),
                        Type = closedPositionsSheet.Cells[index, 16].Value.ToString(),
                        ISIN = closedPositionsSheet.Cells[index, 17].Value?.ToString() ?? "",
                    };

                    decimal openRate = GetFirstPossibleRate(calculatePosition.OpenDate).Rate; // optimize rate retrial
                    decimal closeRate = GetFirstPossibleRate(calculatePosition.CloseDate).Rate; // optimize rate retrial

                    // Calculate start (open) values
                    calculatePosition.EURStartValue = decimal.Parse(closedPositionsSheet.Cells[index, 3].Value.ToString()) / openRate;
                    calculatePosition.EUROpenPrice = calculatePosition.EURStartValue / calculatePosition.Units / openRate;

                    // Calculate end (close) values
                    calculatePosition.EURProfit = decimal.Parse(closedPositionsSheet.Cells[index, 9].Value.ToString()) / closeRate;
                    calculatePosition.EURCloseValue = calculatePosition.EURStartValue + calculatePosition.EURProfit;
                    calculatePosition.EURClosePrice = calculatePosition.EURCloseValue / calculatePosition.Units;

                    positions.Add(calculatePosition);

                    index++;
                    continue;
                }
                isLastRow = true;
            }
        }

        private static void ReadDividends(ExcelPackage package)
        {
            ExcelWorksheet dividendSheet = package.Workbook.Worksheets[3];

            int index = 2;// Indexing starts at 1... + we skip the header
            bool isLastRow = false;

            while (!isLastRow)
            {
                if (dividendSheet.Cells[index, 1].Value != null)
                {
                    Dividend calculateDividend = new()
                    {
                        PaymentDate = DateTime.Parse(dividendSheet.Cells[index, 1].Value.ToString()).Date,
                        FullName = dividendSheet.Cells[index, 2].Value.ToString(),
                        PositionId = long.Parse(dividendSheet.Cells[index, 6].Value.ToString(), NumberStyles.Number, new CultureInfo("en-GB")),
                        ISIN = dividendSheet.Cells[index, 8].Value.ToString()
                    };

                    decimal rate = GetFirstPossibleRate(calculateDividend.PaymentDate).Rate; // optimize rate retrial

                    calculateDividend.EURNetDividend = decimal.Parse(dividendSheet.Cells[index, 3].Value.ToString()) / rate;
                    calculateDividend.EURForeignTax = decimal.Parse(dividendSheet.Cells[index, 5].Value.ToString()) / rate;

                    dividends.Add(calculateDividend);

                    index++;
                    continue;
                }
                isLastRow = true;
            }
        }

        private static Conversion GetFirstPossibleRate(DateTime d)
        {
            DateTime date = d;
            Conversion result = null;
            while (result == null)
            {
                result = conversionData.FirstOrDefault(x => x.IssuingDate == date);
                date = date.AddDays(-1);
            }
            return result;
        }
    }
}