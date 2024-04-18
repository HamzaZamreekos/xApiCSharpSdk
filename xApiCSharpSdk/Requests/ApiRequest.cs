using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xApiCSharpSdk.Models
{
    public class ApiRequest
    {
        public string command { get; set; }
    }
    public class ApiRequest<T> : ApiRequest
    {
        public T arguments { get; set; }
    }
}
