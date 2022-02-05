using MediatR;
using Microservices.Demo.Report.API.CQRS.Queries.Infrastructure.Dtos;
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
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        /*public async Task<PoliciesQueryResult> GetPoliciesAll(string agentLogin)
        {
            var result = await _mediator.Send(new GetPoliciesQuery { AgentLogin = agentLogin });
            return result;
        }*/
        public async Task<List<PolicyDto>> GetPoliciesAll(string agentLogin)
        {
            var products = await _mediator.Send(new GetPoliciesQuery { AgentLogin = agentLogin });
            return products;
        }
    }
}
