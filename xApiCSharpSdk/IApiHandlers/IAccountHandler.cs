using Refit;
using xApiCSharpSdk.Models;
using xApiCSharpSdk.Models.Responses;
using xApiCSharpSdk.Requests.Responses;

namespace xApiCSharpSdk.IApiHandlers
{
    public interface IAccountHandler
    {
        [Post("/login")]
        Task<LoginResponse> LoginUser(ApiRequest<User> loginRequest);
        [Post("/logout")]
        Task<string> Logout(ApiRequest logoutRequest);
        [Post("/logout")]
        Task<UserInfoResponse> GetUserInfo(ApiRequest infoRequest);
    }
}
