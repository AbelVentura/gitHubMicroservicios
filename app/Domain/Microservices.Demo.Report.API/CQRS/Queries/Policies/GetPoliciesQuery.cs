using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.Demo.Report.API.CQRS.Queries.Policies
{
    public class GetPoliciesQuery : IRequest<PoliciesQueryResult>
    {
        public string AgentLogin { get; set; }
    }
}
