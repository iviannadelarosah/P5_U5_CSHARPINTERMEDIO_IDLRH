using DataBase;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace PF_CSHARPINTERMEDIO_IDLRH.Security
{
    public class JwtService
    {
        private readonly string _secret;

        public JwtService(IConfiguration config)
        {
            _secret = config["Jwt:Key"];
        }

        public string GenerateToken(Usuario user)
        {
            var claims = new[]
            {
                new Claim("UsuarioId", user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Username)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secret));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.UtcNow.AddMonths(1),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public RefreshToken GenerateRefreshToken(Usuario user)
        {
            return new RefreshToken
            {
                Token = Guid.NewGuid().ToString(),
                ExpiryDate = DateTime.UtcNow.AddDays(7),
                UsuarioId = user.Id
            };
        }
    }
}