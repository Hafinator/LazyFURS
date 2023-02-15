using System;

namespace LazyFURS.Models.Xlsx
{
    public class XlsxDividend
    {
        public string ISIN { get; set; }
        public DateTime PaymentDate { get; set; }
        public string FullName { get; set; }
        public decimal EuroNetDividend { get; set; }
        public decimal EuroForeignTax { get; set; }
    }
}