using System;
using System.Collections.Generic;
using System.Text;

namespace PMCommonApiModels.ResponseModels
{
    public class IndicesOutput
    {
        public List<StockIndex> indices;
        public string source { get; set; }
        public DateTime timestamp { get; set; }
    }
}
