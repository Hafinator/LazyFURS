using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using LazyFURS.Models;
using OfficeOpenXml;

namespace LazyFURS
{
    internal class Program
    {
        private static readonly HttpClient client = new();
        private static Conversion[] conversionData; // Holds the <currency, dates/rates> data

        private static void Main()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

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
            HttpResponseMessage response = await client.GetAsync("https://sdw-wsrest.ecb.europa.eu/service/data/EXR/D.CAD.EUR.SP00.A?format=csvdata");
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException("Data was not retrieved successfully!");
            }

            string allData = await response.Content.ReadAsStringAsync();
            string[] rowData = allData.Split("\n");
            conversionData = new Conversion[rowData.Length];

            for (int i = 1; i < rowData.Length; i++)
            {
                string[] row = rowData[i].Split(',');
                conversionData[i] = new Conversion(row[6], row[7]);
            }
        }

        private static void ReadClosedPosition(ExcelPackage package)
        {
            ExcelWorksheet closedPositions = package.Workbook.Worksheets[1];
            throw new NotImplementedException();
        }

        private static void ReadDividends(ExcelPackage package)
        {
            ExcelWorksheet dividends = package.Workbook.Worksheets[3];

            int maxRowIndex = 0;// Indexing starts at 1...
            bool isLastRow = false;

            while (!isLastRow)
            {
                if (dividends.Cells[maxRowIndex, dividends.Columns.StartColumn].Value != null)
                {
                    maxRowIndex++;
                    continue;
                }
                isLastRow = true;
            }
        }
    }
}