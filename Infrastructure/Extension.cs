using AcxiomClickup.Application.Services;
using AcxiomClickup.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class Extension
    {

        public static IServiceCollection  AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IHomeService, HomeService>();
            return services;
        }
        public static string ToLowerCase(this string str)
        {
            return str.ToLower();
        }
    }
}