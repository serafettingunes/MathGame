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
    public partial class ilerlemeli : ContentPage
    {
        public ilerlemeli()
        {
            InitializeComponent();
        }

        private void btnToplama_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Toplama());
        }

        private void btnCikarma_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Cikarma1());
        }

        private void btnCarpma_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Carpma1());
        }

        private void btnBolme_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Bolme1());
        }

        private void btnKarisik_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Karisik());
        }
    }
}