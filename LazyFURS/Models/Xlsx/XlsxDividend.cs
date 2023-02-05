using System;

namespace LazyFURS.Models.Xlsx
{
    public class XlsxDividend
    {
        public string ISIN { get; set; }
        public DateTime PaymentDate { get; set; }
        public string FullName { get; set; }
        public decimal EURDividend { get; set; }
        public decimal EURForeignTax { get; set; }
    }
}