using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xApiCSharpSdk.Requests.Responses
{
    public class ServerResponse
    {
        public bool? IsSuccess { get; set; }
        public string? response { get; set; }
    }
    public class ServerResponse<T> : ServerResponse
    {
        public T? returnData { get; set; }
    }
}
