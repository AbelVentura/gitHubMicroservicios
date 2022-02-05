using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.Demo.Report.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        public ReportController()
        {
                
        }

        // GET api/products
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            List<string> lista = new List<string>();  
            return new JsonResult(lista);
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            List<string> lista = new List<string>();
            return new JsonResult(lista);
        }
    }
}
