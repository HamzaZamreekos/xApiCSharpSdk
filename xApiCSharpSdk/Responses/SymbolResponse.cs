using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace xApiCSharpSdk.Responses
{
    public class SymbolResponse
    {
        [JsonPropertyName("ask")]
        public float Ask { get; set; }

        [JsonPropertyName("bid")]
        public float Bid { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("contractSize")]
        public double ContractSize { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("currencyPair")]
        public bool CurrencyPair { get; set; }

        [JsonPropertyName("currencyProfit")]
        public string CurrencyProfit { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("expiration")]
        public DateTime? Expiration { get; set; }

        [JsonPropertyName("groupName")]
        public string GroupName { get; set; }

        [JsonPropertyName("high")]
        public float High { get; set; }

        [JsonPropertyName("initialMargin")]
        public double InitialMargin { get; set; }

        [JsonPropertyName("instantMaxVolume")]
        public double InstantMaxVolume { get; set; }

        [JsonPropertyName("leverage")]
        public float Leverage { get; set; }

        [JsonPropertyName("longOnly")]
        public bool LongOnly { get; set; }

        [JsonPropertyName("lotMax")]
        public float LotMax { get; set; }

        [JsonPropertyName("lotMin")]
        public float LotMin { get; set; }

        [JsonPropertyName("lotStep")]
        public float LotStep { get; set; }

        [JsonPropertyName("low")]
        public float Low { get; set; }

        [JsonPropertyName("marginHedged")]
        public double MarginHedged { get; set; }

        [JsonPropertyName("marginHedgedStrong")]
        public bool MarginHedgedStrong { get; set; }

        [JsonPropertyName("marginMaintenance")]
        public double? MarginMaintenance { get; set; }

        [JsonPropertyName("marginMode")]
        public double MarginMode { get; set; }

        [JsonPropertyName("percentage")]
        public float Percentage { get; set; }

        [JsonPropertyName("pipsPrecision")]
        public double PipsPrecision { get; set; }

        [JsonPropertyName("precision")]
        public double Precision { get; set; }

        [JsonPropertyName("profitMode")]
        public double ProfitMode { get; set; }

        [JsonPropertyName("quoteId")]
        public double QuoteId { get; set; }

        [JsonPropertyName("shortSelling")]
        public bool ShortSelling { get; set; }

        [JsonPropertyName("spreadRaw")]
        public float SpreadRaw { get; set; }

        [JsonPropertyName("spreadTable")]
        public double SpreadTable { get; set; }

        [JsonPropertyName("starting")]
        public DateTime? Starting { get; set; }

        [JsonPropertyName("stepRuleId")]
        public double StepRuleId { get; set; }

        [JsonPropertyName("stopsLevel")]
        public double StopsLevel { get; set; }

        [JsonPropertyName("swap_rollover3days")]
        public double SwapRollover3Days { get; set; }

        [JsonPropertyName("swapEnable")]
        public bool SwapEnable { get; set; }

        [JsonPropertyName("swapLong")]
        public float SwapLong { get; set; }

        [JsonPropertyName("swapShort")]
        public float SwapShort { get; set; }

        [JsonPropertyName("swapType")]
        public double SwapType { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("tickSize")]
        public float TickSize { get; set; }

        [JsonPropertyName("tickValue")]
        public float TickValue { get; set; }

        [JsonPropertyName("time")]
        public DateTime Time { get; set; }

        [JsonPropertyName("timeString")]
        public string TimeString { get; set; }

        [JsonPropertyName("trailingEnabled")]
        public bool TrailingEnabled { get; set; }

        [JsonPropertyName("type")]
        public double Type { get; set; }
    }

}
