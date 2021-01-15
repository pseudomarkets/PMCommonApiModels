using System;
using System.Collections.Generic;
using System.Text;
using PMUnifiedAPI.Models;

namespace PMCommonApiModels.ResponseModels
{
    public class TradeExecOutput
    {
        public TradeStatusCodes StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public Orders Order { get; set; }
    }

    public enum TradeStatusCodes : int
    {
        ExecutionOk = 0,
        ExecutionQueued = 1,
        ExecutionError = -1
    }
}
