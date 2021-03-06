using System;

namespace LazyFURS.Models.Xlsx
{
    public class XlsxPosition
    {
        public bool IsLong { get; set; }
        public string Type { get; set; }
        public string FullName { get; set; }
        public decimal Units { get; set; }
        public decimal EURStartValue { get; set; }
        public decimal EURCloseValue { get; set; }
        public decimal EUROpenPrice { get; set; }
        public decimal EURClosePrice { get; set; }
        public decimal EURProfit { get; set; }
        public decimal OpenRate { get; set; }
        public decimal CloseRate { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime CloseDate { get; set; }
        public int Leverage { get; set; }
        public string ISIN { get; set; }
    }
}