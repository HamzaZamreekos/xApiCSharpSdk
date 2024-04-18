using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace xApiCSharpSdk.Responses
{
    public class ServerResponse
    {
        [JsonPropertyName("isSuccess")]
        public bool? IsSuccess { get; set; }
        [JsonPropertyName("response")]
        public string? Response { get; set; }
    }
    public class ServerResponse<T> : ServerResponse
    {
        [JsonPropertyName("returnData")]
        public T? ReturnData { get; set; }
    }
}
