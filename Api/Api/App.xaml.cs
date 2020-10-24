using Api.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Api
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new YoutubePage();
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
