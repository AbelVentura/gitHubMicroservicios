using MediatR;
using Microservice.Demo.Report.API.CQRS.Queries.Infrastructure.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Demo.Report.API.CQRS.Queries.FindAllReport
{
    public class FindAllReportQuery : IRequest<IEnumerable<ReportDto>>
    {
    }
}
