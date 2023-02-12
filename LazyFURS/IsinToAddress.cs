using System;
using System.Collections.Generic;

namespace LazyFURS
{
    internal class IsinToAddress
    {
        private readonly Dictionary<string, string> data = new();

        public IsinToAddress()
        {
            data.Add("CH0012221716", "Affolternstrasse 44 Zurich 8050 Switzerland");
            data.Add("US0028241000", "100 Abbott Park Road Abbott Park North Chicago, IL 60064-6400 United States");
            data.Add("LU0584671464", "Vertigo Naos Building 6, Rue EugEne Ruppert Luxembourg City 2453 Luxembourg");
            data.Add("DE000A1EWWW0", "Adi-Dassler-Strasse 1 Herzogenaurach 91074 Germany");
            data.Add("FR0000120073", "75 quai d'Orsay cedex 07 Paris 75321 France");
            data.Add("NL0000235190", "Mendelweg 30 Leiden 2333 CS Netherlands");
            data.Add("US00162Q4525", "ETF");
            data.Add("DE0008404005", "KOeniginstrasse 28 Munich 80802 Germany");
            data.Add("US02364W1053", "Lago Zurich 245 Plaza Carso / Edificio Telcel, Piso 16 Colonia Ampliación Granada Miguel Hidalgo Mexico City, DF 11529 Mexico");
            data.Add("BE0974293251", "Brouwerijplein 1 Leuven 3000 Belgium");
            data.Add("US0378331005", "One Apple Park Way Cupertino, CA 95014 United States");
            data.Add("NL0010273215", "De Run 6501 Veldhoven 5504 DR Netherlands");
            data.Add("GB0009895292", "1 Francis Crick Avenue Cambridge Biomedical Campus Cambridge CB2 0AA United Kingdom");
            data.Add("FR0000120628", "25, avenue Matignon Paris 75008 France");
            data.Add("US0594603039", "Cidade De Deus, S/N Vila Yara Osasco, SP 06029-900 Brazil");
            data.Add("US05967A1079", "Banco Santander (Brasil) SA Avenida Juscelino Kubitschek 2235 & 2041, Bloco A Vila Olímpia São Paulo, Sao Paulo 04543-011 Brazil");
            data.Add("US05964H1059", "Santander Group City Av. de Cantabria s/n Boadilla del Monte Madrid 28660 Spain");
            data.Add("DE000BASF111", "Carl-Bosch-Strasse 38 Ludwigshafen am Rhein 67056 Germany");
            data.Add("DE000BAY0017", "Kaiser-Wilhelm-Allee 1 Leverkusen 51368 Germany");
            data.Add("US0758871091", "1 Becton Drive Franklin Lakes, NJ 07417-1880 United States");
            data.Add("FR0000131104", "16 boulevard des Italiens Paris 75009 France");
            data.Add("GB0007980591", "1 St James's Square London SW1Y 4PD United Kingdom");
            data.Add("US4642864007", "ETF");
            data.Add("US15234Q2075", "Rua da Quitanda, 196 9th Floor Centro Rio De Janeiro, RJ 20091-005 Brazil");
            data.Add("CH0044328745", "Baerengasse 32 Zurich 8001 Switzerland");
            data.Add("US20441A1025", "Rua Costa Carvalho, 300 São Paulo, SP 05429-900 Brazil");
            data.Add("US20440W1053", "Av. Brigadeiro Faria Lima, 3400 19th and 20th Floors Itaim Bibi São Paulo, SP 04538-132 Brazil");
            data.Add("CH0210483332", "50, chemin de la Chênaie CP30 Bellevue 1293 Switzerland");
            data.Add("US2044096012", "Avenida Barbacena, 1200 Belo Horizonte, MG 30190-131 Brazil");
            data.Add("BMG2519Y1084", "Calle Centenario 156 La Molina Lima 12 Peru");
            data.Add("DE0005552004", "Platz der Deutschen Post Bonn 53113 Germany");
            data.Add("DE0005557508", "Friedrich-Ebert-Allee 140 Bonn 53113 Germany");
            data.Add("US5324571083", "Lilly Corporate Center Indianapolis, IN 46285 United States");
            data.Add("US81369Y5069", "ETF");
            data.Add("PR3186727065", "1519 Ponce de Leon Ave. Stop 23 PO Box 9146 San Juan, PR 00908-0146 United States");
            data.Add("US3444191064", "General Anaya Nº 601 Pte. Col. Bella Vista Monterrey, NL 64410 Mexico");
            data.Add("US3737371050", "Av. Dra. Ruth Cardoso, 8,501 8° andar São Paulo, SP 05425-070 Brazil");
            data.Add("ES0144580Y14", "Plaza Euskadi 5 Bilbao 48009 Spain");
            data.Add("ES0148396007", "Edificio Inditex Avenida de la DiputaciOn s/n Arteixo Corunna 15143 Spain");
            data.Add("DE0006231004", "Am Campeon 1-15 Neubiberg 85579 Germany");
            data.Add("NL0011821202", "Bijlmerdreef 106 Amsterdam 1102 CT Netherlands");
            data.Add("US4581401001", "2200 Mission College Boulevard Santa Clara, CA 95054-1549 United States");
            data.Add("US46434V6213", "ETF");
            data.Add("US46434V7385", "ETF");
            data.Add("US4642866085", "ETF");
            data.Add("US4642868065", "ETF");
            data.Add("US46434G8226", "ETF");
            data.Add("US4642868222", "ETF");
            data.Add("US4642868149", "ETF");
            data.Add("US4642867497", "ETF");
            data.Add("US46434G7723", "ETF");
            data.Add("US4655621062", "PraCa Alfredo Egydio de Souza Aranha 100 São Paulo, SP 04344-902 Brazil");
            data.Add("US4781601046", "One Johnson & Johnson Plaza New Brunswick, NJ 08933 United States");
            data.Add("FR0000121485", "40 rue de SEvres Paris 75007 France");
            data.Add("ES0157097017", "Ronda Del General Miter, 151 Barcelona 08022 Spain");
            data.Add("IE00BZ12WP82", "Forge 43 Church Street West Woking GU21 6HT United Kingdom");
            data.Add("FR0000121014", "22, Avenue Montaigne Paris 75008 France");
            data.Add("IE00BTN1Y115", "20 On Hatch Lower Hatch Street Dublin 2 Ireland");
            data.Add("DE0007100000", "Mercedesstrasse 120 Stuttgart 70372 Germany");
            data.Add("US58933Y1055", "2000 Galloping Hill Road Kenilworth, NJ 07033 United States");
            data.Add("US5949181045", "One Microsoft Way Redmond, WA 98052-6399 United States");
            data.Add("CH0038863350", "Avenue Nestlé 55 Vevey 1800 Switzerland");
            data.Add("US66987V1098", "Lichtstrasse 35 Basel 4056 Switzerland");
            data.Add("US6701002056", "Novo AllE 1 Bagsvaerd 2880 Denmark");
            data.Add("US67066G1040", "2788 San Tomas Expressway Santa Clara, CA 95051 United States");
            data.Add("NL0009538784", "High Tech Campus 60 Eindhoven 5656 AG Netherlands");
            data.Add("US71654V1017", "Avenida RepUblica do Chile, 65 Centro Rio De Janeiro, RJ 20031-912 Brazil");
            data.Add("PR7331747001", "209 MuNoz Rivera Avenue Hato Rey, PR 00918 United States");
            data.Add("US7475251036", "5775 Morehouse Drive San Diego, CA 92121-1714 United States");
            data.Add("CH0012032048", "Grenzacherstrasse 124 Basel 4058 Switzerland");
            data.Add("FR0000120578", "54, Rue La BoEtie Paris 75008 France");
            data.Add("DE0007164600", "Dietmar-Hopp-Allee 16 Walldorf 69190 Germany");
            data.Add("FR0000121972", "35 rue Joseph Monier Rueil-Malmaison 92506 France");
            data.Add("US8085247976", "ETF");
            data.Add("GB00BP6MXD84", "Shell Centre, 2 York Road London SE1 7NA United Kingdom");
            data.Add("DE0007236101", "Werner-von-Siemens-Strasse 1 Munich 80333 Germany");
            data.Add("US8336351056", "El Trovador 4285 6th Floor Las Condes Santiago de Chile Chile");
            data.Add("US84265V1052", "1440 East Missouri Avenue Suite 160 Phoenix, AZ 85014 United States");
            data.Add("US78464A6982", "ETF");
            data.Add("NL00150001Q9", "Giorgio Fossati Taurusavenue 1 Hoofddorp 2132 LS Netherlands");
            data.Add("US86959K1051", "Av. Professor MagalhAes Neto, 1,752 10th Floor Rooms 1010 and 1011 Salvador, BA 41810-012 Brazil");
            data.Add("US87936R2058", "Av. Engenheiro Luis Carlos Berrini 1376,32º andar São Paulo, SP 04571-936 Brazil");
            data.Add("US8808901081", "26 Boulevard Royal 4th Floor Luxembourg City 2449 Luxembourg");
            data.Add("FR0000120271", "2, place Jean Millier La DEfense 6 Courbevoie 92078 France");
            data.Add("CH0244767585", "Bahnhofstrasse 45 P.O. Box Zurich 8001 Switzerland");
            data.Add("US81369Y8865", "ETF");
            data.Add("US91912E1055", "Praia de Botafogo 186 Salas 501 a 1901 18 andar Botafogo Rio De Janeiro, RJ 22250-145 Brazil");
            data.Add("US9220428745", "ETF");
            data.Add("DE0007664039", "Berliner Ring 2 Wolfsburg 38440 Germany");
            data.Add("CA9628791027", "1021 West Hastings Street Suite 3500 Vancouver, BC V6E 0C3 Canada");
            data.Add("CA98462Y1007", "Royal Bank Plaza Suite 2200 North Tower 200 Bay Street Toronto, ON M5J 2J3 Canada");
            data.Add("CH0011075394", "Mythenquai 2 Zurich 8002 Switzerland");
        }

        public string GetAddress(string isin)
        {
            if (data.TryGetValue(isin, out string result))
            {
                return result;
            }
            Console.WriteLine("The address for " + isin + " is missing! Modify the report in eDavki to add this value manually and contact the developer so that new entries can be added.");
            Console.WriteLine("The data set can be modified quicker if you provide me the the data in this format: \"ISIN, Address\" if its an ETF just write \"ETF\"");
            return "ADDRESS MISSING";
        }
    }
}