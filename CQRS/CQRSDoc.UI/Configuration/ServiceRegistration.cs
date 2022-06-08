using CQRSDoc.Application.Interfaces;
using MediatR;
using System.Reflection;

namespace CQRSDoc.UI.Configuration
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddMediatR(typeof(IApplicationDbContext));
            return services;
        }
    }
}
