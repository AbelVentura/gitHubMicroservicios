using Microservice.Demo.Report.API.Application;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Demo.Report.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly ReportApplicationService _reportApplicationService;
        public ReportController(ReportApplicationService reportApplicationService)
        {
            _reportApplicationService = reportApplicationService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            return new JsonResult(await _reportApplicationService.GetAllPolicyAsync());
        }
    }
}
