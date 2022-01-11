using System;

namespace LazyFURS.Models
{
    public class Dividend
    {
        public long PositionID { get; set; }
        public string ISIN { get; set; }
        public DateTime PaymentDate { get; set; }
        public string FullName { get; set; }
        public decimal USDNetDividend { get; set; }
        public decimal USDForeignTax { get; set; }
        public decimal EURNetDividend { get; set; }
        public decimal EURForeignTax { get; set; }
        public string ForeignTaxOrignAbbreviation { get; set; }
    }
}