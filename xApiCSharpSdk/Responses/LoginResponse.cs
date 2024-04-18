using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace xApiCSharpSdk.Responses
{
    public class LoginResponse
    {
        [JsonPropertyName("status")]
        public bool Status { get; set; }
        [JsonPropertyName("streamSessionId")]
        public string StreamSessionId { get; set; }
    }
}
