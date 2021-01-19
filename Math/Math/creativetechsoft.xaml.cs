using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Math
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class creativetechsoft : ContentPage
    {
        public creativetechsoft()
        {
            InitializeComponent();
            timer(3);
        }
        public void timer(double time)
        {

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                time -= 1;
                if (time == 0)
                {
                    Navigation.PushModalAsync(new Anasayfa());
                    return false;
                }
                else
                {
                    return true;
                }

            }

            );
        }
    }
}