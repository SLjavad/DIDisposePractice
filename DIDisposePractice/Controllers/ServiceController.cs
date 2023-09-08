using DIDisposePractice.Services;
using Microsoft.AspNetCore.Mvc;

namespace DIDisposePractice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServiceController : ControllerBase
    {

        private readonly ILogger<ServiceController> _logger;
        private readonly IServiceA serviceA;
        private readonly IServiceB serviceB;

        public ServiceController(ILogger<ServiceController> logger, IServiceA serviceA, IServiceB serviceB)
        {
            _logger = logger;
            this.serviceA = serviceA;
            this.serviceB = serviceB;
        }

        [HttpGet(Name = "ServiceA")]
        public IActionResult Get()
        {
            serviceA.DoTaskA();
            serviceB.DoTaskB();
            return Ok();
        }
    }
}