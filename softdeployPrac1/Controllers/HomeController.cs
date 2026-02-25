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
            return Ok("Nuevo mensaje desde la corrección");
        }
    }
}
