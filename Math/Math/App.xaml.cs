using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Math
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new creativetechsoft();
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
