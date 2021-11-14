using Microservice.Demo.Report.API.Data.Contexts;
using Microservice.Demo.Report.API.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Demo.Report.API.Infrastructure.Data.Repository
{
    public class PolicyRepository : IPolicyRepository
    {
        private readonly MicroserviceDemoReportContext _policyDbContext;

        public PolicyRepository(MicroserviceDemoReportContext policyDbContext)
        {
            _policyDbContext = policyDbContext ?? throw new ArgumentNullException(nameof(policyDbContext));
        }
        public async Task<List<Policy>> FindAllPolicy()
        {
            return await _policyDbContext.Policies.ToListAsync();// ToListAsync();
            //return await _policyDbContext
            //    .Products
            //    .Include(c => c.Covers)
            //    .Include("Questions.Choices")
            //    .Where(p => p.ProductStatusId == (int)EnumProductStatus.Active)
            //    .ToListAsync();
        }
    }
}
