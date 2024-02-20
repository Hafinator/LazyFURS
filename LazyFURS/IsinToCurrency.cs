using System;
using System.Collections.Generic;

namespace LazyFURS
{
    internal class IsinToCurrency
    {
        private readonly Dictionary<string, CurrencyType> data = new();

        public IsinToCurrency()
        {
            data.Add("CH0012221716", CurrencyType.CHF);
            data.Add("US0028241000", CurrencyType.USD);
            data.Add("LU0584671464", CurrencyType.USD);
            data.Add("DE000A1EWWW0", CurrencyType.USD);
            data.Add("FR0000120073", CurrencyType.EUR);
            data.Add("NL0000235190", CurrencyType.EUR);
            data.Add("US00162Q4525", CurrencyType.USD);
            data.Add("DE0008404005", CurrencyType.EUR);
            data.Add("US02364W1053", CurrencyType.USD);
            data.Add("BE0974293251", CurrencyType.EUR);
            data.Add("US0378331005", CurrencyType.USD);
            data.Add("NL0010273215", CurrencyType.USD);
            data.Add("GB0009895292", CurrencyType.GBX);
            data.Add("FR0000120628", CurrencyType.EUR);
            data.Add("US0594603039", CurrencyType.USD);
            data.Add("US05967A1079", CurrencyType.USD);
            data.Add("US05964H1059", CurrencyType.USD);
            data.Add("DE000BASF111", CurrencyType.EUR);
            data.Add("DE000BAY0017", CurrencyType.EUR);
            data.Add("US0758871091", CurrencyType.USD);
            data.Add("FR0000131104", CurrencyType.EUR);
            data.Add("GB0007980591", CurrencyType.GBX);
            data.Add("US4642864007", CurrencyType.USD);
            data.Add("US15234Q2075", CurrencyType.USD);
            data.Add("CH0044328745", CurrencyType.USD);
            data.Add("US20441A1025", CurrencyType.USD);
            data.Add("US20440W1053", CurrencyType.USD);
            data.Add("CH0210483332", CurrencyType.CHF);
            data.Add("US2044096012", CurrencyType.USD);
            data.Add("BMG2519Y1084", CurrencyType.USD);
            data.Add("DE0005552004", CurrencyType.EUR);
            data.Add("DE0005557508", CurrencyType.EUR);
            data.Add("US5324571083", CurrencyType.USD);
            data.Add("US81369Y5069", CurrencyType.USD);
            data.Add("PR3186727065", CurrencyType.USD);
            data.Add("US3444191064", CurrencyType.USD);
            data.Add("US3737371050", CurrencyType.USD);
            data.Add("ES0144580Y14", CurrencyType.EUR);
            data.Add("ES0148396007", CurrencyType.EUR);
            data.Add("DE0006231004", CurrencyType.EUR);
            data.Add("NL0011821202", CurrencyType.EUR);
            data.Add("US4581401001", CurrencyType.USD);
            data.Add("US46434V6213", CurrencyType.USD);
            data.Add("US46434V7385", CurrencyType.USD);
            data.Add("US4642866085", CurrencyType.USD);
            data.Add("US4642868065", CurrencyType.USD);
            data.Add("US46434G8226", CurrencyType.USD);
            data.Add("US4642868222", CurrencyType.USD);
            data.Add("US4642868149", CurrencyType.USD);
            data.Add("US4642867497", CurrencyType.USD);
            data.Add("US46434G7723", CurrencyType.USD);
            data.Add("US4655621062", CurrencyType.USD);
            data.Add("US4781601046", CurrencyType.USD);
            data.Add("FR0000121485", CurrencyType.EUR);
            data.Add("ES0157097017", CurrencyType.EUR);
            data.Add("IE00BZ12WP82", CurrencyType.EUR);
            data.Add("FR0000121014", CurrencyType.EUR);
            data.Add("IE00BTN1Y115", CurrencyType.USD);
            data.Add("DE0007100000", CurrencyType.EUR);
            data.Add("US58933Y1055", CurrencyType.USD);
            data.Add("US5949181045", CurrencyType.USD);
            data.Add("CH0038863350", CurrencyType.CHF);
            data.Add("US66987V1098", CurrencyType.USD);
            data.Add("US6701002056", CurrencyType.USD);
            data.Add("US67066G1040", CurrencyType.USD);
            data.Add("NL0009538784", CurrencyType.USD);
            data.Add("US71654V1017", CurrencyType.USD);
            data.Add("PR7331747001", CurrencyType.USD);
            data.Add("US7475251036", CurrencyType.USD);
            data.Add("CH0012032048", CurrencyType.CHF);
            data.Add("FR0000120578", CurrencyType.EUR);
            data.Add("DE0007164600", CurrencyType.EUR);
            data.Add("FR0000121972", CurrencyType.EUR);
            data.Add("US8085247976", CurrencyType.USD);
            data.Add("GB00BP6MXD84", CurrencyType.GBX);
            data.Add("DE0007236101", CurrencyType.EUR);
            data.Add("US8336351056", CurrencyType.USD);
            data.Add("US84265V1052", CurrencyType.USD);
            data.Add("US78464A6982", CurrencyType.USD);
            data.Add("NL00150001Q9", CurrencyType.USD);
            data.Add("US86959K1051", CurrencyType.USD);
            data.Add("US87936R2058", CurrencyType.USD);
            data.Add("US8808901081", CurrencyType.USD);
            data.Add("FR0000120271", CurrencyType.EUR);
            data.Add("CH0244767585", CurrencyType.CHF);
            data.Add("US81369Y8865", CurrencyType.USD);
            data.Add("US91912E1055", CurrencyType.USD);
            data.Add("US9220428745", CurrencyType.USD);
            data.Add("DE0007664039", CurrencyType.EUR);
            data.Add("CA9628791027", CurrencyType.USD);
            data.Add("CA98462Y1007", CurrencyType.USD); // Inactive
            data.Add("CH0011075394", CurrencyType.CHF);
            data.Add("CH1169360919", CurrencyType.CHF);
            data.Add("US02319V1035", CurrencyType.USD);
            data.Add("US02390A1016", CurrencyType.USD);
            data.Add("USN070592100", CurrencyType.USD);
            data.Add("ES0113900J37", CurrencyType.EUR);
            data.Add("DE0005190003", CurrencyType.EUR);
            data.Add("US1101221083", CurrencyType.USD);
            data.Add("PAP310761054", CurrencyType.USD);
            data.Add("US25490K5965", CurrencyType.USD);
            data.Add("GB00BN7SWP63", CurrencyType.GBX);
            data.Add("US38045R2067", CurrencyType.USD);
            data.Add("US40049J2069", CurrencyType.USD);
            data.Add("US46429B5984", CurrencyType.USD);
            data.Add("CH0013841017", CurrencyType.CHF);
            data.Add("DE0008430026", CurrencyType.EUR);
            data.Add("US63884N1081", CurrencyType.USD);
            data.Add("FI0009000681", CurrencyType.EUR);
            data.Add("US7134481081", CurrencyType.USD);
            data.Add("ES0173516115", CurrencyType.EUR);
            data.Add("DE0007037129", CurrencyType.EUR);
            data.Add("CH0418792922", CurrencyType.CHF);
            data.Add("US8552441094", CurrencyType.USD);
            data.Add("NL0000226223", CurrencyType.EUR);
            data.Add("GB0001383545", CurrencyType.GBP);
            data.Add("US9229085538", CurrencyType.USD);
            data.Add("FR0000125486", CurrencyType.EUR);
            data.Add("KYG982391099", CurrencyType.USD);
            data.Add("KYG851581069", CurrencyType.USD);
            data.Add("KYG6683N1034", CurrencyType.USD);
            data.Add("US58733R1023", CurrencyType.USD);
            data.Add("KYG290181018", CurrencyType.USD);
        }

        public CurrencyType GetCurrency(string isin)
        {
            if (isin != null && data.TryGetValue(isin, out CurrencyType result))
            {
                return result;
            }
            Console.WriteLine("The currency for " + isin + " is missing or the item might be crypto! Modify the report in eDavki to add this value manually and contact the developer so that new entries can be added.");
            Console.WriteLine("Falling back to USD");
            return CurrencyType.USD;
        }
    }
}