using MediatR;
using Microservices.Demo.Report.API.CQRS.Queries.Policies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.Demo.Report.API.Application
{
    public class ReportApplicationService
    {
        private readonly IMediator _mediator;
        public ReportApplicationService(IMediator mediator)
        {
            _mediator = mediator;
        }

        /*public async Task<PoliciesQueryResult> GetPoliciesAll(string agentLogin)
        {
            var result = await _mediator.Send(new GetPoliciesQuery { AgentLogin = agentLogin }); 
        }*/
    }
}
