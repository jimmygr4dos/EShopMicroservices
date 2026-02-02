using Microsoft.Extensions.DependencyInjection;

namespace Ordering.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddAplicationServices(this IServiceCollection services)
    {
        // Add application services here, e.g. MediatR, AutoMapper, etc.
        return services;
    }
}
