using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace xApiCSharpSdk.Responses
{
    public class UserInfoResponse
    {
        [JsonPropertyName("companyUnit")]
        public double CompanyUnit { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("group")]
        public string Group { get; set; }

        [JsonPropertyName("ibAccount")]
        public bool IbAccount { get; set; }

        [JsonPropertyName("leverage")]
        public double Leverage { get; set; }

        [JsonPropertyName("leverageMultiplier")]
        public float LeverageMultiplier { get; set; }

        [JsonPropertyName("spreadType")]
        public string? SpreadType { get; set; }

        [JsonPropertyName("trailingStop")]
        public bool TrailingStop { get; set; }
    }
}
