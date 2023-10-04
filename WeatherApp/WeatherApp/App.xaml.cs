using System;
using WeatherApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherApp
{   
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Navigation();
            //MainPage = new CurrentWeatherPage("Cao%20Lanh");
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
