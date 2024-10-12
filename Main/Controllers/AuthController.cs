
using Bussines.Auth.models;
using Bussines.Auth.repositories;
using Bussines.Errors;
using Main.models;
using Microsoft.AspNetCore.Mvc;

namespace Main.Controllers
{
    [ApiController]
    [Route("/api/auth")]
    public class AuthController : ControllerBase
    {
        public readonly ILogger _logger;
        public readonly IAuthRepository _auth;
        public AuthController(
            IAuthRepository auth,
            ILogger<AuthController> logger
        ) {
          _auth = auth;
            _logger = logger;
        }

        [HttpPost]
        [Route("register")]
        public ActionResult<CustomResponse> Register(AppUserRegister body) {
          try
            {
                _auth.Register(body);
                
                return Ok(new CustomResponse {Code = "200", Message = "Usuario creado correctamente"});
            } catch(MessageExeption ex) {
               _logger.LogError(
                    $"[RolController][Obtener] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true) {
                  Message = ex.Message
                });
            }
            catch(Exception ex)
            {
                _logger.LogError(
                    $"[RolController][Obtener] {ex.Message}\n {ex.StackTrace} ");
                return StatusCode(500, new CustomResponse(error: true));
            }
        }
    }
}