using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xApiCSharpSdk.IApiHandlers;
using xApiCSharpSdk.Models;
using xApiCSharpSdk.Responses;

namespace xApiCSharpSdk.ApiHandlers
{
    public class ServerActionsManager
    {
        public async Task<ServerResponse> PingServer(string streamSessionId)
        {
            var serverHandler = RestService.For<IServerActionsHandler>("https://xapi.xtb.com");
            try
            {
                var result = await serverHandler.PingServer(new ApiRequest() { Command = "ping", StreamSessionId = streamSessionId });
                return new ServerResponse()
                {
                    IsSuccess = true
                };

            }
            catch (Exception ex)
            {
                return new ServerResponse()
                {
                    IsSuccess = false
                };
            }
        }
    }
}
