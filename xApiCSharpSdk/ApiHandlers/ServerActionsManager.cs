using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xApiCSharpSdk.IApiHandlers;
using xApiCSharpSdk.Models;
using xApiCSharpSdk.Requests.Responses;

namespace xApiCSharpSdk.ApiHandlers
{
    public class ServerActionsManager
    {
        public async Task<ServerResponse> PingServer()
        {
            var serverHandler = RestService.For<IServerActionsHandler>("https://xapi.xtb.com");
            var result = await serverHandler.PingServer(new ApiRequest() { command = "ping" });
            return result;
        }
    }
}
