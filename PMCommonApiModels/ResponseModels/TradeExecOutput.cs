using System;
using System.Collections.Generic;
using System.Text;
using PMUnifiedAPI.Models;

namespace PMCommonApiModels.ResponseModels
{
    public class TradeExecOutput
    {
        public string Status { get; set; }
        public Orders Order { get; set; }
    }
}
