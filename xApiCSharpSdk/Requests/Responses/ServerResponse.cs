using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xApiCSharpSdk.Requests.Responses
{
    public class ServerResponse
    {
        public bool status { get; set; }
    }
    public class ServerResponse<T>
    {
        public T returnData { get; set; }
    }
}
