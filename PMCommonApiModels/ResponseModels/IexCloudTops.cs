using System;
using System.Collections.Generic;
using System.Text;

namespace PMCommonApiModels.ResponseModels
{
    public class IexCloudTops
    {
        public string symbol { get; set; }
        public double marketPercent { get; set; }
        public int bidSize { get; set; }
        public double bidPrice { get; set; }
        public int askSize { get; set; }
        public double askPrice { get; set; }
        public int volume { get; set; }
        public double lastSalePrice { get; set; }
        public int lastSaleSize { get; set; }
        public object lastSaleTime { get; set; }
        public long lastUpdated { get; set; }
        public string sector { get; set; }
        public string securityType { get; set; }
    }
}
