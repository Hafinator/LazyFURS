using LazyFURS.Models;
using LazyFURS.Models.Xlsx;
using LazyFURS.Models.Xml.SpecialTypes;
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

        private static IsinToAddress isinToAddress;
        private static IsinToCountry isinToCountry;

        private static async Task Main()
        {
            WelcomeMessage();

            WarningMessage();

            culture = new CultureInfo("de-DE");

            //Prepares the export, example: Etoro_EUR_report_15.1.2022.xlsx
            exportName = "Etoro_EUR_report_" + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + ".xlsx";

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            dividends = new List<XlsxDividend>();
            positions = new List<XlsxPosition>();

            Console.WriteLine("This location will be used as the path for the exports as well.");
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

            isinToAddress = new IsinToAddress();
            isinToCountry = new IsinToCountry();
            FileInfo existingFile = null;

            await ReadCurrenciesApiData();

            char input = Console.ReadKey().KeyChar;

            if (input != '1')
            {
                //Prepare the data for export
                existingFile = new(filePath);
                using ExcelPackage package = new(existingFile);
                ReadClosedPosition(package);
                ReadDividends(package);
                //the using statement automatically calls Dispose() which closes the package.
            }
            while (input != '1')
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                if (input == '2')
                {
                    ExportToXlsxFile(existingFile.DirectoryName);
                }
                else if (input == '3')
                {
                    PrepareDivReport();
                }
                else if (input == '4')
                {
                    PrepareKdvpReport();
                }
                else if (input == '5')
                {
                    PrepareDIfiReport();
                }
                GenerateOptionsMenu();
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        private static void WriteExportDone()
        {
            Console.WriteLine();
            Console.WriteLine("Export done!");
            Console.WriteLine();
        }

        private static void WarningMessage()
        {
            Console.WriteLine();
            Console.WriteLine("THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.");
            Console.WriteLine("YOU BAER ALL RESPONSIBILITY FOR ANY PROBLEMS WHEN SUBMITTING YOUR TAX REPORTS.");
            Console.WriteLine();
        }

        private static void WelcomeMessage()
        {
            Console.WriteLine(" __________________________ ");
            Console.WriteLine("|  ______________________  |");
            Console.WriteLine("| | Welcome to LazyFURS! | |");
            Console.WriteLine("| |______________________| |");
            Console.WriteLine("|__________________________|");
            Console.WriteLine();
            Console.WriteLine();
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

            WriteExportDone();
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
            dividendsSheet.Cells[1, 4].Value = "EUR Dividend";
            dividendsSheet.Column(4).Width = 20;
            dividendsSheet.Cells[1, 5].Value = "EUR Foreign Tax";
            dividendsSheet.Column(5).Width = 20;

            for (int i = 0; i < dividends.Count; i++)
            {
                //Add data
                dividendsSheet.Cells[i + 2, 1].Value = dividends[i].PaymentDate.ToShortDateString();
                dividendsSheet.Cells[i + 2, 2].Value = dividends[i].ISIN;
                dividendsSheet.Cells[i + 2, 3].Value = dividends[i].FullName;
                dividendsSheet.Cells[i + 2, 4].Value = Math.Round(dividends[i].EURDividend, 2).ToString(culture);
                dividendsSheet.Cells[i + 2, 5].Value = Math.Round(dividends[i].EURForeignTax, 2).ToString(culture);
            }
        }

        private static void PrepareDivReport()
        {
            uint vatId = SpecifyVatId();
            Models.Xml.Div.Envelope envelope = new()
            {
                Header = new()
                {
                    domain = "edavki.durs.si",
                    CustodianInfo = new(),
                    responseTo = null,
                    taxpayer = new()
                    {
                        taxNumber = vatId,
                        taxpayerType = nameof(TaxPayerType.FO),
                    },
                    Workflow = new()
                    {
                        DocumentWorkflowID = "O",
                        DocumentWorkflowName = null
                    },
                },
                AttachmentList = Array.Empty<Models.Xml.Div.AttachmentListExternalAttachment>(),
                Signatures = new(),
                body = new()
                {
                    Doh_Div = new()
                    {
                        Period = (DateTime.UtcNow.Year - 1).ToString(),
                    },
                    Dividend = new Models.Xml.Div.EnvelopeBodyDividend[dividends.Count]
                }
            };
            for (int i = 0; i < dividends.Count; i++)
            {
                string country = isinToCountry.GetCountry(dividends[i].ISIN);
                envelope.body.Dividend[i] = new Models.Xml.Div.EnvelopeBodyDividend
                {
                    Date = dividends[i].PaymentDate,
                    PayerIdentificationNumber = dividends[i].ISIN,
                    PayerName = dividends[i].FullName,
                    PayerAddress = isinToAddress.GetAddress(dividends[i].ISIN),
                    PayerCountry = country,
                    Type = "1",
                    Value = Math.Round(dividends[i].EURDividend, 2),
                    ForeignTax = Math.Round(dividends[i].EURForeignTax, 2),
                    SourceCountry = country,
                    //ReliefStatement = "I don't want to pay tax! TODO"
                };
            }

            System.Xml.Serialization.XmlSerializer writer = new(typeof(Models.Xml.Div.Envelope));

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//Doh_Div.xml";
            FileStream file = File.Create(path);

            writer.Serialize(file, envelope);
            file.Close();

            WriteExportDone();
        }

        private static uint SpecifyVatId()
        {
            Console.WriteLine("Specify your VAT ID: ");
            uint vatId;
            while (!uint.TryParse(Console.ReadLine(), out vatId))
            {
                Console.WriteLine("Specify your VAT ID: ");
            }

            return vatId;
        }

        private static void PrepareKdvpReport()
        {
            List<XlsxPosition> nonCfdPositions = new(positions.Count);
            foreach (XlsxPosition position in positions)
            {
                if (position.Type != "CFD")
                {
                    if (position.Type == "Crypto")
                    {
                        continue;
                    }
                    nonCfdPositions.Add(position);
                }
            }

            uint vatId = SpecifyVatId();

            Models.Xml.KDVP.Envelope envelope = new()
            {
                Header = new()
                {
                    taxpayer = new()
                    {
                        taxNumber = vatId,
                        taxpayerType = nameof(TaxPayerType.FO),
                    },
                    domain = "edavki.durs.si"
                },
                AttachmentList = Array.Empty<Models.Xml.KDVP.AttachmentListExternalAttachment>(),
                Signatures = new Models.Xml.KDVP.Signatures(),
                body = new Models.Xml.KDVP.EnvelopeBody()
                {
                    bodyContent = string.Empty,
                    Doh_KDVP = new Models.Xml.KDVP.EnvelopeBodyDoh_KDVP()
                    {
                        KDVP = new Models.Xml.KDVP.EnvelopeBodyDoh_KDVPKDVP()
                        {
                            DocumentWorkflowID = "O",
                            Year = DateTime.UtcNow.Year - 1,
                            PeriodStart = new DateTime(DateTime.Now.Year - 1, 1, 1),
                            PeriodEnd = new DateTime(DateTime.Now.Year - 1, 12, 31),
                        },
                        KDVPItem = new Models.Xml.KDVP.EnvelopeBodyDoh_KDVPKDVPItem[nonCfdPositions.Count],
                    }
                }
            };

            List<XlsxPosition> samePositions = new(nonCfdPositions.Count);
            for (int i = 0; i < nonCfdPositions.Count; i++)
            {
                samePositions.Add(nonCfdPositions[i]);
                Models.Xml.KDVP.EnvelopeBodyDoh_KDVPKDVPItemSecurities securities = new()
                {
                    IsFond = false,
                    ISIN = nonCfdPositions[i].ISIN
                };

                for (int j = i + 1; j < nonCfdPositions.Count; j++)
                {
                    if (nonCfdPositions[i].ISIN == nonCfdPositions[j].ISIN)
                        samePositions.Add(nonCfdPositions[i]);
                    else
                        break;
                }

                securities.Row = new Models.Xml.KDVP.EnvelopeBodyDoh_KDVPKDVPItemSecuritiesRow[samePositions.Count * 2];
                for (int j = 0; j < samePositions.Count; j++)
                {
                    securities.Row[j * 2] = new Models.Xml.KDVP.EnvelopeBodyDoh_KDVPKDVPItemSecuritiesRow
                    {
                        ID = j * 2,
                        F8 = samePositions[j].Units,

                        Purchase = new Models.Xml.KDVP.EnvelopeBodyDoh_KDVPKDVPItemSecuritiesRowPurchase
                        {
                            F1 = samePositions[j].OpenDate,
                            F2 = "B",
                            F3 = samePositions[j].Units,
                            F4 = samePositions[j].EUROpenPrice
                        }
                    };
                    securities.Row[j * 2 + 1] = new Models.Xml.KDVP.EnvelopeBodyDoh_KDVPKDVPItemSecuritiesRow
                    {
                        ID = j * 2 + 1,
                        F8 = 0,

                        Sale = new Models.Xml.KDVP.EnvelopeBodyDoh_KDVPKDVPItemSecuritiesRowSale
                        {
                            F6 = samePositions[j].CloseDate,
                            F7 = samePositions[j].Units,
                            F9 = samePositions[j].EURClosePrice,
                            F10 = false
                        }
                    };
                }

                envelope.body.Doh_KDVP.KDVPItem[i] = new Models.Xml.KDVP.EnvelopeBodyDoh_KDVPKDVPItem
                {
                    ItemID = i + 1,
                    InventoryListType = "PLVP",
                    HasForeignTax = false,
                    HasLossTransfer = false,
                    ForeignTransfer = false,
                    TaxDecreaseConformance = false,
                    Name = nonCfdPositions[i].ISIN,
                    Securities = securities,
                };
                i += samePositions.Count - 1;
                samePositions.Clear();
            }

            System.Xml.Serialization.XmlSerializer writer = new(typeof(Models.Xml.KDVP.Envelope));

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//Doh_KDVP.xml";
            FileStream file = File.Create(path);

            writer.Serialize(file, envelope);
            file.Close();

            WriteExportDone();
        }

        private static void PrepareDIfiReport()
        {
            List<XlsxPosition> cdfPositions = new(positions.Count);
            foreach (XlsxPosition position in positions)
            {
                if (position.Type == "CFD")
                    cdfPositions.Add(position);
            }

            uint vatId = SpecifyVatId();

            Models.Xml.IFI.Envelope envelope = new()
            {
                Header = new Models.Xml.IFI.Header
                {
                    taxpayer = new Models.Xml.IFI.HeaderTaxpayer
                    {
                        taxNumber = vatId,
                        taxpayerType = nameof(TaxPayerType.FO),
                    },
                    Workflow = new Models.Xml.IFI.HeaderWorkflow
                    {
                        DocumentWorkflowID = "O"
                    },
                    domain = "edavki.durs.si",
                },
                AttachmentList = Array.Empty<Models.Xml.IFI.AttachmentListExternalAttachment>(),
                Signatures = new Models.Xml.IFI.Signatures(),
                body = new Models.Xml.IFI.EnvelopeBody
                {
                    bodyContent = string.Empty,
                    D_IFI = new Models.Xml.IFI.EnvelopeBodyD_IFI
                    {
                        PeriodStart = new DateTime(DateTime.Now.Year - 1, 1, 1),
                        PeriodEnd = new DateTime(DateTime.Now.Year - 1, 12, 31),
                        TItem = new Models.Xml.IFI.EnvelopeBodyD_IFITItem[cdfPositions.Count]
                    }
                }
            };

            System.Xml.Serialization.XmlSerializer writer = new(typeof(Models.Xml.IFI.Envelope));

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//Doh_KDVP.xml";
            FileStream file = File.Create(path);

            writer.Serialize(file, envelope);
            file.Close();

            WriteExportDone();
        }

        private static void CompactDividends()
        {
            for (int i = 0; i < dividends.Count; i++)
            {
                if (i > 0 && dividends[i].FullName == dividends[i - 1].FullName && dividends[i].PaymentDate == dividends[i - 1].PaymentDate)
                {
                    dividends[i - 1].EURDividend += dividends[i].EURDividend;
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

        private static void GenerateOptionsMenu()
        {
            Console.WriteLine("What report would you like to generate?");
            Console.WriteLine();
            Console.WriteLine("1) Exit");
            Console.WriteLine("2) Human readable .xlsx report");
            Console.WriteLine("3) Doh_Div report");
            Console.WriteLine("4) Doh_KDVP report");
            Console.WriteLine("5) D-IFI report");
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
                    if (!calculatePosition.IsLong)
                    {
                        calculatePosition.EURProfit *= -1; // if it's short then we negate the profit since we make money when the prices fall
                    }
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

                    calculateDividend.EURDividend = decimal.Parse(dividendSheet.Cells[index, 3].Value.ToString()) / rate;
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