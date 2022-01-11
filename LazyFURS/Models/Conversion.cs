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
            if (!DateTime.TryParse(date, out IssuingDate))
            {
                Console.WriteLine("Conversion not complete, date provided: " + date + " rate provided: " + rate);
            }
            if (!decimal.TryParse(rate, NumberStyles.Number, new CultureInfo("en-GB"), out Rate))
            {
                Console.WriteLine("Conversion not complete, date provided: " + date + " rate provided: " + rate);
            }
        }
    }
}