namespace iPantherToilets;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        //MainPage = new LoginPage();
        MainPage = new MainPage();
        UserAppTheme = AppTheme.Light;
    }
}
