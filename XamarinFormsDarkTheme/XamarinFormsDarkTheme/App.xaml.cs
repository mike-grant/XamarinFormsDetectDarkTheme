using Xamarin.Essentials;
using Xamarin.Forms;
using XamarinFormsDarkTheme.Services;
using XamarinFormsDarkTheme.Styles;
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
            Xamarin.Essentials.AppTheme theme = AppInfo.RequestedTheme;
            switch (theme)
            {
                case Xamarin.Essentials.AppTheme.Dark:
                    AppTheme = "dark";
                    Current.Resources = new DarkTheme();
                    break;
                case Xamarin.Essentials.AppTheme.Light:
                    AppTheme = "light";
                    Current.Resources = new LightTheme();
                    break;
                default:
                    AppTheme = "light";
                    Current.Resources = new LightTheme();
                    break;
            }
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
