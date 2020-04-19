using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsDarkTheme.Services;
using XamarinFormsDarkTheme.Views;

namespace XamarinFormsDarkTheme
{
    public partial class App : Application
    {
        public static string AppTheme { get; set; }
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
