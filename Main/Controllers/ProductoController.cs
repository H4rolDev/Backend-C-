using Data.DataBase;
using Data.DataBase.Tables;
using Microsoft.AspNetCore.Mvc;


namespace Main.Controllers
{

    [ApiController]
    [Route("api/productos")]
    public class ProductoController : ControllerBase
    {
        private readonly MiDbContext _db;

        public ProductoController(MiDbContext db)
        {
            _db = db;
        }

        // Listar todas las Productos
        [HttpGet]
        [Route("")]
        public IActionResult ListarProductos()
        {
            var productos = _db.productos.ToList();

            return Ok(productos);
        }

        //Obtener una Producto por su ID
        [HttpGet]
        [Route("{id}")]
        public IActionResult ObtenerProducto([FromRoute] int id)
        {
            var producto = _db.productos.Find(id);
            if (producto == null)
            {
                return NotFound(); // StatusCode(404);
            }

            return Ok(producto); // StatusCode(200);
        }

        // Creado una nueva catgoria 
        [HttpPost]
        [Route("")]
        public IActionResult CrearProducto([FromBody] Producto body)
        {
            _db.productos.Add(body);
            int r = _db.SaveChanges();
            if (r != 1)
            {
                return StatusCode(500);
            }
            //return NoContent(); //StatusCode 204
            return Ok(body);
        }


        /**
         * Actualiza una Producto
         */
        [HttpPut]
        [Route("{id}")]
        public IActionResult ActualizarProducto(
            [FromRoute] int id,
            [FromBody] Producto body)
        {
            // Obtengo la Producto y vaido su existencia
            var producto = _db.productos.Find(id);
            if (producto == null)
            {
                return NotFound(); // StatusCode(404);
            }
            // Actualizo lo campos con los datos que recibo 
            // desde el BODY
            producto.categoria_id = body.categoria_id;
            producto.imagen = body.imagen;
            producto.descripcion = body.descripcion;
            producto.modelo = body.modelo;
            producto.marca = body.marca;
            producto.precio = body.precio;
            producto.stock = body.stock;
            producto.garantia = body.garantia;

            // Guardo los cambios en la BD
            int r = _db.SaveChanges();
            if (r != 1)
            {
                return StatusCode(500);
            }
            return NoContent(); //StatusCode 204

        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult EliminarProducto([FromRoute] int id)
        {
            // Obtengo la Producto y vaido su existencia
            var Producto = _db.productos.Find(id);
            if (Producto == null)
            {
                return NotFound(); // StatusCode(404);
            }
            // indico que se elimine de la tabla
            _db.productos.Remove(Producto);
            // Aplico los cambios a la BD
            int r = _db.SaveChanges();

            // Verifico que se hayan efectuado estos cambios
            if (r != 1)
            {
                return StatusCode(500);
            }
            return NoContent(); //StatusCode 204
        }

        [HttpGet("productos/categoria/{categoriaId}")]
        public IActionResult GetProductosPorCategoria(int categoriaId)
        {
            var productos = _db.productos
                .Where(p => p.categoria_id == categoriaId)
                .ToList();
            return Ok(productos);
        }

        //Filtros
        [HttpGet]
        [Route("buscar")]
        public IActionResult BuscarProductos(string q)
        {
            if (string.IsNullOrEmpty(q))
        {
            return BadRequest("El término de búsqueda no puede estar vacío");
        }

        // Supongamos que tienes una clase `Producto` y un contexto de base de datos `_context`
        var productos = _db.productos
            .Where(p => p.marca.Contains(q) || p.descripcion.Contains(q))
            .ToList();

        if (!productos.Any())
        {
            return NotFound("No se encontraron productos que coincidan con la búsqueda");
        }

        return Ok(productos);
        }

    }
}
