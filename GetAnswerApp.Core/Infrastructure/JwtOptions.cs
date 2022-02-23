using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace GetAnswerApp.Core.Infrastructure
{
    public class JwtOptions
    {
        public const string Issuer = "GetAnswerAppServer";
        public const string Audience = "GetAnswerAppClient";
        const string Key = "mysupersecret_secretkey!123";
        public static SymmetricSecurityKey GetSymmetricSecurityKey() => new(Encoding.UTF8.GetBytes(Key));
    }
}
