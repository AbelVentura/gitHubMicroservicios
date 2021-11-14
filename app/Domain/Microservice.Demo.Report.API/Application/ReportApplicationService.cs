using MediatR;
using Microservice.Demo.Report.API.CQRS.Queries.FindAllReport;
using Microservice.Demo.Report.API.CQRS.Queries.Infrastructure.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Demo.Report.API.Application
{
    public class ReportApplicationService
    {
        private readonly IMediator _mediator;
        public ReportApplicationService(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }
        public async Task<IEnumerable<ReportDto>> GetAllPolicyAsync()
        {
            var policies = await _mediator.Send(new FindAllReportQuery());
            return policies;
        }
    }
}
