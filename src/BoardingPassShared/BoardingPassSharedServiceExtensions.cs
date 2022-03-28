namespace BoardingPassShared;

public static class BoardingPassSharedServiceExtensions
{
    public static IServiceCollection AddBoardingPassSharedServices(this IServiceCollection services, bool fake)
    {
        if (fake)
        {
            services.AddSingleton<IBoardingPassService, FakeBoardingPassService>();
        }
        else
        {
            services.AddSingleton<IBoardingPassService, FakeBoardingPassService>();
        }
        return services;
    }
}
