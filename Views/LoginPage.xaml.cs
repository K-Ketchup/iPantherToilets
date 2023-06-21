namespace iPantherToilets;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
	}

	private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync($"//{nameof(MainPage)}/{nameof(RegistrationPage)}");
    }
}