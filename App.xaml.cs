namespace iPantherToilets;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new LoginPage();
        UserAppTheme = AppTheme.Light;
    }
}
