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
    public partial class ArtanIslem : ContentPage
    {
        public void olumluRenk()
        {
            lblPuan.BackgroundColor = Color.FromHex("05c116");
            lblPuan.TextColor = Color.White;
        }
        public void olumsuzRenk()
        {
            lblPuan.BackgroundColor = Color.Red;
            lblPuan.TextColor = Color.White;
        }

        Random rnd = new Random();
        Random karisik = new Random();
        double a;
        double b;
        double c;
        double k = 1;

        int puan;
        public ArtanIslem()
        {
            InitializeComponent();
            a = rnd.Next(1, 11);
            sayi1.Text = k.ToString();
            sayi2.Text = a.ToString();
            c = k + a;
        }

        public void metod()
        {
            a = rnd.Next(1, 11);
            sayi1.Text = c.ToString();
            sayi2.Text = a.ToString();
            c = a + c;

        }
        public void metod2()
        {
            a = rnd.Next(10, 30);
            sayi1.Text = c.ToString();
            sayi2.Text = a.ToString();
            c = a + c;

        }
        public void metod3()
        {
            a = rnd.Next(30, 60);
            sayi1.Text = c.ToString();
            sayi2.Text = a.ToString();
            c = a + c;

        }
        public void metod4()
        {
            a = rnd.Next(60, 100);
            sayi1.Text = c.ToString();
            sayi2.Text = a.ToString();
            c = a + c;

        }

        private void btntekrar_Clicked(object sender, EventArgs e)
        {
            lblPuan.Text = "Puan : " + puan.ToString();

            lblPuan.BackgroundColor = Color.FromHex("049CFF");
            lblPuan.TextColor = Color.White;

            btnArtan.IsVisible = true;
            btntekrar.IsVisible = false;
            btnCikis.IsVisible = false;
            lblArti.IsVisible = true;
            lblSonuc.IsVisible = true;
            btn0.IsVisible = true;
            btn1.IsVisible = true;
            btn2.IsVisible = true;
            btn3.IsVisible = true;
            btn4.IsVisible = true;
            btn5.IsVisible = true;
            btn6.IsVisible = true;
            btn7.IsVisible = true;
            btn8.IsVisible = true;
            btn9.IsVisible = true;
            btnSil.IsVisible = true;
            btnVirgul.IsVisible = false;
            btnEksi.IsVisible = false;
            sayi1.IsVisible = true;
            sayi2.IsVisible = true;
            lblEsittir.IsVisible = true;

            if (puan <= 80)
            {
                metod();
            }
            else if (puan > 80)
            {
                metod2();
            }
            else if (puan >= 150)
            {
                metod3();
            }
            else if (puan >= 250)
            {
                metod4();
            }
        }

        private void btnCikis_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void btnArtan_Clicked(object sender, EventArgs e)
        {
            if (c.ToString() == lblSonuc.Text)
            {
                puan += 10;
                lblPuan.Text = "Puan : " + puan.ToString();
                olumluRenk();

                if (puan <= 80)
                {
                    metod();
                }
                else if (puan > 80)
                {
                    metod2();
                }
                else if (puan >= 150)
                {
                    metod3();
                }
                else if (puan >= 250)
                {
                    metod4();
                }
                lblSonuc.Text = "";
            }
            else if (c.ToString() != lblSonuc.Text)
            {
                olumsuzRenk();
                lblPuan.Text = "Oyun Bitti!!! \nPuan : " + puan.ToString();
                puan = 0;
                c = 1;
                sayi1.Text = c.ToString();
                lblEksi.IsVisible = false;
                btntekrar.IsVisible = true;
                lblCarpma.IsVisible = false;
                btnCikis.IsVisible = true;
                lblBolme.IsVisible = false;
                btnArtan.IsVisible = false;
                lblArti.IsVisible = false;
                lblSonuc.IsVisible = true;
                btn0.IsVisible = false;
                btn1.IsVisible = false;
                btn2.IsVisible = false;
                btn3.IsVisible = false;
                btn4.IsVisible = false;
                btn5.IsVisible = false;
                btn6.IsVisible = false;
                btn7.IsVisible = false;
                btn8.IsVisible = false;
                btn9.IsVisible = false;
                btnSil.IsVisible = false;
                btnEksi.IsVisible = false;
                btnVirgul.IsVisible = false;

                sayi1.IsVisible = false;
                sayi2.IsVisible = false;
                lblEsittir.IsVisible = false;
                lblSonuc.Text = "";

            }
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            lblSonuc.Text += "1";
        }

        private void btn2_Clicked(object sender, EventArgs e)
        {
            lblSonuc.Text += "2";
        }

        private void btn3_Clicked(object sender, EventArgs e)
        {
            lblSonuc.Text += "3";
        }

        private void btn4_Clicked(object sender, EventArgs e)
        {
            lblSonuc.Text += "4";
        }

        private void btn5_Clicked(object sender, EventArgs e)
        {
            lblSonuc.Text += "5";
        }

        private void btn6_Clicked(object sender, EventArgs e)
        {
            lblSonuc.Text += "6";
        }

        private void btn7_Clicked(object sender, EventArgs e)
        {
            lblSonuc.Text += "7";
        }

        private void btn8_Clicked(object sender, EventArgs e)
        {
            lblSonuc.Text += "8";
        }

        private void btn9_Clicked(object sender, EventArgs e)
        {
            lblSonuc.Text += "9";
        }

        private void btn0_Clicked(object sender, EventArgs e)
        {
            lblSonuc.Text += "0";
        }

        private void btnSil_Clicked(object sender, EventArgs e)
        {
            lblSonuc.Text = "";
        }

        private void btnEksi_Clicked(object sender, EventArgs e)
        {
            lblSonuc.Text += "-";
        }

        private void btnVirgul_Clicked(object sender, EventArgs e)
        {
            lblSonuc.Text += ",";
        }
    }
}