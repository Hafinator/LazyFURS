using System;
using System.Globalization;

namespace LazyFURS.Models
{
    public class Conversion
    {
        public DateTime IssuingDate;
        public decimal Rate;

        public Conversion(string date, string rate)
        {
            _ = DateTime.TryParse(date, out IssuingDate);
            _ = decimal.TryParse(rate, NumberStyles.Number, new CultureInfo("en-GB"), out Rate);
        }
    }
}