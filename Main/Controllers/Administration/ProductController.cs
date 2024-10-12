using Bussines.Errors;
using Bussines.Store.models;
using Bussines.Store.repositories;
using Bussines.Store.services;
using Main.models;
using Microsoft.AspNetCore.Mvc;

namespace Main.Controllers
{
    [ApiController]
    [Route("/api/administration/product")]
    public class ProductController: ControllerBase
    {
        public readonly ILogger _logger;
        public readonly IProductRepository _prodRepo;
        public ProductController(
            IProductRepository prodRepo,
            ILogger<ProductController> logger
        ) {
          _prodRepo = prodRepo;
          _logger = logger;
        }
        [HttpGet]
        [Route("")]
        public ActionResult<List<Product>> Listar()
        {
            try
            {
                List<Product> products = _prodRepo.product().GetAll();
                return Ok(products);
            }
            catch(MessageExeption ex) {
                _logger.LogError(
                    $"[ProductController][Listar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) { Message = ex.Message});
            }
            catch (Exception ex) {
                _logger.LogError(
                    $"[ProductController][Listar] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }
    }
}