using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using GetAnswerApp.Core.Infrastructure;
using GetAnswerApp.Core.Services;
using Microsoft.IdentityModel.Tokens;

namespace GetAnswerApp.BusinessLogic.Services
{
    public class TokenService : ITokenService
    {
        public string GenerateToken(List<Claim> claims)
        {
            var jwt = new JwtSecurityToken(
                issuer: JwtOptions.Issuer,
                audience: JwtOptions.Audience,
                claims: claims,
                expires: DateTime.UtcNow.Add(TimeSpan.FromHours(10)), //cuz under development and no refresh tokens, later fix it
                signingCredentials: new SigningCredentials(JwtOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
            return new JwtSecurityTokenHandler().WriteToken(jwt);
        }

        public string VerifyToken(string token)
        {
            return "ok";
        }
    }
}
