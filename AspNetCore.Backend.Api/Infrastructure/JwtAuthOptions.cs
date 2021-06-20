using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace AspNetCore.Backend.Api.Infrastructure
{
    public static class JwtAuthOptions
    {
        public const string Issuer = "AuthServer";
        public const string Audience = "https://flatlogic.com/";
        const string Key = "admin_secretkey_prod";
        public const int Lifetime = 200;
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Key));
        }
    }
}
