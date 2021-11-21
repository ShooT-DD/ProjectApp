using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectApp
{
    public partial class App : Application
    {
        public static bool Login = false;
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
            //if(Login)
            //{
            //    MainPage = new MainPage();
            //}
            //else
            //{
            //    MainPage = new LoginPage();
            //}
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
