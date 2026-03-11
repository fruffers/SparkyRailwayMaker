using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace SparkyRailwayMaker.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var assembly = typeof(DependencyInjection).Assembly;

            services.AddMediatR(Configuration =>
            Configuration.RegisterServicesFromAssembly(
                assembly));

            services.AddValidatorsFromAssembly(assembly);

            return services;
        }
    }
}
