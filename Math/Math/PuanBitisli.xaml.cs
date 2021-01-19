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
    public partial class PuanBitisli : ContentPage
    {
        public PuanBitisli()
        {
            InitializeComponent();
        }

        private void btnToplama_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Toplama2());
        }

        private void btnCikarma_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Cikarma2());
        }

        private void btnCarpma_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Carpma2());
        }

        private void btnBolme_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Bolme2());
        }

        private void btnKarisik_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Karisik2());
        }
    }
}