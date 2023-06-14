using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmHelpers;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;

namespace iPantherToilets.ViewModel
{
    [INotifyPropertyChanged]
    public partial class BaseViewModel
    {
        bool isBusy;
        string title;
    }
}
