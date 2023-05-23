﻿namespace iPantherToilets;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
    }

    private async void GoToInfoPage_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new InfoPage());
    }
}

