using iPantherToilets;

namespace iPantherToilets;

public partial class InfoPage : ContentPage
{
	public InfoPage()
	{
		InitializeComponent();
	}

    private async void ReturnToHomePageButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

}