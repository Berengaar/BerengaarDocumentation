using CQRSDoc.Application.Interfaces;
using CQRSDoc.Infrastructure.Persistance;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSDoc.Infrastructure.Configuration
{
    public static class InfrastructureServiceRegistration
    {
        public static void AddPersistanceService(this IServiceCollection services)
        {
            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
        }
    }
}
