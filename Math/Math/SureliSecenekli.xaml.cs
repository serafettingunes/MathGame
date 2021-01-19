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
    public partial class SureliSecenekli : ContentPage
    {
        public SureliSecenekli()
        {
            InitializeComponent();
        }

        private void btnToplama4_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Toplama4());
        }

        private void btnCikarma4_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Cikarma4());
        }

        private void btnCarpma4_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Carpma4());
        }

        private void btnBolme4_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Bolme4());
        }

        private void btnKarisik4_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Karisik4());
        }
    }
}