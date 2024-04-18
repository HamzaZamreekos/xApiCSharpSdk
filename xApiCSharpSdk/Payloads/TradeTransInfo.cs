using System.Text.Json.Serialization;
using xApiCSharpSdk.Enums;

namespace xApiCSharpSdk.Payloads;

public class TradeTransInfo
{
    [JsonPropertyName("cmd")]
    public Cmd Command { get; set; }

    [JsonPropertyName("customComment")]
    public string? CustomComment { get; set; }

    [JsonPropertyName("expiration")]
    public long Expiration { get; set; }

    [JsonPropertyName("offset")]
    public int Offset { get; set; }

    [JsonPropertyName("order")]
    public int Order { get; set; }

    [JsonPropertyName("price")]
    public decimal Price { get; set; }

    [JsonPropertyName("sl")]
    public double Sl { get; set; }

    [JsonPropertyName("symbol")]
    public string Symbol { get; set; }

    [JsonPropertyName("tp")]
    public double Tp { get; set; }

    [JsonPropertyName("type")]
    public OrderType Type { get; set; }

    [JsonPropertyName("volume")]
    public double Volume { get; set; }
}