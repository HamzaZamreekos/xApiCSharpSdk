using System.Text.Json.Serialization;

namespace xApiCSharpSdk.Payloads;

public class TradeTransStatus
{
    [JsonPropertyName("order")]
    public int Order { get; set; }
}
