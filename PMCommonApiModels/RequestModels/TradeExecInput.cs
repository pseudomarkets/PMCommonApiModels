using System;
using System.Collections.Generic;
using System.Text;

namespace PMCommonApiModels.RequestModels
{
    public class TradeExecInput
    {
        public string Symbol { get; set; }
        public int Quantity { get; set; }
        public string Type { get; set; }
    }
}
