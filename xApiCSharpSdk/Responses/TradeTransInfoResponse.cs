using System.Text.Json.Serialization;

namespace xApiCSharpSdk.Responses;

public class TradeTransInfoResponse
{
    [JsonPropertyName("order")]
    public int Order { get; set; }
}
