using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace collegeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoggersController : ControllerBase
    {
        private readonly ILogger<LoggersController> _logger;
        public LoggersController(ILogger<LoggersController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public ActionResult Index()
        {
            _logger.LogTrace("log message from trace level");
            _logger.LogDebug("log message from Debug level");
            _logger.LogInformation("log message from Information level");
            _logger.LogWarning("log message from Warning level");
            _logger.LogError("log message from Error level");
            _logger.LogCritical("log message from Critical level");
                return Ok();
        }
    }
}
