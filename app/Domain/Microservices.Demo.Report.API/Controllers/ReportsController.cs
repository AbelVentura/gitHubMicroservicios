using Microservices.Demo.Report.API.CQRS.Queries.Policies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.Demo.Report.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        public ReportsController()
        {
                
        }

        // GET api/products
        [HttpGet]
        public async Task<ActionResult> GetAll([FromHeader] string AgentLogin)
        {

            List<PoliciesQueryResult> lista = new List<PoliciesQueryResult>();
            PoliciesQueryResult obj = new PoliciesQueryResult();
            obj.PolicyId = 1;
            obj.Number = "278fd916-3394-400d-9dc6-197aaf67cf69";
            obj.AgentLogin = "erick";

            lista.Add(obj);
            return new JsonResult(lista);
        }

        [HttpGet]
        public async Task<ActionResult> Get([FromHeader] string AgentLogin)
        {
            List<PoliciesQueryResult> lista = new List<PoliciesQueryResult>();
            PoliciesQueryResult obj = new PoliciesQueryResult();
            obj.PolicyId = 1;
            obj.Number = "278fd916-3394-400d-9dc6-197aaf67cf69";
            obj.AgentLogin = "erick";

            lista.Add(obj);
            return new JsonResult(lista);
        }
    }
}
