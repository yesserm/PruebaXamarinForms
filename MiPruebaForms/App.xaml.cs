using MiPruebaForms.Services;
using MiPruebaForms.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace MiPruebaForms
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            AppCenter.Start("ios=72f150a9-8593-4a58-a4e3-9dc9db3dffaa;" +
                  "uwp=72f150a9-8593-4a58-a4e3-9dc9db3dffab;" +
                  "android=72f150a9-8593-4a58-a4e3-9dc9db3dffac;",
                  typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
