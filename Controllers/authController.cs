using DataBase;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using PF_CSHARPINTERMEDIO_IDLRH.Models;
using PF_CSHARPINTERMEDIO_IDLRH.Security;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace PF_CSHARPINTERMEDIO_IDLRH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly UsuarioContext _context;
        private readonly JwtService _jwtService;

        public AuthController(UsuarioContext context, JwtService jwtService)
        {
            _context = context;
            _jwtService = jwtService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            if (request == null)
                return BadRequest(new { mensaje = "Body vacío o inválido" });

            if (string.IsNullOrEmpty(request.Username))
                return BadRequest(new { mensaje = "Username requerido" });

            if (string.IsNullOrEmpty(request.Password))
                return BadRequest(new { mensaje = "Password requerido" });

            var user = _context.usuarios.SingleOrDefault(u => u.Username == request.Username);
            if (user == null)
                return Unauthorized(new { mensaje = "Usuario no encontrado" });

            var hashedInput = PasswordHelper.HashPassword(request.Password);
            if (user.Password != hashedInput)
                return Unauthorized(new { mensaje = "Contraseña incorrecta" });

            var token = _jwtService.GenerateToken(user);
            var refreshToken = _jwtService.GenerateRefreshToken(user);

            _context.RefreshTokens.Add(refreshToken);
            _context.SaveChanges();

            return Ok(new
            {
                token,
                refreshToken = refreshToken.Token
            });
        }

        [HttpPost("refresh")]
        public IActionResult Refresh([FromBody] RefreshRequest request)
        {
            if (request == null || string.IsNullOrEmpty(request.Token))
                return BadRequest(new { mensaje = "Token de refresh inválido" });

            var refreshToken = _context.RefreshTokens.SingleOrDefault(r => r.Token == request.Token);
            if (refreshToken == null)
                return Unauthorized(new { mensaje = "Refresh token no encontrado" });

            var usuario = _context.usuarios.Find(refreshToken.UsuarioId);
            if (usuario == null)
                return Unauthorized(new { mensaje = "Usuario no encontrado para este token" });

            var jwt = _jwtService.GenerateToken(usuario);

            return Ok(new { token = jwt });

        }
    }
}