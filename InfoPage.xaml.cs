namespace iPantherToilets;

public partial class InfoPage : ContentPage
{
	public InfoPage()
	{
		InitializeComponent();
	}

    private void ReturnToHomePageButton_Clicked(object sender, EventArgs e)
    {
		Navigation.PushModalAsync(new MainPage());
    }
}