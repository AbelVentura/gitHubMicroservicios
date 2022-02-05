using MediatR;
using Microservices.Demo.Report.API.CQRS.Queries.Infrastructure.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.Demo.Report.API.CQRS.Queries.Policies
{
    public class GetPoliciesQuery : IRequest<List<PolicyDto>>
    {
        public string AgentLogin { get; set; }
    }
}
