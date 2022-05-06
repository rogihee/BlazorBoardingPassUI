using BoardingPassComponents;
using BoardingPassPlatformApp.Data;
using BoardingPassShared;

namespace BoardingPassPlatformApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
    	// change color:
        // https://material.io/resources/color/#!/?view.left=0&view.right=1

		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();

		builder.Services.AddSingleton<WeatherForecastService>();
        builder.Services.AddBoardingPassComponentsServices();
		builder.Services.AddBoardingPassSharedServices(fake:true);

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
#endif

		return builder.Build();
	}
}
