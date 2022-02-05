using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.Demo.Report.API.CQRS.Queries.Infrastructure.Dtos
{
    public class PolicyDto
    {
        public int PolicyId { get; set; }
        public string Number { get; set; }
        public string ProductCode { get; set; }
        public string AgentLogin { get; set; }
        public int PolicyStatusId { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
