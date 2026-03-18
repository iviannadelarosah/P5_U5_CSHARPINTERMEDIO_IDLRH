using DataBase;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PF_CSHARPINTERMEDIO_IDLRH.Security;
using System.Security.Claims;

namespace PF_CSHARPINTERMEDIO_IDLRH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class usuariosController : ControllerBase
    {
        private readonly UsuarioContext _context;

        public usuariosController(UsuarioContext context)
        {
            _context = context;
        }

        [Authorize]
        [HttpGet]
        public ActionResult<IEnumerable<Usuario>> Get() => _context.usuarios.ToList();

        [Authorize]
        [HttpGet("{Id}")]
        public ActionResult<Usuario> GetById(int Id)
        {
            var usuario = _context.usuarios.Find(Id);
            if (usuario == null)
                return NotFound();

            return usuario;
        }

        [HttpPost]
        public ActionResult<Usuario> Post(Usuario usuario)
        {

            var usuarioId = User?.FindFirst("UsuarioId")?.Value;
            var nombre = User?.Identity?.Name;

            var existeCorreo = _context.usuarios.Any(u => u.Correo == usuario.Correo);
            if (existeCorreo)
            {
                return BadRequest(new { mensaje = "El correo electrónico ya está en uso." });
            }

            usuario.Password = PasswordHelper.HashPassword(usuario.Password);

            _context.usuarios.Add(usuario);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { Id = usuario.Id }, new 
            {
                usuario,
                claims = new { usuarioId, nombre }
            });
        }

        [Authorize]
        [HttpPut("{Id}")]
        public IActionResult Put(int Id, Usuario usuario)
        {
            if (Id != usuario.Id)
                return BadRequest(new { mensaje = "El Id no coincide con el usuario enviado." });

            var existingUser = _context.usuarios.Find(Id);
            if (existingUser == null)
                return NotFound(new { mensaje = "Usuario no encontrado." });

            existingUser.Nombre = usuario.Nombre;
            existingUser.Correo = usuario.Correo;
            existingUser.FechaDeNacimiento = usuario.FechaDeNacimiento;
            existingUser.Username = usuario.Username;
            existingUser.Password = PasswordHelper.HashPassword(usuario.Password);

            _context.usuarios.Update(existingUser);
            _context.SaveChanges();

            var usuarioId = User?.FindFirst("UsuarioId")?.Value;
            var nombre = User?.Identity?.Name;

            return Ok(new { mensaje = "Usuario actualizado", claims = new { usuarioId, nombre } });
        }

        [Authorize]
        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            var usuario = _context.usuarios.Find(Id);
            if (usuario == null)
                return NotFound(new { mensaje = "Usuario no encontrado." });

            _context.usuarios.Remove(usuario);
            _context.SaveChanges();

            var usuarioId = User?.FindFirst("UsuarioId")?.Value;
            var nombre = User?.Identity?.Name;

            return Ok(new { mensaje = "Usuario eliminado", claims = new { usuarioId, nombre } });
        }
    }
}