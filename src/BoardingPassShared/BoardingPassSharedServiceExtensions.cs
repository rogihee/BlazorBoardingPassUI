using BoardingPassShared.Converters;

namespace BoardingPassShared;

public static class BoardingPassSharedServiceExtensions
{
    public static IServiceCollection AddBoardingPassSharedServices(this IServiceCollection services, bool fake)
    {
        if (fake)
        {
            services.AddScoped<IBoardingPassService, FakeBoardingPassService>();
        }
        else
        {
            services.AddScoped<IBoardingPassService, BoardingPassService>();
        }
        return services;
    }
}
