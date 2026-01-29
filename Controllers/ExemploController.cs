using Microsoft.AspNetCore.Mvc;

namespace MinhaPrimeiraApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExemploController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Minha primeira API está funcionando!");
        }
    }
}
