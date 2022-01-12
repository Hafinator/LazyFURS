using System;

namespace LazyFURS.Models
{
    public class Dividend
    {
        public long PositionId { get; set; }
        public string ISIN { get; set; }
        public DateTime PaymentDate { get; set; }
        public string FullName { get; set; }
        public decimal EURNetDividend { get; set; }
        public decimal EURForeignTax { get; set; }
    }
}