using DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace P5_U5_CSHARPINTERMEDIO_IDLRH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsuariosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet] //GET: api/usuarios
        public ActionResult<List<Usuario>> Get()
        {
            return _context.Usuarios.ToList();
        }

        [HttpGet("{id}")] //GET: api/usuarios/id
        public ActionResult<Usuario> GetById(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            if (usuario == null)
                return NotFound();
            return usuario;
        }

        [HttpPost] //POST: api/usarios
        public async Task<ActionResult> CrearUsuario([FromBody] Usuario usuario)
        {
            var existe = await _context.Usuarios.AnyAsync(u => u.Correo == usuario.Correo);
            if (existe)
                return BadRequest(new { mensaje = "El correo electrónico ya está en uso." });
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = usuario.Id }, usuario);
        }

        [HttpPut("{id}")] //PUT: api/usuarios/id
        public async Task<ActionResult> ActualizarUsuario(int id, [FromBody] Usuario usuario)
        {
            if (id != usuario.Id)
                return BadRequest();
            _context.Entry(usuario).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")] //DELETE: api/usuarios/id
        public async Task<ActionResult> EliminarUsuario(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
                return NotFound();

            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();

            return NoContent();

        }
    }
}