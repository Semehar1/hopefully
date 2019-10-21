using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace hopefully
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new hopefully.Loginpage();//here we make our login page as the main page
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
