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
    public partial class Anasayfa : ContentPage
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void btnilerleme_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ilerlemeli());
        }

        private void btnpuanbitisli_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new PuanBitisli());
        }

        private void btnArtan_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ArtanIslem());
        }

        private void btnSecenekli_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Secenekli());
        }

        private void btnSureli_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SureliSecenekli());
        }
    }
}