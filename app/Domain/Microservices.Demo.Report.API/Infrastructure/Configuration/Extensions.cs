using Microservices.Demo.Report.API.Data.Context;
using Microservices.Demo.Report.API.Infrastructure.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.Demo.Report.API.Infrastructure.Configuration
{
    public static class Extensions
    {
        public static IServiceCollection AddConfigurations(this IServiceCollection services, IConfiguration configuration)
        {
            /*var policyConnection = configuration.GetConnectionString("PolicyConnection");
            services.AddDbContext<MicroservicesDemoPolicyDBContext>(options =>
            {
                options.UseSqlServer(policyConnection);
            });
            services.AddScoped<IUnitOfWork, UnitOfWork.UnitOfWork>();
            */
            var connectionStrings = configuration.GetSection("ConnectionStrings");
            services.Configure<ConnectionStrings>(connectionStrings);

            var servicesUrl = configuration.GetSection("ServicesUrl");
            services.Configure<ServicesUrl>(servicesUrl);

            return services;
        }
    }
}
