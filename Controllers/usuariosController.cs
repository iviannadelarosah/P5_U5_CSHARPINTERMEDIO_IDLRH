using DataBase;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet]
        public IEnumerable<Usuario> Get() => _context.usuarios.ToList();

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
            var existeCorreo = _context.usuarios.Any(u => u.Correo == usuario.Correo);
            if (existeCorreo)
            {
                return BadRequest(new { mensaje = "El correo electrónico ya está en uso." });
            }

            _context.usuarios.Add(usuario);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { Id = usuario.Id }, usuario);
        }

        [HttpPut("{Id}")]
        public IActionResult Put(int Id, Usuario usuario)
        {
            if (Id != usuario.Id)
                return BadRequest();

            _context.usuarios.Update(usuario);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            var usuario = _context.usuarios.Find(Id);
            if (usuario == null)
                return NotFound();

            _context.usuarios.Remove(usuario);
            _context.SaveChanges();
            return NoContent();
        }
    }
}