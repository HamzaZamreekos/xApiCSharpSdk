using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xApiCSharpSdk.IApiHandlers;
using xApiCSharpSdk.Models;
using xApiCSharpSdk.Models.Responses;
using xApiCSharpSdk.Requests.Responses;

namespace xApiCSharpSdk.ApiHandlers
{
    public class AccountManager
    {
        public async Task<string> Login(string userId, string password)
        {
            var AccountHandler = RestService.For<IAccountHandler>("https://xapi.xtb.com:5125");
            User userCredentials = new User()
            {
                userId = userId,
                password = password
            };
            LoginResponse loginResponse;
            try
            {
                loginResponse = await AccountHandler.LoginUser(
                    new ApiRequest<User>()
                    {
                        command = "login",
                        arguments = userCredentials
                    });
                if (!string.IsNullOrEmpty(loginResponse.streamSessionId))
                    return loginResponse.streamSessionId;
                else
                    return string.Empty;
            }
            catch(Exception ex)
            {
                return string.Empty;
            }
        }
        public async Task Logout()
        {
            var AccountHandler = RestService.For<IAccountHandler>("https://xapi.xtb.com:5124");
            await AccountHandler.Logout(new ApiRequest() { command= "logout"});
        }
        public async Task<UserInfoResponse> GetUserData()
        {
            var AccountHandler = RestService.For<IAccountHandler>("https://xapi.xtb.com");
            var result = await AccountHandler.GetUserInfo(new ApiRequest() { command = "getCurrentUserData" });
            return result;
        }
        void test()
        {

        }
    }
}
