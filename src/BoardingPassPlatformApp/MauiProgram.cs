using BoardingPassComponents;
using BoardingPassShared;

namespace BoardingPassPlatformApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();

        builder.Services.AddBoardingPassComponentsServices();
		builder.Services.AddBoardingPassSharedServices(fake:true);

#if DEBUG
		// use 'edge://inspect/#devices' as URL in Edge
		// https://dev.to/rogihee/use-browser-dev-tools-with-blazor-hybrid-18nh
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif

		return builder.Build();
	}
}
