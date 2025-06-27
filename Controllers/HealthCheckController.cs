using Microsoft.AspNetCore.Mvc;

namespace NicBackend.Controllers
{
    [ApiController]
    [Route("/healthz")]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok("Healthy");
    }
}
