using System;
using System.Collections.Generic;
using System.Text;

namespace PMCommonApiModels.ResponseModels
{
    public class LatestPriceOutput
    {
        public string symbol { get; set; }
        public double price { get; set; }
        public DateTime timestamp { get; set; }
        public string source { get; set; }
    }
}
