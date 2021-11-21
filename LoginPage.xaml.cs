using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        void OnLoginButtonClicked(object sender, EventArgs e)
        {
            if (DataBase.CheckPassword(login.Text, password.Text))
            {
                Application.Current.MainPage = new MainPage();
                App.Login = true;
            }
        }
    }
}