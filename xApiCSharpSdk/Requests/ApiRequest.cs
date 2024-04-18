using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace xApiCSharpSdk.Models
{
    public class ApiRequest
    {
        [JsonPropertyName("command")]
        public string Command { get; set; }
        [JsonPropertyName("streamSessionId")]
        public string? StreamSessionId { get; set; }
    }
    public class ApiRequest<T> : ApiRequest
    {
        [JsonPropertyName("arguments")]
        public T Arguments { get; set; }
    }
}
//	"streamSessionId": "8469308861804289383"