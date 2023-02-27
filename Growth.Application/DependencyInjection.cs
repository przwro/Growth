using Microsoft.Extensions.DependencyInjection;

namespace Growth.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services) 
        {
            return services;
        }
    }
}
