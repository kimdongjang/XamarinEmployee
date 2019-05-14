using Autofac;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin_Employee.View.User;
using Microsoft.AppCenter.Push;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_Employee.View;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Xamarin_Employee
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new CreateUserPage());
        }

        protected override void OnStart()
        {
            AppCenter.Start("a1255898-2cd3-4b9e-b321-5f53e6373fc5", typeof(Push));
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
