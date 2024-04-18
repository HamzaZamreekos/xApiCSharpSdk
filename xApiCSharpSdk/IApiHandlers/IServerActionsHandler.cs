using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xApiCSharpSdk.Models.Responses;
using xApiCSharpSdk.Models;
using xApiCSharpSdk.Requests.Responses;

namespace xApiCSharpSdk.IApiHandlers
{
    public interface IServerActionsHandler
    {
        [Post("/ping")]
        Task<ServerResponse> PingServer(ApiRequest ping);
    }
}
