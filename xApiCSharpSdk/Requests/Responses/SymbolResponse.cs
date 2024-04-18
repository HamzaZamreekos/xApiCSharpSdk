using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xApiCSharpSdk.Requests.Responses
{
    public class SymbolResponse
    {
        public float ask { get; set; }
        public float bid{ get; set; }
        public string category{ get; set; }
        public double contractSize{ get; set; }
        public string currency{ get; set; }
        public bool currencyPair{ get; set; }
        public string currencyProfit{ get; set; }
        public string description { get; set; }
        public DateTime? expiration { get; set; }
        public string groupName { get; set; }
        public float high { get; set; }
        public double initialMargin { get; set; }
        public double instantMaxVolume { get; set; }
        public float leverage { get; set; }
        public bool longOnly { get; set; }
        public float lotMax { get; set; }
        public float lotMin { get; set; }
        public float lotStep { get; set; }
        public float low { get; set; }
        public double marginHedged { get; set; }
        public bool marginHedgedStrong { get; set; }
        public double? marginMaintenance { get; set; }
        public double marginMode { get; set; }
        public float percentage { get; set; }
        public double pipsPrecision { get; set; }
        public double precision { get; set; }
        public double profitMode { get; set; }
        public double quoteId { get; set; }
        public bool shortSelling { get; set; }
        public float spreadRaw { get; set; }
        public double spreadTable { get; set; }
        public DateTime? starting { get; set; }
        public double stepRuleId { get; set; }
        public double stopsLevel { get; set; }
        public double swap_rollover3days { get; set; }
        public bool swapEnable { get; set; }
        public float swapLong { get; set; }
        public float swapShort { get; set; }
        public double swapType { get; set; }
        public string symbol { get; set; }
        public float tickSize { get; set; }
        public float tickValue { get; set; }
        public DateTime time { get; set; }
        public string timeString { get; set; }
        public bool trailingEnabled { get; set; }
        public double type { get; set; }
    }
}
