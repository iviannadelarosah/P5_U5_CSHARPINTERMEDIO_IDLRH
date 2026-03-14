using DB;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using P5_U5_CSHARPINTERMEDIO_IDLRH.Models;
using P5_U5_CSHARPINTERMEDIO_IDLRH.Services;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace P5_U5_CSHARPINTERMEDIO_IDLRH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsuariosController : ControllerBase
    {
        private readonly UsuarioDbContext _context;

        public UsuariosController(UsuarioDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Usuario>> Get()
        {
            return _context.Usuarios.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Usuario> GetById(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            if (usuario == null)
                return NotFound();
            return usuario;
        }

        [HttpPost]
        public async Task<ActionResult> CrearUsuario([FromBody] Usuario usuario)
        {
            var existe = await _context.Usuarios.AnyAsync(u => u.Correo == usuario.Correo);
            if (existe)
                return BadRequest(new { mensaje = "El correo electrónico ya está en uso." });
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = usuario.Id }, usuario);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> ActualizarUsuario(int id, [FromBody] Usuario usuario)
        {
            if (id != usuario.Id)
                return BadRequest();
            _context.Entry(usuario).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> EliminarUsuario(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
                return NotFound();

            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();

            return NoContent();

        }
        public class AuthController : ControllerBase
        {
            private readonly UsuarioDbContext _context;
            private readonly IConfiguration _configuration;

            public AuthController(UsuarioDbContext context, IConfiguration configuration)
            {
                _context = context;
                _configuration = configuration;
            }

            [HttpPost("login")]
            public async Task<IActionResult> Login([FromBody] P5_U5_CSHARPINTERMEDIO_IDLRH.Models.LoginRequest request)
            {
                if (string.IsNullOrWhiteSpace(request.UsuarioId) || string.IsNullOrWhiteSpace(request.Password))
                {
                    return BadRequest("UsuarioId y Password son obligatorios.");
                }

                var usuario = await _context.Usuarios
                    .FirstOrDefaultAsync(u => u.UsuarioId == request.UsuarioId);

                if (usuario == null || usuario.Password != request.Password)
                {
                    return Unauthorized("Credenciales inválidas.");
                }
                var token = GenerarToken(usuario);
                return Ok(new { token });
            }

            private string GenerarToken(Usuario usuario)
            {
                var claims = new[]
                {
                new Claim(JwtRegisteredClaimNames.Sub, usuario.UsuarioId),
                new Claim("role", "User")
            };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: _configuration["Jwt:Issuer"],
                    audience: _configuration["Jwt:Audience"],
                    claims: claims,
                    expires: DateTime.Now.AddHours(1),
                    signingCredentials: creds);

                return new JwtSecurityTokenHandler().WriteToken(token);
            }

        }
    }
}