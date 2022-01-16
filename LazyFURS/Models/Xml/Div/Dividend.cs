using System;

namespace LazyFURS.Models.Xml.Div
{
    public class Dividend
    {
        /// <summary>
        /// Datum prejema dividend
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Davčna številka izplačevalca dividend
        /// </summary>
        public string PayerTaxNumber { get; set; }

        /// <summary>
        /// Identifikacijska številka izplačevalca dividend
        /// </summary>
        public string PayerIdentificationNumber { get; set; }

        /// <summary>
        /// Naziv izplačevalca dividend
        /// </summary>
        public string PayerName { get; set; }

        /// <summary>
        /// Naslov izplačevalca dividend
        /// </summary>
        public string PayerAddress { get; set; }

        /// <summary>
        /// Država izplačevalca dividend
        /// </summary>
        public string PayerCountry { get; set; }

        /// <summary>
        /// Vrsta dividende
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Znesek dividend (v EUR)
        /// </summary>
        public decimal Value { get; set; }

        /// <summary>
        /// Tuji davek (v EUR)
        /// </summary>
        public decimal ForeignTax { get; set; }

        /// <summary>
        /// Država vira
        /// </summary>
        public string SourceCountry { get; set; }

        /// <summary>
        /// Uveljavljam oprostitev po mednarodni pogodbi (odstavek, člen)
        /// </summary>
        public string ReliefStatement { get; set; }
    }
}