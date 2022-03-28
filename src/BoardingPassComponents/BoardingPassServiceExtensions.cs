using Microsoft.Extensions.DependencyInjection;

namespace BoardingPassComponents;

public static class BoardingPassServiceExtensions
{
    public static IServiceCollection AddIxComponentsServices(this IServiceCollection services)
    {
        services.AddSingleton<BoardingPassService>();
        return services;
    }
}
