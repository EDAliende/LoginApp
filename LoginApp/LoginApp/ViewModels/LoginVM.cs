using LoginApp.DataModels;
using LoginApp.Services;
using LoginApp.Views;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoginApp.ViewModels
{
    public class LoginVM: BaseViewModel
    {
        string _User;
        string _Pass;
        public string User
        {
            get => _User;
            set => SetProperty(ref _User, value);
        }

        public string Pass
        {
            get => _Pass;
            set => SetProperty(ref _Pass, value);
        }
        public Command LoginCommand { get; }
        public LoginVM()
        {

            LoginCommand = new Command(async () => await LoginAsync());
        }

        private async Task LoginAsync()
        {
            IsBusy = true;
            IsNotBusy = false;
            var objUser = new UserMD();

            objUser.User = User;
            objUser.Pass = Pass;
            var objService = new LoginService();
            
            await objService.LaunchLogin(objUser);

            if (objService.Status)
            {
                Application.Current.MainPage = new NavigationPage(new HomePage(objUser));
            }
            else
                await App.Current.MainPage.DisplayAlert("Aviso", objService.ErrorMessage, "OK");

        



            IsBusy = false;
            IsNotBusy = true;
        }
    }
}
