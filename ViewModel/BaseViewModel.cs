using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;

namespace iPantherToilets.ViewModel
{
    public partial class BaseViewModel : ObservableObject
    {
        public BaseViewModel() 
        { 
        
        }

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        bool isBusy;

        [ObservableProperty]
        string title;

        bool IsNotBusy => !IsBusy;
    }
}
