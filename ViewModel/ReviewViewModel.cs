using iPantherToilets.Models;
using iPantherToilets.Services;
using MvvmHelpers;
using MvvmHelpers.Commands;
using iPantherToilets.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iPantherToilets.ViewModel
{
    public class ReviewViewModel : BaseViewModel
    {
        public ObservableRangeCollection<Review> Review { get; set; }
        public AsyncCommand RefreshCommand { get; }
        public AsyncCommand AddCommand { get; }
        public AsyncCommand<Review> RemoveCommand { get; }

        public ReviewViewModel()
        {
            Title = "My Review";

            Review = new ObservableRangeCollection<Review>();

            RefreshCommand = new AsyncCommand(Refresh);
            AddCommand = new AsyncCommand(Add);
            RemoveCommand = new AsyncCommand<Review>(Remove);
        }

        async Task Add()
        {
            var username = await App.Current.MainPage.DisplayPromptAsync("Username", "Username for review");
            var stars = await App.Current.MainPage.DisplayPromptAsync("Stars", "Stars for review", maxLength: 1, keyboard: Keyboard.Numeric);
            var text = await App.Current.MainPage.DisplayPromptAsync("Text", "Add text", maxLength: 50);
            await ReviewServices.AddReview(username, Double.Parse(stars), text);
            await Refresh();
        }
        async Task Remove(Review review)
        {
            await ReviewServices.RemoveReview(review.Id);
            await Refresh();
        }

        async Task Refresh()
        {
            IsBusy = true;

            await Task.Delay(2000);

            Review.Clear();

            var reviews = await ReviewServices.GetReview();

            Review.AddRange(reviews);

            IsBusy = false;
        }

    }
}
