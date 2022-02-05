using Microservices.Demo.Report.API.CQRS.Queries.Infrastructure.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Microservices.Demo.Report.API.CQRS.Queries.Policies
{
    public class PoliciesQueryResult
    {
        public List<PolicyDto> Policy { get; set; }
        public PolicyDto Polic { get; set; }
    }
}
