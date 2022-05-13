using Microsoft.Extensions.DependencyInjection;

namespace BoardingPassComponents;

public static class BoardingPassComponentsServiceExtensions
{
    public static IServiceCollection AddBoardingPassComponentsServices(this IServiceCollection services)
    {
        services.AddScoped<JsBarcodeService>();
        return services;
    }
}
