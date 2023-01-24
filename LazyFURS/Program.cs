using LazyFURS.Models;
using LazyFURS.Models.Xlsx;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace LazyFURS
{
    internal class Program
    {
        private static readonly HttpClient client = new();

        private static Conversion[] conversionData;
        private static List<XlsxDividend> dividends;
        private static List<XlsxPosition> positions;

        private static string exportName;

        private static CultureInfo culture;

        private static bool compactDividend;
        private static bool compactPositions;

        private static void Main()
        {
            Console.WriteLine(" __________________________ ");
            Console.WriteLine("|  ______________________  |");
            Console.WriteLine("| | Welcome to LazyFURS! | |");
            Console.WriteLine("| |______________________| |");
            Console.WriteLine("|__________________________|");
            Console.WriteLine();
            Console.WriteLine();

            culture = new CultureInfo("de-DE");

            //Prepares the export, example: Etoro_EUR_report_15.1.2022.xlsx
            exportName = "Etoro_EUR_report_" + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + ".xlsx";

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            dividends = new List<XlsxDividend>();
            positions = new List<XlsxPosition>();

            Console.Write("Path to your Etoro report: ");
            string filePath = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Would you like to combine dividends of the same source + same date into a single entity? (y/N)? ");
            compactDividend = Console.ReadLine().ToLower() == "y";
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Would you like to combine positions of the same source + same date + same price into a single entity? (y/N)? ");
            compactPositions = Console.ReadLine().ToLower() == "y";

            ReadCurrenciesApiData().GetAwaiter().GetResult();

            //Prepare the data for export
            FileInfo existingFile = new(filePath);
            using (ExcelPackage package = new(existingFile))
            {
                ReadClosedPosition(package);
                ReadDividends(package);
            } //the using statement automatically calls Dispose() which closes the package.

            ExportToXlsxFile(existingFile.DirectoryName);

            Console.WriteLine();
            Console.WriteLine("Export done!");
            Console.WriteLine();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        private static void ExportToXlsxFile(string folderPath)
        {
            using ExcelPackage newPackage = new();
            // Prepare dividends worksheet
            PrepareDividends(newPackage);

            // Prepare closed positions sheet
            PrepareClosedPosition(newPackage);

            // Set some document properties
            newPackage.Workbook.Properties.Title = "Etoro EUR statement";

            // Save our new workbook in the output directory and we are done!
            newPackage.SaveAs(folderPath + "\\" + exportName);
        }

        private static void PrepareDividends(ExcelPackage newPackage)
        {
            //Order dividend data
            dividends = dividends.OrderBy(x => x.FullName).ThenBy(x => x.PaymentDate).ToList();

            if (compactDividend)
            {
                CompactDividends();
            }

            //Add a new worksheet to the empty workbook
            ExcelWorksheet dividendsSheet = newPackage.Workbook.Worksheets.Add("Dividends_EUR");

            //Add the headers
            dividendsSheet.Cells[1, 1].Value = "Payment Date";
            dividendsSheet.Column(1).Width = 15;
            dividendsSheet.Cells[1, 2].Value = "ISIN";
            dividendsSheet.Column(2).Width = 20;
            dividendsSheet.Cells[1, 3].Value = "Full Name";
            dividendsSheet.Column(3).Width = 40;
            dividendsSheet.Cells[1, 4].Value = "EUR Net Dividend";
            dividendsSheet.Column(4).Width = 20;
            dividendsSheet.Cells[1, 5].Value = "EUR Foreign Tax";
            dividendsSheet.Column(5).Width = 20;

            for (int i = 0; i < dividends.Count; i++)
            {
                //Add data
                dividendsSheet.Cells[i + 2, 1].Value = dividends[i].PaymentDate.ToShortDateString();
                dividendsSheet.Cells[i + 2, 2].Value = dividends[i].ISIN;
                dividendsSheet.Cells[i + 2, 3].Value = dividends[i].FullName;
                dividendsSheet.Cells[i + 2, 4].Value = Math.Round(dividends[i].EURNetDividend, 2).ToString(culture);
                dividendsSheet.Cells[i + 2, 5].Value = Math.Round(dividends[i].EURForeignTax, 2).ToString(culture);
            }
        }

        private static void CompactDividends()
        {
            for (int i = 0; i < dividends.Count; i++)
            {
                if (i > 0 && dividends[i].FullName == dividends[i - 1].FullName && dividends[i].PaymentDate == dividends[i - 1].PaymentDate)
                {
                    dividends[i - 1].EURNetDividend += dividends[i].EURNetDividend;
                    dividends[i - 1].EURForeignTax += dividends[i].EURForeignTax;
                    dividends.Remove(dividends[i]);
                    i--;
                }
            }
        }

        private static void CompactPositions()
        {
            for (int i = 1; i < positions.Count; i++)
            {
                if (positions[i].FullName == positions[i - 1].FullName
                    && positions[i].OpenDate.Date == positions[i - 1].OpenDate.Date
                    && positions[i].CloseDate.Date == positions[i - 1].CloseDate.Date
                    && positions[i].OpenRate == positions[i - 1].OpenRate
                    && positions[i].CloseRate == positions[i - 1].CloseRate
                    && positions[i].Type == positions[i - 1].Type
                    && positions[i].Leverage == positions[i - 1].Leverage
                    && positions[i].IsLong == positions[i - 1].IsLong)
                {
                    positions[i - 1].EURStartValue += positions[i].EURStartValue;
                    positions[i - 1].EURCloseValue += positions[i].EURCloseValue;
                    positions[i - 1].EURProfit += positions[i].EURProfit;
                    positions[i - 1].Units += positions[i].Units;
                    positions.Remove(positions[i]);
                    i--;
                }
            }
        }

        private static void PrepareClosedPosition(ExcelPackage newPackage)
        {
            //Order dividend data
            positions = positions.OrderBy(x => x.FullName).ThenBy(x => x.OpenDate).ToList();

            if (compactPositions && positions.Count > 1)
            {
                CompactPositions();
            }

            //Add a new worksheet to the workbook
            ExcelWorksheet closedPositionSheed = newPackage.Workbook.Worksheets.Add("Closed_positions_EUR");

            //Add the headers
            closedPositionSheed.Cells[1, 1].Value = "ISIN";
            closedPositionSheed.Column(1).Width = 15;
            closedPositionSheed.Cells[1, 2].Value = "Full Name";
            closedPositionSheed.Column(2).Width = 40;
            closedPositionSheed.Cells[1, 3].Value = "Type";
            closedPositionSheed.Column(3).Width = 5;
            closedPositionSheed.Cells[1, 4].Value = "Trade Type";
            closedPositionSheed.Column(4).Width = 10;
            closedPositionSheed.Cells[1, 5].Value = "Units";
            closedPositionSheed.Column(5).Width = 15;
            closedPositionSheed.Cells[1, 6].Value = "Leverage";
            closedPositionSheed.Column(6).Width = 10;
            closedPositionSheed.Cells[1, 7].Value = "Open Date";
            closedPositionSheed.Column(7).Width = 15;
            closedPositionSheed.Cells[1, 8].Value = "Close Date";
            closedPositionSheed.Column(8).Width = 15;
            closedPositionSheed.Cells[1, 9].Value = "EUR Start Value";
            closedPositionSheed.Column(9).Width = 15;
            closedPositionSheed.Cells[1, 10].Value = "EUR Close Value";
            closedPositionSheed.Column(10).Width = 15;
            closedPositionSheed.Cells[1, 11].Value = "EUR Open Price";
            closedPositionSheed.Column(11).Width = 15;
            closedPositionSheed.Cells[1, 12].Value = "EUR Close Price";
            closedPositionSheed.Column(12).Width = 15;
            closedPositionSheed.Cells[1, 13].Value = "EUR Profit";
            closedPositionSheed.Column(13).Width = 15;

            for (int i = 0; i < positions.Count; i++)
            {
                //Add data
                closedPositionSheed.Cells[i + 2, 1].Value = positions[i].ISIN;
                closedPositionSheed.Cells[i + 2, 2].Value = positions[i].FullName;
                closedPositionSheed.Cells[i + 2, 3].Value = positions[i].Type;
                closedPositionSheed.Cells[i + 2, 4].Value = positions[i].IsLong ? "Long" : "Short";
                closedPositionSheed.Cells[i + 2, 5].Value = positions[i].Units.ToString(culture);
                closedPositionSheed.Cells[i + 2, 6].Value = positions[i].Leverage;
                closedPositionSheed.Cells[i + 2, 7].Value = positions[i].OpenDate.ToShortDateString();
                closedPositionSheed.Cells[i + 2, 8].Value = positions[i].CloseDate.ToShortDateString();
                closedPositionSheed.Cells[i + 2, 9].Value = Math.Round(positions[i].EURStartValue, 2).ToString(culture);
                closedPositionSheed.Cells[i + 2, 10].Value = Math.Round(positions[i].EURCloseValue, 2).ToString(culture);
                closedPositionSheed.Cells[i + 2, 11].Value = Math.Round(positions[i].EUROpenPrice, 2).ToString(culture);
                closedPositionSheed.Cells[i + 2, 12].Value = Math.Round(positions[i].EURClosePrice, 2).ToString(culture);
                closedPositionSheed.Cells[i + 2, 13].Value = Math.Round(positions[i].EURProfit, 2).ToString(culture);
            }
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

            //This is done to optimize data retrieval
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
                    XlsxPosition calculatePosition = new()
                    {
                        IsLong = actionSplit[0] == "Buy",
                        FullName = GenerateName(actionSplit),
                        OpenDate = DateTime.Parse(closedPositionsSheet.Cells[index, 5].Value.ToString()).Date,
                        CloseDate = DateTime.Parse(closedPositionsSheet.Cells[index, 6].Value.ToString()).Date,
                        Leverage = int.Parse(closedPositionsSheet.Cells[index, 7].Value.ToString()),
                        Units = decimal.Parse(closedPositionsSheet.Cells[index, 4].Value.ToString(), NumberStyles.Number, new CultureInfo("en-GB")),
                        Type = closedPositionsSheet.Cells[index, 16].Value.ToString(),
                        ISIN = closedPositionsSheet.Cells[index, 17].Value?.ToString() ?? "",
                    };

                    decimal openRate = GetFirstPossibleRate(calculatePosition.OpenDate).Rate; // optimize rate retrieval
                    decimal closeRate = GetFirstPossibleRate(calculatePosition.CloseDate).Rate; // optimize rate retrieval

                    // Calculate start (open) values
                    calculatePosition.EURStartValue = decimal.Parse(closedPositionsSheet.Cells[index, 3].Value.ToString()) / openRate;
                    calculatePosition.EUROpenPrice = calculatePosition.EURStartValue / calculatePosition.Units / openRate;

                    // Calculate end (close) values
                    calculatePosition.EURProfit = decimal.Parse(closedPositionsSheet.Cells[index, 9].Value.ToString()) / closeRate;
                    calculatePosition.EURCloseValue = calculatePosition.EURStartValue + calculatePosition.EURProfit;
                    calculatePosition.EURClosePrice = calculatePosition.EURCloseValue / calculatePosition.Units / closeRate;

                    // Values in native currency
                    calculatePosition.OpenRate = decimal.Parse(closedPositionsSheet.Cells[index, 10].Value.ToString());
                    calculatePosition.CloseRate = decimal.Parse(closedPositionsSheet.Cells[index, 11].Value.ToString());

                    positions.Add(calculatePosition);

                    index++;
                    continue;
                }
                isLastRow = true;
            }
        }

        private static string GenerateName(string[] actionSplit)
        {
            string result = "";
            for (int i = 1; i < actionSplit.Length; i++)
            {
                result += actionSplit[i] + " ";
            }
            return result;
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
                    XlsxDividend calculateDividend = new()
                    {
                        PaymentDate = DateTime.Parse(dividendSheet.Cells[index, 1].Value.ToString()).Date,
                        FullName = dividendSheet.Cells[index, 2].Value.ToString(),
                        ISIN = dividendSheet.Cells[index, 8].Value.ToString()
                    };

                    decimal rate = GetFirstPossibleRate(calculateDividend.PaymentDate).Rate; // optimize rate retrieval

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
                //Gets the value on the specified date. If the value doesn't exist, it tries to get values from a previous day.
                result = conversionData.FirstOrDefault(x => x.IssuingDate == date);
                date = date.AddDays(-1);
            }
            return result;
        }
    }
}