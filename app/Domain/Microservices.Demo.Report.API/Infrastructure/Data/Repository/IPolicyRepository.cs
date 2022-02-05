using Microservices.Demo.Report.API.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.Demo.Report.API.Infrastructure.Data.Repository
{
    public interface IPolicyRepository
    {
        Task<List<Policy>> GetPolicies(string agentLogin);
    }
}
