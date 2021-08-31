using LoginApp.DataModels;
using LoginApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        HomePageVM objVM;
        public HomePage(UserMD inUser)
        {
            objVM = new HomePageVM();
            InitializeComponent();
            objVM.UserName = inUser.User;
            BindingContext = objVM;
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }


    }
}