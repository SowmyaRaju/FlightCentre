using FlightFinder.API.Services;
using System.Runtime.CompilerServices;

namespace FlightFinder.API.Startup
{
    public static class DependencyInjectionSetup
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigin",
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:5240")
                               .AllowAnyHeader()
                               .AllowAnyMethod();
                    });
            });
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddTransient<IFlightCentreService, FlightCentreService>();
            return services;
        }
    }
}
