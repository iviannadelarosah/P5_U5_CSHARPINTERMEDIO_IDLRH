using DataBase;
using Microsoft.AspNetCore.Mvc;

namespace PF_CSHARPINTERMEDIO_IDLRH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class productosController : ControllerBase
    {
        private readonly ProductoContext _context;

        public productosController(ProductoContext context)
        {
            _context = context;
        }

        [HttpGet("precios")]
        public IActionResult GetPropiedadesProductos()
        {
            if (!_context.productos.Any())
            {
                return NotFound(new { mensaje = "No hay productos registrados" });
            }

            var productoCaro = (from p in _context.productos
                                orderby p.Precio descending
                                select p).FirstOrDefault();

            var productoBarato = (from p in _context.productos
                                  orderby p.Precio ascending
                                  select p).FirstOrDefault();

            var productoSumatoria = (from p in _context.productos
                                     select p.Precio).Sum();

            var productoPromedio = (from p in _context.productos
                                    select p.Precio).Average();
            
            return Ok(new 
            { 
                ProductoMasCaro = productoCaro,
                ProductoMasBarato = productoBarato,
                SumatoriaPrecios = productoSumatoria,
                PromedioPrecios = productoPromedio
            });
        }

        [HttpGet("categoria/{categoriaId}")]
        public IActionResult GetProductosPorCategoria(int categoriaId) 
        {
            var categoriaExiste = _context.categorias.Any(c =>
            c.Id == categoriaId);
            if (!categoriaExiste)
            {
                return NotFound(new { mensaje = $"La categoria con Id {categoriaId} no existe" });
            }

            var productoCategoria = (from p in _context.productos
                                     where p.CategoriaId == categoriaId
                                     select p).ToList();

            if (!productoCategoria.Any())
            {
                return NotFound(new { mensaje = $"No hay productos en la categoría con Id {categoriaId}" });
            }

            return Ok(new { ListadoProductos_Categoria = productoCategoria });
        }

        [HttpGet("proveedor/{proveedorId}")]
        public IActionResult GetProductosPorProveedor(int proveedorId) 
        {
            var proveedorExiste = _context.proveedores.Any(p => 
            p.Id == proveedorId);
            if (!proveedorExiste)
            {
                return NotFound(new { mensaje = $"El proveedor con Id {proveedorId} no existe" });
            }

            var productoProveedor = (from p in _context.productos
                                     where p.ProveedorId == proveedorId
                                     select p).ToList();

            if (!productoProveedor.Any())
            {
                return NotFound(new { mensaje = $"No hay productos con el proveedor con Id {proveedorId}" });
            }

            return Ok(new { ListadoProductos_Proveedor = productoProveedor });
        }

        [HttpGet("registrados")]
        public IActionResult GetProductosRegistrados()
        {
            if (!_context.productos.Any())
            {
                return NotFound(new { mensaje = "No hay productos registrados" });
            }

            var productosRegistrados = (from p in _context.productos
                                        select p).Count();

            return Ok(new { TotalProductos_Registrados = productosRegistrados });
        }
    }
}