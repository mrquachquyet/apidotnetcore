using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using G_Stars.Api.Filters;
using G_Stars.Api.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace G_Stars.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskJobsController : BaseController
    {
        private readonly ILogger<TaskJobsController> _logger;
        public TaskJobsController(ILogger<TaskJobsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Get()
        {
            _logger.LogInformation("xxxxxxxxxxxxxxxxxxxxx");
            var principal = System.Security.Claims.ClaimsPrincipal.Current;
            return Ok(null);
        }
        [HttpPost]
        [Authorize]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public IActionResult Save(Test test)
        {
            var a = test.Message;
            return Ok(null);
        }

        [HttpPost]
        [Authorize]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [Route("Savexxx")]
        public IActionResult Save1(Test test)
        {
            return Ok(null);
        }
    }
}