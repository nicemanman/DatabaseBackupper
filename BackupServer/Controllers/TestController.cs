using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BackupServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
            _logger.LogInformation("Test controller was created");
        }

        [HttpGet]
        public OkResult Get() 
        {
            _logger.LogError("ERROR!");
            _logger.LogWarning("WARN!");
            _logger.LogInformation("INFO!");
            _logger.LogTrace("TRACE!");
            return Ok();
        }
    }
}
