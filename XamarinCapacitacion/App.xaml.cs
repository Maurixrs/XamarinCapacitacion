using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCapacitacion.Views;

namespace XamarinCapacitacion
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new clase2();
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
