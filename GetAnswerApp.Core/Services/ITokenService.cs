using System.Security.Claims;

namespace GetAnswerApp.Core.Services
{
    public interface ITokenService
    {
        public string GenerateToken(List<Claim> claims);
        public string VerifyToken(string token);
    }
}
