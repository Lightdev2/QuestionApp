using System.Security.Claims;
using GetAnswerApp.Core.DTOs;
using GetAnswerApp.Core.Services;

namespace GetAnswerApp.BusinessLogic.Services
{
    public class AuthService : IAuthService
    {
        private readonly ITokenService _tokenService;
        public AuthService(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }

        public async Task<SignInResponse> SignIn(LoginRequest loginRequest)
        {
            var claims = new List<Claim>{};
            var result = new SignInResponse
            {
                Token = _tokenService.GenerateToken(claims)
            };
            return result;
        }

        public async Task<int> SignUp(NewUser user)
        {
            return 1;
        }

        private async Task<int> VerifyUser(LoginRequest loginRequest)
        {
            return 1;
        }
    }
}
