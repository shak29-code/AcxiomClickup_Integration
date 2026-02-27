
using Application.App_Code;
using Application.Repositiory;
using Application.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class Extension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ICLickUpService, ClickUpRepo>();
            services.AddScoped<ClickUpConfig>();
            return services;
        }
        
    }
}
