using Application.Repositiory;
using Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class Extension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IClickUpService, ClickUpRepo>();
            return services;
        }
        
    }
}
