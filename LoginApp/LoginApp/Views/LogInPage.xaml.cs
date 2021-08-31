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
    public partial class LogInPage : ContentPage
    {
        LoginVM objVM;
        public LogInPage()
        {
            objVM = new LoginVM();
            InitializeComponent();
            BindingContext = objVM;
        }
    }
}