using ExceptionDoc.Data;

namespace ExceptionDoc.Configuration
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IMovieData, MovieData>();
            return services;
        }
    }
}
