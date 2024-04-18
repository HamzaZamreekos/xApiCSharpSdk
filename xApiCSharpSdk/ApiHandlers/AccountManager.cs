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
        public async Task<ServerResponse<string>> Login(string userId, string password)
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
                    return new ServerResponse<string>()
                    {
                        IsSuccess = true,
                        returnData = loginResponse.streamSessionId,
                    };
                else
                    return new ServerResponse<string>()
                    {
                        IsSuccess = false,
                    };
            }
            catch(Exception ex)
            {
                return new ServerResponse<string>()
                {
                    IsSuccess = false,
                };
            }
        }
        public async Task<ServerResponse> Logout()
        {
            try
            {
                var AccountHandler = RestService.For<IAccountHandler>("https://xapi.xtb.com:5124");
                var result = await AccountHandler.Logout(new ApiRequest() { command= "logout"});
                return new ServerResponse()
                {
                    IsSuccess = true,
                    response = result
                };
            }
            catch(Exception ex)
            {
                return new ServerResponse()
                {
                    IsSuccess = false,
                };
            }
        }
        public async Task<ServerResponse<UserInfoResponse>> GetUserData()
        {
            try
            {
                var AccountHandler = RestService.For<IAccountHandler>("https://xapi.xtb.com");
                var result = await AccountHandler.GetUserInfo(new ApiRequest() { command = "getCurrentUserData" });
                return new ServerResponse<UserInfoResponse>()
                {
                    IsSuccess = true,
                    returnData = result
                };
            }
            catch (Exception ex)
            {
                return new ServerResponse<UserInfoResponse>()
                {
                    IsSuccess = false
                };
            }
        }
    }
}
