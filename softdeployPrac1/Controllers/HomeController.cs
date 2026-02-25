using Microsoft.AspNetCore.Mvc;

namespace softdeployPrac1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetMessage()
        {
            return Ok("Hola mundo, validando la solución de conflictos");
        }
    }
}
