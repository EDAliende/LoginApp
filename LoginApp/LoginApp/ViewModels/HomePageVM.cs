using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoginApp.ViewModels
{
    public class HomePageVM: BaseViewModel
    {
        string _UserName;

        public string UserName
        {
            get => _UserName;
            set => SetProperty(ref _UserName, value);
        }

    }
}
