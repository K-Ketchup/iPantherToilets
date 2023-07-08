using iPantherToilets.Auth0Test;

namespace iPantherToilets;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new AppShell();
        //MainPage = new MainPage();
        UserAppTheme = AppTheme.Light;
    }
}
