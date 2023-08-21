using JWTAuth.Services.Interface;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.AccessControl;
using System.Security.Claims;
using System.Text;

namespace JWTAuth.Services
{
    public class TokenService : IToken
    {
        private readonly IConfiguration _configurationManager;

        public TokenService(IConfiguration configurationManager)
        {
            _configurationManager = configurationManager;
        }

        public string GenerateToken(string username, string role)
        {
            var jwtSetting = _configurationManager.GetSection("JwtSettings");
            var secretKey = Encoding.ASCII.GetBytes("thananae thamarapooo ....");
            Console.WriteLine(secretKey);
            var issuer = jwtSetting["Issuer"];

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, username),
                new Claim(ClaimTypes.Role,role)
            };
            var takenDescription = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Issuer = issuer,
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(secretKey), SecurityAlgorithms.HmacSha512)
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(takenDescription);

            return tokenHandler.WriteToken(token);
        }
    }
}
