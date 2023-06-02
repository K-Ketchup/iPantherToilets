using iPantherToilets.Models;
using MvvmHelpers;
using MvvmHelpers.Commands;
using MyCoffeeApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iPantherToilets.ViewModel
{
    public class MyReviewViewModel : ViewModelBase
    {
        public ObservableRangeCollection<Review> Review { get; set; }
        public AsyncCommand RefreshCommand { get; }
        public AsyncCommand AddCommand { get; }
        public AsyncCommand<Review> RemoveCommand { get; }

    }
}
