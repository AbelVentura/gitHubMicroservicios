using MediatR;
using Microservice.Demo.Report.API.CQRS.Queries.Infrastructure.Datos;
using Microservice.Demo.Report.API.Infrastructure.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Microservice.Demo.Report.API.CQRS.Queries.FindAllReport
{
    public class FindAllReportHandler : IRequestHandler<FindAllReportQuery, IEnumerable<ReportDto>>
    {
        private readonly IPolicyRepository _policyRepository;

        public FindAllReportHandler(IPolicyRepository policyRepository)
        {
            _policyRepository = policyRepository ?? throw new ArgumentNullException(nameof(policyRepository));
        }

        public async Task<IEnumerable<ReportDto>> Handle(FindAllReportQuery request, CancellationToken cancellationToken)
        {
            var result = await _policyRepository.FindAllPolicy();

            return result.Select(p => new ReportDto
            {
                Code = p.PolicyId
            }).ToList();
        }
    }
}
