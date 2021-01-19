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
    public partial class Secenekli : ContentPage
    {
        public Secenekli()
        {
            InitializeComponent();
        }

        private void btnToplama_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Toplama3());
        }

        private void btnCikarma_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Cikarma3());
        }

        private void btnCarpma_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Carpma3());
        }

        private void btnBolme_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Bolme3());
        }

        private void btnKarisik_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Karisik3());
        }
    }
}