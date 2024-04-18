using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace xApiCSharpSdk.Requests
{
    public class User
    {
        [JsonPropertyName("userId")]
        public string UserId { get; set; }
        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}
