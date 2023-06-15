using iPantherToilets.Views;

namespace iPantherToilets;

public partial class InfoPage : ContentPage
{
	public InfoPage()
	{
		InitializeComponent();
	}

    private async void ReturnToHomePageButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new MainPage());
    }

    private async void GoToAddReviewPageButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new AddReviewPage());
    }
}