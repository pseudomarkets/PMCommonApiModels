using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PMCommonApiModels.ResponseModels
{
    public class TwelveData
    {
        public partial class TwelveDataIndices
        {
            [JsonProperty("SPX")]
            public TwelveDataTimeSeries Spx { get; set; }

            [JsonProperty("IXIC")]
            public TwelveDataTimeSeries Ixic { get; set; }

            [JsonProperty("DJI")]
            public TwelveDataTimeSeries Dow { get; set; }
        }

        public partial class TwelveDataTimeSeries
        {
            [JsonProperty("meta")]
            public Meta Meta { get; set; }

            [JsonProperty("values")]
            public Value[] Values { get; set; }

            [JsonProperty("status")]
            public string Status { get; set; }
        }

        public partial class Meta
        {
            [JsonProperty("symbol")]
            public string Symbol { get; set; }

            [JsonProperty("interval")]
            public string Interval { get; set; }

            [JsonProperty("currency")]
            public string Currency { get; set; }

            [JsonProperty("exchange_timezone")]
            public string ExchangeTimezone { get; set; }

            [JsonProperty("exchange")]
            public string Exchange { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }
        }

        public partial class Value
        {
            [JsonProperty("datetime")]
            public DateTimeOffset Datetime { get; set; }

            [JsonProperty("open")]
            public string Open { get; set; }

            [JsonProperty("high")]
            public string High { get; set; }

            [JsonProperty("low")]
            public string Low { get; set; }

            [JsonProperty("close")]
            public string Close { get; set; }

            [JsonProperty("volume")]
            public long Volume { get; set; }
        }
    }
}
