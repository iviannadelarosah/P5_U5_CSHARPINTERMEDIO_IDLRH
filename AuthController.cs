using Microsoft.AspNetCore.Mvc;
using DB;
using P5_U5_CSHARPINTERMEDIO_IDLRH.Custom;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;

[Route("api/auth")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly Utilidades _utilidades;

    public AuthController(AppDbContext context, Utilidades utilidades)
    {
        _context = context;
        _utilidades = utilidades;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] Usuario usuario)
    {
        var passwordHash = _utilidades.encriptarSHA256(usuario.Password);
        var user = _context.Usuarios.FirstOrDefault(u => u.UsuarioId == usuario.UsuarioId && u.Password == passwordHash);

        if (user == null)
            return Unauthorized("Credenciales inválidas");

        var token = _utilidades.GenerarTokenJWT(user.Id);
        return Ok(new { token });
    }

    [HttpPost("refresh")]
    public IActionResult Refresh([FromBody] string token)
    {
        var handler = new JwtSecurityTokenHandler();
        var jwtToken = handler.ReadJwtToken(token);
        var userId = jwtToken.Claims.First(c => c.Type == JwtRegisteredClaimNames.UniqueName).Value;

        var newToken = _utilidades.GenerarTokenJWT(int.Parse(userId));
        return Ok(new { token = newToken });
    }
}