using Microservices.Demo.Report.API.Data.Context;
using Microservices.Demo.Report.API.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.Demo.Report.API.Infrastructure.Data.Repository
{
    public class PolicyRepository : IPolicyRepository
    {
        private readonly MicroservicesDemoPolicyDBContext _policyDbContext;
         //public IUnitOfWork UnitOfWork => _context;
        public PolicyRepository(MicroservicesDemoPolicyDBContext policyDbContext)
        {
            _policyDbContext = policyDbContext;
        }
        public async Task<List<Policy>> GetPolicies(string agentLogin)
        {
            return await _policyDbContext.Policies.Where(p => p.AgentLogin == agentLogin).ToListAsync();
        }
    }
}
