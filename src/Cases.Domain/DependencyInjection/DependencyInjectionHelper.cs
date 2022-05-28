using Microsoft.Extensions.DependencyInjection;

namespace Cases.Domain.DependencyInjection
{
    public static class DependencyInjectionHelper
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            return services;
        }
    }
}
