using Microservice.Demo.Report.API.Data.Contexts;
using Microservice.Demo.Report.API.Infrastructure.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Demo.Report.API.Infrastructure.Data
{
    public static class Extensions
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services, IConfiguration configuration)
        {
            var productConnection = configuration.GetConnectionString("ProductConnection");
            services.AddDbContext<MicroserviceDemoReportContext>(options =>
            {
                options.UseSqlServer(productConnection);
            });
            services.AddScoped<IPolicyRepository, PolicyRepository>();

            return services;
        }
    }
}
