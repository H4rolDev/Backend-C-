using Data.DataBase;
using Microsoft.AspNetCore.Mvc;

namespace Main.Controllers
{

    [ApiController]
    [Route("api/productos")]
    public class ProductoController: ControllerBase
    {
        private readonly MiDbContext _db;

        public ProductoController(MiDbContext db) {
            _db = db;
        }



        [HttpGet]
        [Route("")]
        public IActionResult ListarProductos()
        {
            var productos = _db.productos.ToList();

            return Ok(productos);
        }

    }
}
