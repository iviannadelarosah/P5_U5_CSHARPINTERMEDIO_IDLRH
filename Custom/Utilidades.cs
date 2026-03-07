using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System. Text;

namespace P5_U5_CSHARPINTERMEDIO_IDLRH.Custom
{
    public class Utilidades
    {
        
        private readonly IConfiguration _configuration;
        public Utilidades(IConfiguration configuration) 
        {
            _configuration = configuration;
        }

        public string encriptarSHA256(string texto)
        {

            using (SHA256 sha256Hash = SHA256.Create())
            {

                // Computar el hash
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(texto));

                // Convertir el array de bytes a string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {

                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
        public string GenerarTokenJWT(int usuarioId)
        {
            var jwtKey = _configuration["Jwt:Key"];

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.UniqueName, usuarioId.ToString()),
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                audience: null,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(30),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}