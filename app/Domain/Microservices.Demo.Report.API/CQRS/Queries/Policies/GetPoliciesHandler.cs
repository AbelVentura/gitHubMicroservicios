using MediatR;
using Microservices.Demo.Report.API.CQRS.Queries.Infrastructure.Dtos;
using Microservices.Demo.Report.API.Infrastructure.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Microservices.Demo.Report.API.CQRS.Queries.Policies
{
    public class GetPoliciesHandler : IRequestHandler<GetPoliciesQuery, List<PolicyDto>>
    {
        private readonly IPolicyRepository _policyRepository;

        public GetPoliciesHandler(IPolicyRepository policyRepository)
        {
            _policyRepository = policyRepository ?? throw new ArgumentNullException(nameof(policyRepository));
        }

        public async Task<List<PolicyDto>> Handle(GetPoliciesQuery request, CancellationToken cancellationToken)
        {
            List<PolicyDto> response = new List<PolicyDto>();
            var policy = await _policyRepository.GetPolicies(request.AgentLogin);
            if (policy == null)
            {
                throw new ApplicationException($"Policy {request.AgentLogin} not found!");
            }

            return response;
        }
    }
}
