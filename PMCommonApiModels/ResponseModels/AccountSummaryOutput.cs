using System;
using System.Collections.Generic;
using System.Text;

namespace PMCommonApiModels.ResponseModels
{
    public class AccountSummaryOutput
    {
        public int AccountId { get; set; }
        public double AccountBalance { get; set; }
        public double TotalInvestedValue { get; set; }
        public double TotalCurrentValue { get; set; }
        public double InvestmentGainOrLoss { get; set; }
        public double InvestmentGainOrLossPercentage { get; set; }
        public int NumberOfPositions { get; set; }
    }
}
