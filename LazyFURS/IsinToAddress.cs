﻿using System;
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
            data.Add("CH1169360919", "Bruggerstrasse 71a Baden 5400 Switzerland");
            data.Add("US02319V1035", "Rua Dr. Renato Paes de Barros, 1017 3rd Floor São Paulo, SP 04530-001 Brazil");
            data.Add("US02390A1016", "Lago Zurich 245 Plaza Carso / Edificio Telcel, Piso 16 Colonia Ampliación Granada Miguel Hidalgo Mexico City, DF 11529 Mexico");
            data.Add("USN070592100", "De Run 6501 Veldhoven 5504 DR Netherlands");
            data.Add("ES0113900J37", "Santander Group City Av. de Cantabria s/n Boadilla del Monte Madrid 28660 Spain ");
            data.Add("DE0005190003", "Petuelring 130 Munich 80809 Germany");
            data.Add("US1101221083", "Route 206 & Province Line Road Princeton, NY 08543 United States");
            data.Add("PAP310761054", "Boulevard Costa del Este Av. Principal y Av. de la Rotonda UrbanizaciOn Costa del Este Complejo Business Park,Torre Norte, Parq Panama City 0816-06819 Panama");
            data.Add("US25490K5965", "ETF");
            data.Add("GB00BN7SWP63", "980 Great West Road Middlesex Brentford TW8 9GS United Kingdom");
            data.Add("US38045R2067", "Praca Comandante Linneu Gomes, S/N Portaria 3, prEdio 24 Jardim Aeroporto São Paulo, SP 04626-020 Brazil");
            data.Add("US40049J2069", "Av. Vasco de Quiroga 2000 Building A Floor 4,Delegación Álvaro Obregón Col. Santa Fe Mexico City, DF 12210 Mexico");
            data.Add("US46429B5984", "ETF");
            data.Add("CH0013841017", "Muenchensteinerstrasse 38 Basel 4002 Switzerland");
            data.Add("DE0008430026", "Königinstr. 107 Munich 80802 Germany");
            data.Add("US63884N1081", "Avenida Alexandre Colares No. 1188, Sala A17-Bloco A Parque Anhanguera São Paulo, SP 05106-000 Brazil");
            data.Add("FI0009000681", "Karakaari 7 Espoo 02610 Finland");
            data.Add("US7134481081", "700 Anderson Hill Road Purchase, NY 10577 United States");
            data.Add("ES0173516115", "Repsol Campus C/ Mendez Alvaro, 44 Madrid 28045 Spain");
            data.Add("DE0007037129", "Zugerstrasse 50 Baar 6340 Switzerland");
            data.Add("US8552441094", "2401 Utah Avenue South Seattle, WA 98134 United States");
            data.Add("NL0000226223", "39 Chemin du Champ des Filles 1228 Plan-Les-Ouates Geneva Switzerland");
            data.Add("GB0001383545", "ETF");
            data.Add("US9229085538", "ETF");
            data.Add("FR0000125486", "1973 boulevard de la Défense CS 10268 Cedex Nanterre 92757 France");
            data.Add("KYG982391099", "20, Genesis Close George Town Grand Cayman KY-1-1208 Cayman Islands");
            data.Add("CH0418792922", "Zugerstrasse 50 Baar 6340 Switzerland");
            data.Add("KYG851581069", "Harbour Place 4th Floor 103 South Church Street PO Box 10240 George Town KY1-1002 Cayman Islands");
            data.Add("KYG6683N1034", "Rua Capote Valente, 39 São Paulo, SP 5409-0000 Brazil ");
            data.Add("US58733R1023", "WTC Free Zone Dr. Luis Bonavita 1294 Of. 1733 Tower II Montevideo 11300 Uruguay");
            data.Add("KYG290181018", "Dr. Luis Bonavita 1294 Montevideo 11300 Uruguay");
            data.Add("US82575P1075", "Constantia Office Park Cnr 14th Ave & Hendrik Potgieter Rd, 1709, Weltevreden Park, South Africa");
            data.Add("US70450Y1038", "2211 North First Street San Jose, CA 95131 United States");
            data.Add("US88160R1014", "1 Tesla Road Austin, TX 78725 United States");
            data.Add("US0090661010", "888 Brannan Street San Francisco, CA 94103 United States");
            data.Add("US30303M1027", "1 Meta Way Menlo Park, CA 94025 United States");
            data.Add("US0231351067", "410 Terry Avenue North Seattle, WA 98109-5210 United States");
            data.Add("US00724F1012", "345 Park Avenue San Jose, CA 95110-2704 United States");
            data.Add("US19260Q1076", "251 Little Falls Drive Wilmington, DE 19808 United States");
            data.Add("US64110L1061", "121 Albright Way Los Gatos, CA 95032 United States");
            data.Add("US0079031078", "2485 Augustine Drive Santa Clara, CA 95054 United States");
            data.Add("US02079K1079", "1600 Amphitheatre Parkway Mountain View, CA 94043 United States");
            data.Add("US60770K1079", "200 Technology Square Cambridge, MA 02139 United States");
            data.Add("NL0012969182", "Simon Carmiggeltstraat 6-50 Amsterdam, 1011 DJ Netherlands");
            data.Add("US1512908898", "Avenida Ricardo Margáin Zozaya #325 Colonia Valle del Campestre San Pedro Garza García, NL 66265 Mexico");
            data.Add("US10552T1079", "Av. Das NaCOes Unidas 14.401 22nd to 25th Floors Torre JequitibA CondomInio Parque da Cid ChAcara Santo AntOnio São Paulo, SP 04730-090 Brazil");
            data.Add("US29082A1079", "Eldorado Business Tower 30th floor Avenida Dra. Ruth Cardoso, No. 8,501 Pinheiros São Paulo, SP 05425-070 Brazil");
            data.Add("KYG687071012", "Avenida Brigadeiro Faria Lima, 1384 4º andar Parte A São Paulo, SP 01451-001 Brazil");
            data.Add("LU0974299876", "37A Avenue J.F. Kennedy Luxembourg City, 1855 Luxembourg");
            data.Add("US05501U1060", "Av. Marcos Penteado de Ulhôa Rodrigues n. 939, 8th floor Edifício Jatobá CondomÃ­nio Castelo Branco Office Park Tamboré Barueri, SP Brazil");
            data.Add("IE000S9YS762", "Forge, 43 Church Street West Woking, GU21 6HT United Kingdom");
            data.Add("US88688T1007", "265 Talbot Street West Leamington, ON N8H 5L4 Canada");
            data.Add("US62914V1061", "Building 20 No. 56 AnTuo Road Anting Town Jiading District Shanghai, 201804 China");
            data.Add("US98422D1054", "No. 8 Songgang Road Changxing Street Cencun Tianhe District Guangzhou, 510640 China");
            data.Add("US5494981039", "7373 Gateway Boulevard Newark, CA 94560 United States");
            data.Add("US76954A1034", "14600 Myford Road Irvine, CA 92606 United States");
            data.Add("US50202M1027", "11 Wenliang Street Shunyi District Beijing, 101399 China");
            data.Add("US45674M1018", "2100 Seaport Boulevard Redwood City, CA 94063 United States");
            data.Add("US5253271028", "1750 Presidents Street Reston, VA 20190 United States");
            data.Add("US31620M1062", "347 Riverside Avenue Jacksonville, FL 32202 United States");
            data.Add("US44980X1090", "377 Simarano Drive Marlborough, MA 01752 United States");
        }

        public string GetAddress(string isin, string name)
        {
            if (data.TryGetValue(isin, out string result))
            {
                return result;
            }
            Console.WriteLine();
            Console.WriteLine("The address for " + (isin ?? name) + " is missing! Modify the report in eDavki to add this value manually and contact the developer so that new entries can be added.");
            Console.WriteLine("The data set can be modified quicker if you provide me the data in this format: \"ISIN, Address\" if its an ETF just write \"ETF\"");
            return "ADDRESS MISSING";
        }
    }
}