using System;
using System.Collections.Generic;
using System.Text;

namespace PMCommonApiModels.ResponseModels
{
    public class StatusMessages
    {
        public const string UserCreatedMessage = "User created";
        public const string UserExistsMessage = "User already exists";
        public const string ExpiredTokenMessage = "Session has expired, please login again";
        public const string InvalidTokenMessage = "Invalid or unknown token";
        public const string IexTopsSourceMessage = "IEX TOPS";
        public const string TwelveDataSourceMessage = "Twelve Data Real Time Price";
        public const string AlphaVantageSourceMessage = "Alpha Vantage Global Quote";
        public const string FinnHubSourceMessage = "Finnhub Real Time Quote";
        public const string XchangeSourceMessage = "PseudoXchange Real Time Price";
        public const string TwelveDataTimeSeriesMessage = "Twelve Data Time Series";
        public const string InvalidShortPositionMessage =
            "You must sell any long positions before initiating a short for this symbol";
        public const string InvalidOrderTypeMessage = "Invalid order type";
        public const string InvalidSymbolOrQuantityMessage = "Invalid symbol or quantity";
        public const string InvalidPositionsMessage = "No positions to sell for symbol: ";
        public const string InsufficientBalanceMessage = "Insufficient account balance";
        public const string SuccessMessage = "Success";
        public const string FailureMessage = "Failed";
        public const string MarketNotOpenMessage = "Market is closed; all orders will be processed at next market open";
        public const string MarketIsOpenMessage = "Market is open";
        public const string InvalidSymbolXchangeMessage = "Invalid PseudoXchange symbol";
    }
}
