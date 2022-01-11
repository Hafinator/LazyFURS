using System;
using System.Globalization;

namespace LazyFURS.Models
{
    //"EXR.D.USD.EUR.SP00.A,D,USD,EUR,SP00,A,1999-01-06,1.1743,A,,,,P1D,,A,,,,,,,,,,4,,DE2,,US dollar/Euro,\"ECB reference exchange rate, US dollar/Euro, 2:15 pm (C.E.T.)\",USD,0\r"
    public class Conversion
    {
        public Conversion(string date, string rate)
        {
            IssuingDate = DateTime.Parse(date);
            Rate = decimal.Parse(rate, NumberStyles.Number, new CultureInfo("en-GB"));
        }

        public DateTime IssuingDate { get; private set; }
        public decimal Rate { get; private set; }
    }
}