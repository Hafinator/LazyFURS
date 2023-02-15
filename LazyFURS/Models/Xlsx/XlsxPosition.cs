using System;

namespace LazyFURS.Models.Xlsx
{
    public class XlsxPosition
    {
        public bool IsLong { get; set; }
        public string Type { get; set; }
        public string FullName { get; set; }
        public decimal Units { get; set; }
        public decimal EuroStartValue { get; set; }
        public decimal EuroCloseValue { get; set; }
        public decimal EuroOpenPrice { get; set; }
        public decimal EuroClosePrice { get; set; }
        public decimal EuroProfit { get; set; }
        public decimal OpenRate { get; set; }
        public decimal CloseRate { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime CloseDate { get; set; }
        public int Leverage { get; set; }
        public string ISIN { get; set; }
    }
}