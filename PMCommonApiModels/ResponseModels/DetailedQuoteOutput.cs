using System;
using System.Collections.Generic;
using System.Text;

namespace PMCommonApiModels.ResponseModels
{
    public class DetailedQuoteOutput
    {
        public string symbol { get; set; }
        public string name { get; set; }
        public DateTime timestamp { get; set; }
        public double open { get; set; }
        public double close { get; set; }
        public double high { get; set; }
        public double low { get; set; }
        public long volume { get; set; }
        public double previousClose { get; set; }
        public double change { get; set; }
        public double changePercentage { get; set; }
    }
}
