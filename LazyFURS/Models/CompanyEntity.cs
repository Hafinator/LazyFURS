namespace LazyFURS.Models
{
    internal struct CompanyEntity
    {
        public string ISIN { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public CurrencyType Currency { get; set; }
        public string TaxReductionText { get; set; }
    }
}