using System;
using System.Collections.Generic;

namespace LazyFURS
{
    internal class IsinToCountry
    {
        private readonly Dictionary<string, string> data = new();

        public IsinToCountry()
        {
            data.Add("CH0012221716", "CH");
            data.Add("US0028241000", "US");
            data.Add("LU0584671464", "LU");
            data.Add("DE000A1EWWW0", "DE");
            data.Add("FR0000120073", "FR");
            data.Add("NL0000235190", "NL");
            data.Add("US00162Q4525", "US");
            data.Add("DE0008404005", "DE");
            data.Add("US02364W1053", "MX");
            data.Add("BE0974293251", "BE");
            data.Add("US0378331005", "US");
            data.Add("NL0010273215", "NL");
            data.Add("GB0009895292", "GB");
            data.Add("FR0000120628", "FR");
            data.Add("US0594603039", "BR");
            data.Add("US05967A1079", "BR");
            data.Add("US05964H1059", "ES");
            data.Add("DE000BASF111", "DE");
            data.Add("DE000BAY0017", "DE");
            data.Add("US0758871091", "US");
            data.Add("FR0000131104", "FR");
            data.Add("GB0007980591", "GB");
            data.Add("US4642864007", "US");
            data.Add("US15234Q2075", "BR");
            data.Add("CH0044328745", "CH");
            data.Add("US20441A1025", "BR");
            data.Add("US20440W1053", "BR");
            data.Add("CH0210483332", "CH");
            data.Add("US2044096012", "BR");
            data.Add("BMG2519Y1084", "PE");
            data.Add("DE0005552004", "DE");
            data.Add("DE0005557508", "DE");
            data.Add("US5324571083", "US");
            data.Add("US81369Y5069", "US");
            data.Add("PR3186727065", "US");
            data.Add("US3444191064", "MX");
            data.Add("US3737371050", "BR");
            data.Add("ES0144580Y14", "ES");
            data.Add("ES0148396007", "ES");
            data.Add("DE0006231004", "DE");
            data.Add("NL0011821202", "NL");
            data.Add("US4581401001", "US");
            data.Add("US46434V6213", "US");
            data.Add("US46434V7385", "US");
            data.Add("US4642866085", "US");
            data.Add("US4642868065", "US");
            data.Add("US46434G8226", "US");
            data.Add("US4642868222", "US");
            data.Add("US4642868149", "US");
            data.Add("US4642867497", "US");
            data.Add("US46434G7723", "US");
            data.Add("US4655621062", "BR");
            data.Add("US4781601046", "US");
            data.Add("FR0000121485", "FR");
            data.Add("ES0157097017", "ES");
            data.Add("IE00BZ12WP82", "GB");
            data.Add("FR0000121014", "FR");
            data.Add("IE00BTN1Y115", "IE");
            data.Add("DE0007100000", "DE");
            data.Add("US58933Y1055", "US");
            data.Add("US5949181045", "US");
            data.Add("CH0038863350", "CH");
            data.Add("US66987V1098", "CH");
            data.Add("US6701002056", "DK");
            data.Add("US67066G1040", "US");
            data.Add("NL0009538784", "NL");
            data.Add("US71654V1017", "BR");
            data.Add("PR7331747001", "US");
            data.Add("US7475251036", "US");
            data.Add("CH0012032048", "CH");
            data.Add("FR0000120578", "FR");
            data.Add("DE0007164600", "DE");
            data.Add("FR0000121972", "FR");
            data.Add("US8085247976", "US");
            data.Add("GB00BP6MXD84", "GB");
            data.Add("DE0007236101", "DE");
            data.Add("US8336351056", "CL");
            data.Add("US84265V1052", "US");
            data.Add("US78464A6982", "US");
            data.Add("NL00150001Q9", "NL");
            data.Add("US86959K1051", "BR");
            data.Add("US87936R2058", "BR");
            data.Add("US8808901081", "LU");
            data.Add("FR0000120271", "FR");
            data.Add("CH0244767585", "CH");
            data.Add("US81369Y8865", "US");
            data.Add("US91912E1055", "BR");
            data.Add("US9220428745", "US");
            data.Add("DE0007664039", "DE");
            data.Add("CA9628791027", "CA");
            data.Add("CA98462Y1007", "CA");
            data.Add("CH0011075394", "CH");
            data.Add("CH1169360919", "CH");
            data.Add("US02319V1035", "US");
            data.Add("US02390A1016", "US");
            data.Add("USN070592100", "US");
            data.Add("ES0113900J37", "ES");
            data.Add("DE0005190003", "DE");
            data.Add("US1101221083", "US");
            data.Add("PAP310761054", "US");
            data.Add("US25490K5965", "US");
            data.Add("GB00BN7SWP63", "GB");
            data.Add("US38045R2067", "US");
            data.Add("US40049J2069", "US");
            data.Add("US46429B5984", "US");
            data.Add("CH0013841017", "CH");
            data.Add("DE0008430026", "DE");
            data.Add("US63884N1081", "US");
            data.Add("FI0009000681", "FI");
            data.Add("US7134481081", "US");
            data.Add("ES0173516115", "ES");
            data.Add("DE0007037129", "DE");
            data.Add("CH0418792922", "CH");
            data.Add("US8552441094", "US");
            data.Add("NL0000226223", "FR");
            data.Add("GB0001383545", "GB");
            data.Add("US9229085538", "US");
            data.Add("FR0000125486", "FR");
            data.Add("KYG982391099", "US");
            data.Add("KYG6683N1034", "US");
            data.Add("US58733R1023", "US");
            data.Add("KYG290181018", "US");
            data.Add("US82575P1075", "ZA");
            data.Add("US70450Y1038", "US");
            data.Add("US88160R1014", "US");
            data.Add("US0090661010", "US");
            data.Add("US30303M1027", "US");
            data.Add("US0231351067", "US");
            data.Add("US00724F1012", "US");
            data.Add("US19260Q1076", "US");
            data.Add("US64110L1061", "US");
            data.Add("US0079031078", "US");
            data.Add("US02079K1079", "US");
            data.Add("US60770K1079", "US");
            data.Add("NL0012969182", "NL");
            data.Add("US1512908898", "MX");
            data.Add("US10552T1079", "BR");
            data.Add("US29082A1079", "BR");
            data.Add("KYG687071012", "BR");
            data.Add("LU0974299876", "LU");
            data.Add("US05501U1060", "BR");
            data.Add("IE000S9YS762", "UK");
            data.Add("US88688T1007", "CA");
            data.Add("US62914V1061", "CN");
            data.Add("US98422D1054", "CN");
            data.Add("US5494981039", "US");
            data.Add("US76954A1034", "US");
            data.Add("US50202M1027", "CN");
            data.Add("US45674M1018", "US");
            data.Add("US5253271028", "US");
            data.Add("US31620M1062", "US");
            data.Add("US44980X1090", "US");
        }

        public string GetCountry(string isin, string name)
        {
            if (data.TryGetValue(isin, out string result))
            {
                return result;
            }
            Console.WriteLine("The country for " + (isin ?? name) + " is missing! Modify the report in eDavki to add this value manually and contact the developer so that new entries can be added.");
            Console.WriteLine("The data set can be modified quicker if you provide me the data in this format: \"ISIN, ISO 3166-1 alpha-2\"");
            return "COUNTRY MISSING";
        }
    }
}