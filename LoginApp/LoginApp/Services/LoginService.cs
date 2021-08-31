using LoginApp.DataModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace LoginApp.Services
{
    public class LoginService
    {
        bool _Status;
        string _ErrorMessage;

        public string ErrorMessage
        {
            get => _ErrorMessage;            
        }

        public bool Status
        {
            get => _Status;            
        }

        public async Task LaunchLogin(UserMD inUser)
        {
            await SecureStorage.SetAsync("UserName", "");

            await Task.Delay(TimeSpan.FromSeconds(5));

            if (!string.IsNullOrEmpty(inUser.User) && !string.IsNullOrEmpty(inUser.Pass))
            {
                await SecureStorage.SetAsync("UserName", inUser.User);

                _Status = true;
            }
            else
            {
                _ErrorMessage = "Error en datos de Usuario";
                _Status = false;

            }
            
        }
    }
}
