namespace iPantherToilets;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
    }

    private async void GoToInfoPageButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new NavigationPage (new InfoPage()));
    }

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
    }
}

