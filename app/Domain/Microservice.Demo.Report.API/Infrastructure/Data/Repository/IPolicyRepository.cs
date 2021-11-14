using Microservice.Demo.Report.API.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Demo.Report.API.Infrastructure.Data.Repository
{
    public interface IPolicyRepository
    {
        Task<List<Policy>> FindAllPolicy();
    }
}
