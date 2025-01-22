using LazyFURS.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LazyFURS
{
    internal class CompanyManager
    {
        private readonly Dictionary<string, CompanyEntity> companies = new();

        public CompanyManager()
        {
            List<CompanyEntity> data =
            [
                new CompanyEntity { ISIN = "US8085247976", Address = "ETF", Country = "US", Currency = CurrencyType.USD, Name = "Schwab US Dividend Equity ETF", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "CA44054J1012", Address = "ETF", Country = "US", Currency = CurrencyType.USD, Name = "Horizons Marijuana Life Sciences Index ETF", TaxReductionText = "10. člen, odstavek 2b" },
                new CompanyEntity { ISIN = "US00162Q4525", Address = "ETF", Country = "US", Currency = CurrencyType.USD, Name = "Alerian MLP ETF", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US46434V6213", Address = "ETF", Country = "US", Currency = CurrencyType.USD, Name = "iShares Core Dividend Growth ETF", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US4642866085", Address = "ETF", Country = "US", Currency = CurrencyType.USD, Name = "iShares MSCI Eurozone ETF", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US4642867497", Address = "ETF", Country = "US", Currency = CurrencyType.USD, Name = "iShares MSCI Switzerland ETF", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US4642864007", Address = "ETF", Country = "US", Currency = CurrencyType.USD, Name = "Brazil Index MSCI Ishares", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US46434G8226", Address = "ETF", Country = "US", Currency = CurrencyType.USD, Name = "Ishares MSCI JAPAN ETF", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US4642868065", Address = "ETF", Country = "US", Currency = CurrencyType.USD, Name = "iShares MSCI Germany ETF", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US46434V7385", Address = "ETF", Country = "US", Currency = CurrencyType.USD, Name = "iShares Core MSCI Europe ETF", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US4642868149", Address = "ETF", Country = "US", Currency = CurrencyType.USD, Name = "iShares MSCI Netherlands ETF", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US4642868222", Address = "ETF", Country = "US", Currency = CurrencyType.USD, Name = "iShares MSCI Mexico ETF", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US78464A6982", Address = "ETF", Country = "US", Currency = CurrencyType.USD, Name = "SPDR S&P Regional Banking ETF", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US9220428745", Address = "ETF", Country = "US", Currency = CurrencyType.USD, Name = "Vanguard FTSE Europe ETF", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US81369Y5069", Address = "ETF", Country = "US", Currency = CurrencyType.USD, Name = "Energy Select Sector SPDR", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US81369Y8865", Address = "ETF", Country = "US", Currency = CurrencyType.USD, Name = "Utilities Select Sector SPDR", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US25460G6098", Address = "ETF", Country = "US", Currency = CurrencyType.USD, Name = "Direxion Daily Energy Bull 2X Shares", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US46429B5984", Address = "ETF", Country = "US", Currency = CurrencyType.USD, Name = "iShares MSCI India ETF", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US0758871091", Address = "1 Becton Drive Franklin Lakes, NJ 07417-1880 United States", Country = "US", Currency = CurrencyType.USD, Name = "Becton Dickinson & Co.", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US58933Y1055", Address = "2000 Galloping Hill Road Kenilworth, NJ 07033 United States", Country = "US", Currency = CurrencyType.USD, Name = "Merck & Co.", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "IE00BTN1Y115", Address = "20 On Hatch Lower Hatch Street Dublin 2 Ireland", Country = "IE", Currency = CurrencyType.USD, Name = "Medtronic PLC", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US0378331005", Address = "One Apple Park Way Cupertino, CA 95014 United States", Country = "US", Currency = CurrencyType.USD, Name = "Apple", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US0028241000", Address = "100 Abbott Park Road Abbott Park North Chicago, IL 60064-6400 United States", Country = "US", Currency = CurrencyType.USD, Name = "Abbott Laboratories", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US4781601046", Address = "One Johnson & Johnson Plaza New Brunswick, NJ 08933 United States", Country = "US", Currency = CurrencyType.USD, Name = "Johnson & Johnson", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US5949181045", Address = "One Microsoft Way Redmond, WA 98052-6399 United States", Country = "US", Currency = CurrencyType.USD, Name = "Microsoft", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US5324571083", Address = "Lilly Corporate Center Indianapolis, IN 46285 United States", Country = "US", Currency = CurrencyType.USD, Name = "Eli Lilly & Co", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US46434G7723", Address = "ETF", Country = "US", Currency = CurrencyType.USD, Name = "iShares MSCI Taiwan ETF", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US74347Y8883", Address = "ETF", Country = "US", Currency = CurrencyType.USD, Name = "ProShares Ultra Bloomberg Crude Oil", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US6549022043", Address = "Karakaari 7 Espoo, 02610 Finland", Country = "FI", Currency = CurrencyType.USD, Name = "Nokia Oyj", TaxReductionText = "10. člen, odstavek 2b" },
                new CompanyEntity { ISIN = "US09075F1075", Address = "9540 Towne Centre Drive Suite 100 San Diego, CA 92121 United States", Country = "US", Currency = CurrencyType.USD, Name = "BioNano Genomics Inc", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US88160R1014", Address = "1 Tesla Road Austin, TX 78725 United States", Country = "US", Currency = CurrencyType.USD, Name = "Tesla Motors, Inc.", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US9344231041", Address = "230 Park Avenue South New York, NY 10003 United States", Country = "US", Currency = CurrencyType.USD, Name = "Warner Bros Discovery Inc", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US70450Y1038", Address = "2211 North First Street San Jose, CA 95131 United States", Country = "US", Currency = CurrencyType.USD, Name = "PayPal Holdings", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US19260Q1076", Address = "251 Little Falls Drive Wilmington, DE 19808 United States", Country = "US", Currency = CurrencyType.USD, Name = "Coinbase Global Inc", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US02079K1079", Address = "1600 Amphitheatre Parkway Mountain View, CA 94043 United States", Country = "US", Currency = CurrencyType.USD, Name = "Alphabet", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US0231351067", Address = "410 Terry Avenue North Seattle, WA 98109-5210 United States", Country = "US", Currency = CurrencyType.USD, Name = "Amazon.com Inc", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US30303M1027", Address = "1 Meta Way Menlo Park, CA 94025 United States", Country = "US", Currency = CurrencyType.USD, Name = "Meta Platforms Inc", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US72919P2020", Address = "968 Albany Shaker Road Latham, NY 12110 United States", Country = "US", Currency = CurrencyType.USD, Name = "Plug Power Inc", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US64110L1061", Address = "121 Albright Way Los Gatos, CA 95032 United States", Country = "US", Currency = CurrencyType.USD, Name = "Netflix, Inc.", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US7475251036", Address = "5775 Morehouse Drive San Diego, CA 92121-1714 United States", Country = "US", Currency = CurrencyType.USD, Name = "Qualcomm Inc", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US0079031078", Address = "2485 Augustine Drive Santa Clara, CA 95054 United States", Country = "US", Currency = CurrencyType.USD, Name = "Advanced Micro Devices Inc", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US00724F1012", Address = "345 Park Avenue San Jose, CA 95110-2704 United States", Country = "US", Currency = CurrencyType.USD, Name = "Adobe Systems Inc", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US67066G1040", Address = "2788 San Tomas Expressway Santa Clara, CA 95051 United States", Country = "US", Currency = CurrencyType.USD, Name = "NVIDIA Corporation", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US4581401001", Address = "2200 Mission College Boulevard Santa Clara, CA 95054-1549 United States", Country = "US", Currency = CurrencyType.USD, Name = "Intel", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US0090661010", Address = "888 Brannan Street San Francisco, CA 94103 United States", Country = "US", Currency = CurrencyType.USD, Name = "Airbnb Inc", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "USN070592100", Address = "De Run 6501 Veldhoven 5504 DR Netherlands", Country = "US", Currency = CurrencyType.USD, Name = "ASML Holding NV - ADR", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US02079K3059", Address = "1600 Amphitheatre Parkway Mountain View, CA 94043 United States", Country = "US", Currency = CurrencyType.USD, Name = "Alphabet Inc Class A", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US45784P1012", Address = "100 Nagog Park Acton, MA 01720", Country = "US", Currency = CurrencyType.USD, Name = "Insulet Corp.", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "ES0157097017", Address = "Ronda Del General Miter, 151 Barcelona 08022 Spain", Country = "ES", Currency = CurrencyType.EUR, Name = "Laboratorios Almirall SA", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US8753722037", Address = "12400 High Bluff Drive San Diego, CA 92130 United States", Country = "US", Currency = CurrencyType.USD, Name = "Tandem Diabetes Care Inc", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "DE000BAY0017", Address = "Kaiser-Wilhelm-Allee 1 Leverkusen 51368 Germany", Country = "DE", Currency = CurrencyType.EUR, Name = "Bayer AG", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US2521311074", Address = "6340 Sequence Drive San Diego, CA 92121 United States", Country = "US", Currency = CurrencyType.USD, Name = "DexCom Inc", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "CH0012032048", Address = "Grenzacherstrasse 124 Basel 4058 Switzerland", Country = "CH", Currency = CurrencyType.CHF, Name = "Roche Holding Ltd", TaxReductionText = "" },
                new CompanyEntity { ISIN = "GB0009895292", Address = "1 Francis Crick Avenue Cambridge Biomedical Campus Cambridge CB2 0AA United Kingdom", Country = "GB", Currency = CurrencyType.GBX, Name = "AstraZeneca", TaxReductionText = "" },
                new CompanyEntity { ISIN = "FR0000120578", Address = "54, Rue La BoEtie Paris 75008 France", Country = "FR", Currency = CurrencyType.EUR, Name = "Sanofi", TaxReductionText = "" },
                new CompanyEntity { ISIN = "US6701002056", Address = "Novo AllE 1 Bagsvaerd 2880 Denmark", Country = "DK", Currency = CurrencyType.USD, Name = "Novo-Nordisk A/S SPONS ADR", TaxReductionText = "10. clen, odstavek 2d" },
                new CompanyEntity { ISIN = "DE0007236101", Address = "Werner-von-Siemens-Strasse 1 Munich 80333 Germany", Country = "DE", Currency = CurrencyType.EUR, Name = "Siemens Aktiengesellschaft", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "DE0006231004", Address = "Am Campeon 1-15 Neubiberg 85579 Germany", Country = "DE", Currency = CurrencyType.EUR, Name = "Infineon Technologies AG", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US66987V1098", Address = "Lichtstrasse 35 Basel 4056 Switzerland", Country = "CH", Currency = CurrencyType.USD, Name = "Novartis ADR", TaxReductionText = "" },
                new CompanyEntity { ISIN = "GB0007980591", Address = "1 St James's Square London SW1Y 4PD United Kingdom", Country = "GB", Currency = CurrencyType.GBX, Name = "BP", TaxReductionText = "" },
                new CompanyEntity { ISIN = "IE000S9YS762", Address = "Forge, 43 Church Street West Woking, GU21 6HT United Kingdom", Country = "GB", Currency = CurrencyType.USD, Name = "Linde PLC", TaxReductionText = "" },
                new CompanyEntity { ISIN = "GB00BP6MXD84", Address = "Shell Centre, 2 York Road London SE1 7NA United Kingdom", Country = "GB", Currency = CurrencyType.GBX, Name = "Shell PLC", TaxReductionText = "" },
                new CompanyEntity { ISIN = "CH0012221716", Address = "Affolternstrasse 44 Zurich 8050 Switzerland", Country = "CH", Currency = CurrencyType.CHF, Name = "ABB LTD", TaxReductionText = "" },
                new CompanyEntity { ISIN = "FR0000120271", Address = "2, place Jean Millier La DEfense 6 Courbevoie 92078 France", Country = "FR", Currency = CurrencyType.EUR, Name = "TotalEnergies SE", TaxReductionText = "" },
                new CompanyEntity { ISIN = "NL0009538784", Address = "High Tech Campus 60 Eindhoven 5656 AG Netherlands", Country = "NL", Currency = CurrencyType.USD, Name = "NXP Semiconductors", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "CH0044328745", Address = "Baerengasse 32 Zurich 8001 Switzerland", Country = "CH", Currency = CurrencyType.USD, Name = "Chubb Corp", TaxReductionText = "" },
                new CompanyEntity { ISIN = "DE0005557508", Address = "Friedrich-Ebert-Allee 140 Bonn 53113 Germany", Country = "DE", Currency = CurrencyType.EUR, Name = "Deutsche Telekom AG", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "CH0011075394", Address = "Mythenquai 2 Zurich 8002 Switzerland", Country = "CH", Currency = CurrencyType.CHF, Name = "Zurich Insurance Group Ltd", TaxReductionText = "" },
                new CompanyEntity { ISIN = "CH0038863350", Address = "Avenue Nestlé 55 Vevey 1800 Switzerland", Country = "CH", Currency = CurrencyType.CHF, Name = "Nestle SA", TaxReductionText = "" },
                new CompanyEntity { ISIN = "CH0244767585", Address = "Bahnhofstrasse 45 P.O. Box Zurich 8001 Switzerland", Country = "CH", Currency = CurrencyType.CHF, Name = "UBS Group AG", TaxReductionText = "" },
                new CompanyEntity { ISIN = "NL0000235190", Address = "Mendelweg 30 Leiden 2333 CS Netherlands", Country = "NL", Currency = CurrencyType.EUR, Name = "AIRBUS SE", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "FR0000121014", Address = "22, Avenue Montaigne Paris 75008 France", Country = "FR", Currency = CurrencyType.EUR, Name = "LVMH Moet Hennessy Louis Vuitton SA", TaxReductionText = "" },
                new CompanyEntity { ISIN = "NL00150001Q9", Address = "Giorgio Fossati Taurusavenue 1 Hoofddorp 2132 LS Netherlands", Country = "NL", Currency = CurrencyType.USD, Name = "Stellantis NV", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "ES0148396007", Address = "Edificio Inditex Avenida de la DiputaciOn s/n Arteixo Corunna 15143 Spain", Country = "ES", Currency = CurrencyType.EUR, Name = "Industria de Diseno Textil SA", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "DE000BASF111", Address = "Carl-Bosch-Strasse 38 Ludwigshafen am Rhein 67056 Germany", Country = "DE", Currency = CurrencyType.EUR, Name = "BASF SE", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "DE0007100000", Address = "Mercedesstrasse 120 Stuttgart 70372 Germany", Country = "DE", Currency = CurrencyType.EUR, Name = "Mercedes-Benz Group AG", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US05964H1059", Address = "Santander Group City Av. de Cantabria s/n Boadilla del Monte Madrid 28660 Spain", Country = "ES", Currency = CurrencyType.USD, Name = "Banco Santander SA (US)-ADR", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "BE0974293251", Address = "Brouwerijplein 1 Leuven 3000 Belgium", Country = "BE", Currency = CurrencyType.EUR, Name = "Anheuser Busch InBev", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "FR0000121485", Address = "40 rue de SEvres Paris 75007 France", Country = "FR", Currency = CurrencyType.EUR, Name = "Kering SA", TaxReductionText = "" },
                new CompanyEntity { ISIN = "NL0011821202", Address = "Bijlmerdreef 106 Amsterdam 1102 CT Netherlands", Country = "NL", Currency = CurrencyType.EUR, Name = "ING Groep NV", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "DE0008404005", Address = "KOeniginstrasse 28 Munich 80802 Germany", Country = "DE", Currency = CurrencyType.EUR, Name = "Allianz SE", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "FR0000120628", Address = "25, avenue Matignon Paris 75008 France", Country = "FR", Currency = CurrencyType.EUR, Name = "AXA Group", TaxReductionText = "" },
                new CompanyEntity { ISIN = "DE0005552004", Address = "Platz der Deutschen Post Bonn 53113 Germany", Country = "DE", Currency = CurrencyType.EUR, Name = "Deutsche Post AG", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "NL0010273215", Address = "De Run 6501 Veldhoven 5504 DR Netherlands", Country = "NL", Currency = CurrencyType.USD, Name = "ASML Holding NV", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US8808901081", Address = "26 Boulevard Royal 4th Floor Luxembourg City 2449 Luxembourg", Country = "LU", Currency = CurrencyType.USD, Name = "Ternium SA-ADR", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US3444191064", Address = "General Anaya Nº 601 Pte. Col. Bella Vista Monterrey, NL 64410 Mexico", Country = "MX", Currency = CurrencyType.USD, Name = "Fomento Economico Mexicano SAB-ADR", TaxReductionText = "" },
                new CompanyEntity { ISIN = "LU0584671464", Address = "Vertigo Naos Building 6, Rue EugEne Ruppert Luxembourg City 2453 Luxembourg", Country = "LU", Currency = CurrencyType.USD, Name = "Adecoagro S.A.", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "DE000A1EWWW0", Address = "Adi-Dassler-Strasse 1 Herzogenaurach 91074 Germany", Country = "DE", Currency = CurrencyType.USD, Name = "Adidas AG", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "DE0007664039", Address = "Berliner Ring 2 Wolfsburg 38440 Germany", Country = "DE", Currency = CurrencyType.EUR, Name = "Volkswagen AG", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "FR0000120073", Address = "75 quai d'Orsay cedex 07 Paris 75321 France", Country = "FR", Currency = CurrencyType.EUR, Name = "Air Liquide SA", TaxReductionText = "" },
                new CompanyEntity { ISIN = "FR0000121972", Address = "35 rue Joseph Monier Rueil-Malmaison 92506 France", Country = "FR", Currency = CurrencyType.EUR, Name = "Schneider Electric SE", TaxReductionText = "" },
                new CompanyEntity { ISIN = "US86959K1051", Address = "Av. Professor MagalhAes Neto, 1,752 10th Floor Rooms 1010 and 1011 Salvador, BA 41810-012 Brazil", Country = "BR", Currency = CurrencyType.USD, Name = "Suzano SA-ADR", TaxReductionText = "" },
                new CompanyEntity { ISIN = "DE0007164600", Address = "Dietmar-Hopp-Allee 16 Walldorf 69190 Germany", Country = "DE", Currency = CurrencyType.EUR, Name = "SAP SE", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US05967A1079", Address = "Banco Santander (Brasil) SA Avenida Juscelino Kubitschek 2235 & 2041, Bloco A Vila Olímpia Sao Paulo, Sao Paulo 04543-011 Brazil", Country = "BR", Currency = CurrencyType.USD, Name = "Banco Santander Brasil SA", TaxReductionText = "" },
                new CompanyEntity { ISIN = "US2044096012", Address = "Avenida Barbacena, 1200 Belo Horizonte, MG 30190-131 Brazil", Country = "BR", Currency = CurrencyType.USD, Name = "Companhia Energetica de Minas Gerais-ADR", TaxReductionText = "" },
                new CompanyEntity { ISIN = "FR0000131104", Address = "16 boulevard des Italiens Paris 75009 France", Country = "FR", Currency = CurrencyType.EUR, Name = "BNP Paribas SA", TaxReductionText = "" },
                new CompanyEntity { ISIN = "US8336351056", Address = "El Trovador 4285 6th Floor Las Condes Santiago de Chile Chile", Country = "CL", Currency = CurrencyType.USD, Name = "Sociedad Quimica y Minera de Chile SA-ADR", TaxReductionText = "" },
                new CompanyEntity { ISIN = "US84265V1052", Address = "1440 East Missouri Avenue Suite 160 Phoenix, AZ 85014 United States", Country = "US", Currency = CurrencyType.USD, Name = "Southern Copper Corp", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US20440W1053", Address = "Av. Brigadeiro Faria Lima, 3400 19th and 20th Floors Itaim Bibi Sao Paulo, SP 04538-132 Brazil", Country = "BR", Currency = CurrencyType.USD, Name = "Cia Siderurgica Nacional SA-ADR", TaxReductionText = "" },
                new CompanyEntity { ISIN = "US3737371050", Address = "Av. Dra. Ruth Cardoso, 8,501 8° andar Sao Paulo, SP 05425-070 Brazil", Country = "BR", Currency = CurrencyType.USD, Name = "Gerdau SA-ADR", TaxReductionText = "" },
                new CompanyEntity { ISIN = "CA9628791027", Address = "1021 West Hastings Street Suite 3500 Vancouver, BC V6E 0C3 Canada", Country = "CA", Currency = CurrencyType.USD, Name = "Wheaton Precious Metals Corp", TaxReductionText = "10. clen, odstavek 2d" },
                new CompanyEntity { ISIN = "US0594603039", Address = "Cidade De Deus, S/N Vila Yara Osasco, SP 06029-900 Brazil", Country = "BR", Currency = CurrencyType.USD, Name = "Banco Bradesco ADR", TaxReductionText = "" },
                new CompanyEntity { ISIN = "BMG2519Y1084", Address = "Calle Centenario 156 La Molina Lima 12 Peru", Country = "PE", Currency = CurrencyType.USD, Name = "Credicorp Ltd", TaxReductionText = "" },
                new CompanyEntity { ISIN = "PR3186727065", Address = "1519 Ponce de Leon Ave. Stop 23 PO Box 9146 San Juan, PR 00908-0146 United States", Country = "US", Currency = CurrencyType.USD, Name = "First BanCorp/Puerto Rico", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US4655621062", Address = "PraCa Alfredo Egydio de Souza Aranha 100 Sao Paulo, SP 04344-902 Brazil", Country = "BR", Currency = CurrencyType.USD, Name = "Itau Unibanco Holding ADR", TaxReductionText = "" },
                new CompanyEntity { ISIN = "ES0144580Y14", Address = "Plaza Euskadi 5 Bilbao 48009 Spain", Country = "ES", Currency = CurrencyType.EUR, Name = "Iberdrola", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US71654V1017", Address = "Avenida RepUblica do Chile, 65 Centro Rio De Janeiro, RJ 20031-912 Brazil", Country = "BR", Currency = CurrencyType.USD, Name = "Petroleo Brasileiro ADR", TaxReductionText = "" },
                new CompanyEntity { ISIN = "PR7331747001", Address = "209 MuNoz Rivera Avenue Hato Rey, PR 00918 United States", Country = "US", Currency = CurrencyType.USD, Name = "Popular Inc", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US20441A1025", Address = "Rua Costa Carvalho, 300 Sao Paulo, SP 05429-900 Brazil", Country = "BR", Currency = CurrencyType.USD, Name = "Cia de Saneamento Basico do Estado de Sao Paulo-ADR", TaxReductionText = "" },
                new CompanyEntity { ISIN = "CA98462Y1007", Address = "Royal Bank Plaza Suite 2200 North Tower 200 Bay Street Toronto, ON M5J 2J3 Canada", Country = "CA", Currency = CurrencyType.USD, Name = "Yamana Gold Inc", TaxReductionText = "10. clen, odstavek 2d" },
                new CompanyEntity { ISIN = "US02390A1016", Address = "Lago Zurich 245 Plaza Carso / Edificio Telcel, Piso 16 Colonia Ampliación Granada Miguel Hidalgo Mexico City, DF 11529 Mexico", Country = "US", Currency = CurrencyType.USD, Name = "America Movil, S.A.B. de C.V.-ADR", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US91912E1055", Address = "Praia de Botafogo 186 Salas 501 a 1901 18 andar Botafogo Rio De Janeiro, RJ 22250-145 Brazil", Country = "BR", Currency = CurrencyType.USD, Name = "Vale SA-ADR", TaxReductionText = "" },
                new CompanyEntity { ISIN = "US15234Q2075", Address = "Rua da Quitanda, 196 9th Floor Centro Rio De Janeiro, RJ 20091-005 Brazil", Country = "BR", Currency = CurrencyType.USD, Name = "Centrais Eletricas Brasileiras - ADR", TaxReductionText = "" },
                new CompanyEntity { ISIN = "CH0210483332", Address = "50, chemin de la Chênaie CP30 Bellevue 1293 Switzerland", Country = "CH", Currency = CurrencyType.CHF, Name = "Compagnie Financiere Richemont SA", TaxReductionText = "" },
                new CompanyEntity { ISIN = "US87936R2058", Address = "Av. Engenheiro Luis Carlos Berrini 1376,32º andar Sao Paulo, SP 04571-936 Brazil", Country = "BR", Currency = CurrencyType.USD, Name = "Telefônica Brasil SA-ADR", TaxReductionText = "" },
                new CompanyEntity { ISIN = "GB0001383545", Address = "ETF", Country = "GB", Currency = CurrencyType.GBP, Name = "UK100 Index", TaxReductionText = "" },
                new CompanyEntity { ISIN = "ES0113900J37", Address = "Santander Group City Av. de Cantabria s/n Boadilla del Monte Madrid 28660 Spain ", Country = "ES", Currency = CurrencyType.EUR, Name = "Banco Santander SA", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "FI0009000681", Address = "Karakaari 7 Espoo 02610 Finland", Country = "FI", Currency = CurrencyType.EUR, Name = "Nokia Corp.", TaxReductionText = "10. clen, odstavek 1b" },
                new CompanyEntity { ISIN = "ES0173516115", Address = "Repsol Campus C/ Mendez Alvaro, 44 Madrid 28045 Spain", Country = "ES", Currency = CurrencyType.EUR, Name = "Repsol", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "GB00BN7SWP63", Address = "980 Great West Road Middlesex Brentford TW8 9GS United Kingdom", Country = "GB", Currency = CurrencyType.GBX, Name = "GlaxoSmithKline", TaxReductionText = "" },
                new CompanyEntity { ISIN = "DE0005190003", Address = "Petuelring 130 Munich 80809 Germany", Country = "DE", Currency = CurrencyType.EUR, Name = "Bayerische Motoren Werke Aktiengesellschaft", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "FR0000125486", Address = "1973 boulevard de la Défense CS 10268 Cedex Nanterre 92757 France", Country = "FR", Currency = CurrencyType.EUR, Name = "Vinci S.A", TaxReductionText = "" },
                new CompanyEntity { ISIN = "DE0008430026", Address = "Königinstr. 107 Munich 80802 Germany", Country = "DE", Currency = CurrencyType.EUR, Name = "Muenchener Rueckvrschrng Gslchft AG Mnch", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "CH0418792922", Address = "Zugerstrasse 50 Baar 6340 Switzerland", Country = "CH", Currency = CurrencyType.CHF, Name = "Sika Ltd", TaxReductionText = "" },
                new CompanyEntity { ISIN = "NL0000226223", Address = "39 Chemin du Champ des Filles 1228 Plan-Les-Ouates Geneva Switzerland", Country = "FR", Currency = CurrencyType.EUR, Name = "STMicroelectronics NV", TaxReductionText = "" },
                new CompanyEntity { ISIN = "US63884N1081", Address = "Avenida Alexandre Colares No. 1188, Sala A17-Bloco A Parque Anhanguera Sao Paulo, SP 05106-000 Brazil", Country = "US", Currency = CurrencyType.USD, Name = "Natura & Co Holding SA-ADR", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "KYG851581069", Address = "Harbour Place 4th Floor 103 South Church Street PO Box 10240 George Town KY1-1002 Cayman Islands", Country = "KY", Currency = CurrencyType.USD, Name = "StoneCo Ltd A", TaxReductionText = "" },
                new CompanyEntity { ISIN = "KYG6683N1034", Address = "Rua Capote Valente, 39 Sao Paulo, SP 5409-0000 Brazil ", Country = "US", Currency = CurrencyType.USD, Name = "Nu Holdings Ltd.", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US58733R1023", Address = "WTC Free Zone Dr. Luis Bonavita 1294 Of. 1733 Tower II Montevideo 11300 Uruguay", Country = "US", Currency = CurrencyType.USD, Name = "MercadoLibre", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US40049J2069", Address = "Av. Vasco de Quiroga 2000 Building A Floor 4,Delegación Alvaro Obregón Col. Santa Fe Mexico City, DF 12210 Mexico", Country = "US", Currency = CurrencyType.USD, Name = "Grupo Televisa, S.A.B.-ADR", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "KYG290181018", Address = "Dr. Luis Bonavita 1294 Montevideo 11300 Uruguay", Country = "US", Currency = CurrencyType.USD, Name = "dLocal Ltd.", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US38045R2067", Address = "Praca Comandante Linneu Gomes, S/N Portaria 3, prEdio 24 Jardim Aeroporto Sao Paulo, SP 04626-020 Brazil", Country = "US", Currency = CurrencyType.USD, Name = "Gol Linhas Aereas Inteligentes SA-ADR", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US25490K5965", Address = "ETF", Country = "US", Currency = CurrencyType.USD, Name = "Direxion Shares Etf Trust-Direxion Daily Homebuilders & Supplies Bull 3x Shares", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US82575P1075", Address = "Constantia Office Park Cnr 14th Ave & Hendrik Potgieter Rd, 1709, Weltevreden Park, South Africa", Country = "ZA", Currency = CurrencyType.USD, Name = "Sibanye Stillwater Ltd-ADR", TaxReductionText = "" },
                new CompanyEntity { ISIN = "US8552441094", Address = "2401 Utah Avenue South Seattle, WA 98134 United States", Country = "US", Currency = CurrencyType.USD, Name = "Starbucks Corporation", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US7134481081", Address = "700 Anderson Hill Road Purchase, NY 10577 United States", Country = "US", Currency = CurrencyType.USD, Name = "PepsiCo", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US60770K1079", Address = "200 Technology Square Cambridge, MA 02139 United States", Country = "US", Currency = CurrencyType.USD, Name = "Moderna Inc", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "NL0012969182", Address = "Simon Carmiggeltstraat 6-50 Amsterdam, 1011 DJ Netherlands", Country = "NL", Currency = CurrencyType.EUR, Name = "Adyen NV", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "KYG982391099", Address = "20, Genesis Close George Town Grand Cayman KY-1-1208 Cayman Islands", Country = "US", Currency = CurrencyType.USD, Name = "XP Inc", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US1512908898", Address = "Avenida Ricardo Margáin Zozaya #325 Colonia Valle del Campestre San Pedro Garza García, NL 66265 Mexico", Country = "MX", Currency = CurrencyType.USD, Name = "Cemex, S.A.B. de C.V.-ADR", TaxReductionText = "" },
                new CompanyEntity { ISIN = "US10552T1079", Address = "Av. Das NaCOes Unidas 14.401 22nd to 25th Floors Torre JequitibA CondomInio Parque da Cid ChAcara Santo AntOnio Sao Paulo, SP 04730-090 Brazil", Country = "BR", Currency = CurrencyType.USD, Name = "BRF SA-ADR", TaxReductionText = "" },
                new CompanyEntity { ISIN = "US29082A1079", Address = "Eldorado Business Tower 30th floor Avenida Dra. Ruth Cardoso, No. 8,501 Pinheiros Sao Paulo, SP 05425-070 Brazil", Country = "BR", Currency = CurrencyType.USD, Name = "Embraer SA-ADR", TaxReductionText = "" },
                new CompanyEntity { ISIN = "KYG687071012", Address = "Avenida Brigadeiro Faria Lima, 1384 4º andar Parte A Sao Paulo, SP 01451-001 Brazil", Country = "BR", Currency = CurrencyType.USD, Name = "Pagseguro Digital Ltd", TaxReductionText = "" },
                new CompanyEntity { ISIN = "LU0974299876", Address = "37A Avenue J.F. Kennedy Luxembourg City, 1855 Luxembourg", Country = "LU", Currency = CurrencyType.USD, Name = "Globant SA", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US02319V1035", Address = "Rua Dr. Renato Paes de Barros, 1017 3rd Floor Sao Paulo, SP 04530-001 Brazil", Country = "US", Currency = CurrencyType.USD, Name = "Ambev ADR", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US05501U1060", Address = "Av. Marcos Penteado de Ulhôa Rodrigues n. 939, 8th floor Edifício Jatobá CondomA-nio Castelo Branco Office Park Tamboré Barueri, SP Brazil", Country = "BR", Currency = CurrencyType.USD, Name = "Azul SA-ADR", TaxReductionText = "" },
                new CompanyEntity { ISIN = "US88688T1007", Address = "265 Talbot Street West Leamington, ON N8H 5L4 Canada", Country = "CA", Currency = CurrencyType.USD, Name = "Tilray Brands Inc", TaxReductionText = "10. clen, odstavek 2d" },
                new CompanyEntity { ISIN = "PAP310761054", Address = "Boulevard Costa del Este Av. Principal y Av. de la Rotonda UrbanizaciOn Costa del Este Complejo Business Park,Torre Norte, Parq Panama City 0816-06819 Panama", Country = "US", Currency = CurrencyType.USD, Name = "Copa Holdings SA", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "DE0007037129", Address = "Zugerstrasse 50 Baar 6340 Switzerland", Country = "DE", Currency = CurrencyType.EUR, Name = "RWE AG", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "CH0013841017", Address = "Muenchensteinerstrasse 38 Basel 4002 Switzerland", Country = "CH", Currency = CurrencyType.CHF, Name = "Lonza Group Ltd", TaxReductionText = "" },
                new CompanyEntity { ISIN = "CH1169360919", Address = "Bruggerstrasse 71a Baden 5400 Switzerland", Country = "CH", Currency = CurrencyType.CHF, Name = "Accelleron Industries Ltd", TaxReductionText = "" },
                new CompanyEntity { ISIN = "US1101221083", Address = "Route 206 & Province Line Road Princeton, NY 08543 United States", Country = "US", Currency = CurrencyType.USD, Name = "Bristol-Myers Squibb Co", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US9229085538", Address = "ETF", Country = "US", Currency = CurrencyType.USD, Name = "Vanguard Real Estate ETF", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "KYG872641009", Address = "Av. Circunvalar a 100 mts de la Via 40 Barrio Las Flores Barranquilla, 33142 Colombia", Country = "CO", Currency = CurrencyType.USD, Name = "Tecnoglass Inc", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "GB0001383545", Address = "INDEX", Country = "GB", Currency = CurrencyType.GBP, Name = "UK100 Index (Non Expiry)", TaxReductionText = "10. clen, odstavek 2a" },
                new CompanyEntity { ISIN = "US92837L1098", Address = "Pedregal 24, Floor 4 Mexico City, DF 11040 Mexico", Country = "MX", Currency = CurrencyType.USD, Name = "Vista Energy SAB de CV", TaxReductionText = "" },
                new CompanyEntity { ISIN = "US9842451000", Address = "", Country = "Macacha GUeemes 515, Ciudad Autonoma de Buenos Aires, C1106BKK Argentina", Currency = CurrencyType.USD, Name = "YPF Sociedad Anónima", TaxReductionText = "" },
                new CompanyEntity { ISIN = "US81689T1043", Address = "Avenida Ayrton Senna, No. 6,000 Rio De Janeiro, 22775-005 Brazil", Country = "BR", Currency = CurrencyType.USD, Name = "Sendas Distribuidora SA", TaxReductionText = "" },
                new CompanyEntity { ISIN = "CA8265991023", Address = "Avenida Nove de Julho 4939, 9th Floor, Office 84 São Paulo, SP 01407-200 Brazil", Country = "BR", Currency = CurrencyType.USD, Name = "Sigma Lithium Corporation", TaxReductionText = "" },
                new CompanyEntity { ISIN = "US05464C1018", Address = "17800 North 85th Street Scottsdale, Arizona 85255 United States", Country = "US", Currency = CurrencyType.USD, Name = "Axon Enterprise Inc", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "FR0000120644", Address = "17, Boulevard Haussmann Paris, 75009 France", Country = "FR", Currency = CurrencyType.EUR, Name = "Danone S.A", TaxReductionText = "" },
                new CompanyEntity { ISIN = "US1280302027", Address = "1052 Highland Colony Parkway, Suite 200 Ridgeland, Mississippi 39157 United States", Country = "US", Currency = CurrencyType.USD, Name = "Cal-Maine Foods, Inc", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "IL0065100930", Address = "9 Andrei Sakharov Street, PO Box 15067 Haifa, 3190500 Israel", Country = "IL", Currency = CurrencyType.USD, Name = "ZIM Shipping Services Ltd", TaxReductionText = "10. clen, odstavek 2c" },
                new CompanyEntity { ISIN = "GB0031743007", Address = "Horseferry House London, SW1P 2AW United Kingdom", Country = "GB", Currency = CurrencyType.GBX, Name = "Burberry Group", TaxReductionText = "" },
                new CompanyEntity { ISIN = "GB0005405286", Address = "8 Canada Square London, E14 5HQ United Kingdom", Country = "GB", Currency = CurrencyType.GBX, Name = "HSBC Holdings", TaxReductionText = "" },
                new CompanyEntity { ISIN = "GB0000811801", Address = "Barratt House Coalville, LE67 1UF United Kingdom", Country = "GB", Currency = CurrencyType.GBX, Name = "Barratt Redrow PLC", TaxReductionText = "" },
                new CompanyEntity { ISIN = "US4005011022", Address = "Plaza Metrópoli Patriotismo, Piso 5, Av. Patriotismo 201 Mexico City, DF 03800 Mexico", Country = "MX", Currency = CurrencyType.USD, Name = "Grupo Aeroportuario del Centro Norte S.A.B. de C.V.", TaxReductionText = "" },
                new CompanyEntity { ISIN = "US01609W1027", Address = "969 West Wen Yi Road, Yu Hang District Hangzhou, 311121 China", Country = "CN", Currency = CurrencyType.USD, Name = "Alibaba-ADR", TaxReductionText = "10. clen, odstavek 2" },
                new CompanyEntity { ISIN = "IE00BGSF1X88", Address = "Bond", Country = "US", Currency = CurrencyType.USD, Name = "iShares $ Treasury Bond 0-1yr UCITS ETF", TaxReductionText = "" },
                new CompanyEntity { ISIN = "US2546871060", Address = "500 South Buena Vista Street Burbank, California 91521 United States", Country = "US", Currency = CurrencyType.USD, Name = "Walt Disney", TaxReductionText = "" },
                new CompanyEntity { ISIN = "US7999261008", Address = "Forum 1 Basel, 4056 Switzerland", Country = "CH", Currency = CurrencyType.USD, Name = "Sandoz Group AG-ADR", TaxReductionText = "" },
                new CompanyEntity { ISIN = "US11135F1012", Address = "3421 Hillview Ave Palo Alto, California 94304 United States", Country = "US", Currency = CurrencyType.USD, Name = "Broadcom Inc", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US22788C1053", Address = "206 East 9th Street, Suite 1400 Austin, Texas 78701 United States", Country = "US", Currency = CurrencyType.USD, Name = "Crowdstrike Holdings", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US02376R1023", Address = "1 Skyview Drive Fort Worth, Texas 76155 United States", Country = "US", Currency = CurrencyType.USD, Name = "Anglo American", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "NL0011585146", Address = "Via Abetone Inferiore n. 4 Maranello, Missouri 41053 Italy", Country = "IT", Currency = CurrencyType.USD, Name = "Ferrari NV", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "IT0000072618", Address = "Piazza San Carlo, 156 Turin, 10121 Italy", Country = "IT", Currency = CurrencyType.EUR, Name = "Intesa Sanpaolo Group", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "IT0005239360", Address = "Tower A Milan, 20154 Italy", Country = "IT", Currency = CurrencyType.EUR, Name = "UniCredit Commercial Bank", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "LU1778762911", Address = "5, Place de la Gare Luxembourg, 1616 Luxembourg", Country = "LU", Currency = CurrencyType.USD, Name = "Spotify Technologies SA", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US0420682058", Address = "110 Fulbourn Road Cambridge, CB1 9NJ United Kingdom", Country = "GB", Currency = CurrencyType.USD, Name = "ARM Holdings PLC", TaxReductionText = "" },
                new CompanyEntity { ISIN = "US46138E3541", Address = "ETF", Country = "US", Currency = CurrencyType.USD, Name = "Invesco S&P 500 Low Volatility", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US5288723027", Address = "2445 Technology Forest Boulevard, 11th Floor The Woodlands, Texas 77381 United States", Country = "US", Currency = CurrencyType.USD, Name = "Lexicon Pharmaceuticals Inc", TaxReductionText = "" },
                new CompanyEntity { ISIN = "US40637H1095", Address = "12390 El Camino Real San Diego, California 92130 United States", Country = "US", Currency = CurrencyType.USD, Name = "Halozyme Therapeutics Inc", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US56400P7069", Address = "1 Casper Street Danbury, Connecticut 06810 United States", Country = "US", Currency = CurrencyType.USD, Name = "MannKind Corp", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "IT0003128367", Address = "Viale Regina Margherita, 137 Rome, 00198 Italy", Country = "IT", Currency = CurrencyType.EUR, Name = "Enel Power Company", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "IT0003132476", Address = "Piazzale Enrico Mattei 1 Rome, 00144 Italy", Country = "IT", Currency = CurrencyType.EUR, Name = "Eni Energy Company", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "NL0000226223", Address = "WTC Schiphol Airport Schiphol, Noord-Holland 1118 BH Netherlands", Country = "NL", Currency = CurrencyType.EUR, Name = "STMicroelectronics Company", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US37733W2044", Address = "980 Great West Road, Middlesex Brentford, TW8 9GS United Kingdom", Country = "GB", Currency = CurrencyType.USD, Name = "GlaxoSmithKline plc ADR", TaxReductionText = "" },
                new CompanyEntity { ISIN = "IE0001827041", Address = "Stonemason’s Way, Rathfarnham Dublin, 16 Ireland", Country = "IE", Currency = CurrencyType.GBX, Name = "CRH plc", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US88706T1088", Address = "JoAo Cabral de Melo Neto Avenue, 850 North Tower Rio De Janeiro, RJ 22775-057 Brazil", Country = "BR", Currency = CurrencyType.USD, Name = "TIM SA", TaxReductionText = "" },
                new CompanyEntity { ISIN = "JE00BJVNSS43", Address = "751 Lakefront Commons Newport News, Virginia 23606 United States", Country = "US", Currency = CurrencyType.GBX, Name = "Ferguson PLC", TaxReductionText = "" },
                new CompanyEntity { ISIN = "CY0200352116", Address = "Iris House, 8, John Kennedy Street Limassol, 3106 Cyprus", Country = "CY", Currency = CurrencyType.USD, Name = "Frontline PLC", TaxReductionText = "10. clen, odstavek 2" },
                new CompanyEntity { ISIN = "CA15135U1093", Address = "4100, 225 – 6 Avenue SW, PO Box 766 Calgary, AB T2P 0M5 Canada", Country = "CA", Currency = CurrencyType.USD, Name = "Cenovus Energy Inc", TaxReductionText = "10. clen, odstavek 2d" },
                new CompanyEntity { ISIN = "US81369Y8527", Address = "ETF", Country = "US", Currency = CurrencyType.USD, Name = "Communication Services Select Sector SPDR Fund", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US81369Y4070", Address = "ETF", Country = "US", Currency = CurrencyType.USD, Name = "Consumer Discret Select Sector SPDR", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "MHY7542C1306", Address = "99 Boulevard du Jardin Exotique Monaco, 98000 Monaco", Country = "MC", Currency = CurrencyType.USD, Name = "Scorpio Tankers Inc", TaxReductionText = "" },
                new CompanyEntity { ISIN = "US46090E1038", Address = "ETF", Country = "US", Currency = CurrencyType.USD, Name = "Invesco QQQ", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US6516391066", Address = "6900 E Layton Avenue, Suite 700 Denver, Colorado 80237 United States", Country = "US", Currency = CurrencyType.USD, Name = "Newmont Mining Corp", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US24665A1034", Address = "310 Seven Springs Way, Suite 400 and 500 Brentwood, Tennessee 37027 United States", Country = "US", Currency = CurrencyType.USD, Name = "Delek US Holdings Inc", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US81369Y6059", Address = "ETF", Country = "US", Currency = CurrencyType.USD, Name = "Financial Select Sector SPDR", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US81369Y1001", Address = "ETF", Country = "US", Currency = CurrencyType.USD, Name = "Materials Select Sector SPDR ", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US78467X1090", Address = "ETF", Country = "US", Currency = CurrencyType.USD, Name = "SPDR Dow Jones Industrial Average ETF Trust ", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "US4642876555", Address = "ETF", Country = "US", Currency = CurrencyType.USD, Name = "Ishares Russell 2000 ETF", TaxReductionText = "10. clen, odstavek 2b" },
                new CompanyEntity { ISIN = "NO0003921009", Address = "Dokkveien 1 Oslo, 0250 Norway", Country = "NO", Currency = CurrencyType.NOK, Name = "DNO ASA", TaxReductionText = "10. clen, odstavek 2b" },
            ];

            companies = data.ToDictionary(data => data.Name, data => data);
            data = null;
        }

        public CompanyEntity GetCompany(string key) // Currently the key is the name of the company
        {
            if (companies.TryGetValue(RemoveStockTicker(key), out CompanyEntity company))
            {
                return company;
            }
            Console.WriteLine("Company " + key + " not found.");
            return new CompanyEntity { Address = "MISSING", Country = "MISSING", Currency = CurrencyType.USD, ISIN = "MISSING", Name = key, TaxReductionText = "MISSING" };
        }

        /// <summary>
        /// Removes the stock ticker from a company name.
        /// </summary>
        /// <param name="companyName">The full company name including the ticker.</param>
        /// <returns>The company name without the ticker.</returns>
        private static string RemoveStockTicker(string companyName)
        {
            int lastOpenParenIndex = companyName.LastIndexOf('(');
            int lastCloseParenIndex = companyName.LastIndexOf(')');

            // Ensure the parentheses are valid and at the end
            if (lastOpenParenIndex > 0 && lastCloseParenIndex > lastOpenParenIndex && lastCloseParenIndex == companyName.Length - 1)
            {
                return companyName.Substring(0, lastOpenParenIndex).TrimEnd();
            }
            return companyName;
        }
    }
}