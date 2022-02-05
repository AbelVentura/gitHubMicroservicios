using Microservices.Demo.Report.API.CQRS.Queries.Policies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microservices.Demo.Report.API.Application;

namespace Microservices.Demo.Report.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly ReportApplicationService reportApplicationService;
        
        public ReportsController(ReportApplicationService reportApplicationService)
        {
            this.reportApplicationService = reportApplicationService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll([FromHeader] string AgentLogin)
        {
            return new JsonResult(await reportApplicationService.GetPoliciesAll(AgentLogin));
        }
    }
}
