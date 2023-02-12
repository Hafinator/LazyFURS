using System;
using System.Collections.Generic;

namespace LazyFURS
{
    internal class CountryToTaxReduction
    {
        private readonly Dictionary<string, string> data = new();

        public CountryToTaxReduction()
        {
            // The data source can be found here: https://www.fu.gov.si/fileadmin/Internet/Davki_in_druge_dajatve/Podrocja/Mednarodno_obdavcenje/Zakonodaja/Seznam_veljavnih_MP.docx
            data.Add("CH", string.Empty); // need to own 20% of a company to be exempt / have it reduced
            data.Add("US", "10. člen, odstavek 2b");
            data.Add("LU", "10. člen, odstavek 2b");
            data.Add("DE", "10. člen, odstavek 2b");
            data.Add("FR", string.Empty); // need to own 20% of a company to be exempt / have it reduced
            data.Add("NL", "10. člen, odstavek 2b");
            data.Add("MX", string.Empty);
            data.Add("BE", "10. člen, odstavek 2b");
            data.Add("GB", string.Empty); // need to own 20% of a company to be exempt / have it reduced
            data.Add("BR", string.Empty); // No contract between countries
            data.Add("ES", "10. člen, odstavek 2b");
            data.Add("PE", string.Empty); // No contract between countries
            data.Add("IE", "10. člen, odstavek 2b");
            data.Add("DK", "10. člen, odstavek 2d");
            data.Add("CL", string.Empty); // No contract between countries
            data.Add("CA", "10. člen, odstavek 2d"); // No contract between countries
        }

        public string GetDoubleTaxationExemption(string Iso2)
        {
            if (data.TryGetValue(Iso2, out string result))
            {
                return result;
            }
            Console.WriteLine("The Tax Exemption for the country with ISO code: \"" + Iso2 + "\" is missing! Modify the report in eDavki to add this value manually and contact the developer so that new entries can be added.");
            return "EXEMPTION CLAUSE MISSING";
        }
    }
}