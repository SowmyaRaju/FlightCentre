using FlightFinder.API.Services;
using System.Runtime.CompilerServices;

namespace FlightFinder.API.Startup
{
    public static class DependencyInjectionSetup
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddTransient<IFlightCentreService, FlightCentreService>();
            return services;
        }
    }
}
