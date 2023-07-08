using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using iPantherToilets.Auth0Test;

namespace iPantherToilets;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("materialdesignicons-webfont.ttf", "MaterialDesignIcons");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<LoginPage>();

		builder.Services.AddSingleton(new Auth0Client(new()
		{
			Domain = "dev-jzvgeh7ru5cliuek.us.auth0.com",
			ClientId = "7QimOsaguphHTN7qI4aQi0NLLxOcfrMy",
			Scope = "openid profile",
			RedirectUri = "myapp://callback"
		}));

		return builder.Build();
	}
}
