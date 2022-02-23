using GetAnswerApp.Core.DTOs;

namespace GetAnswerApp.Core.Services
{
    public interface IAuthService
    {
        Task<int> SignUp(NewUser user);
        Task<SignInResponse> SignIn(LoginRequest loginRequest);
    }
}
