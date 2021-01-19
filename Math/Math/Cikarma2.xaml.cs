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
    public partial class Cikarma2 : ContentPage
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
        public void notrRenk()
        {
            lblPuan.BackgroundColor = Color.FromHex("049CFF");
            lblPuan.TextColor = Color.White;
        }




        Random rnd = new Random();
        int a;
        int b;
        int c;
        int puan;

        public Cikarma2()
        {
            InitializeComponent();
            btnCikarma2.IsVisible = true;
            metod1();
        }


        public void metod1()
        {

            a = rnd.Next(1, 10);
            b = rnd.Next(1, 10);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a - b;

        }

        public void metod2()
        {

            a = rnd.Next(1, 20);
            b = rnd.Next(1, 20);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a - b;

        }
        public void metod3()
        {

            a = rnd.Next(10, 50);
            b = rnd.Next(10, 50);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a - b;

        }
        public void metod4()
        {

            a = rnd.Next(10, 100);
            b = rnd.Next(10, 100);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a - b;

        }
        public void metod5()
        {

            a = rnd.Next(50, 200);
            b = rnd.Next(50, 200);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a - b;

        }
        public void metod6()
        {

            a = rnd.Next(100, 500);
            b = rnd.Next(100, 500);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a - b;

        }


        public void metod7()
        {

            a = rnd.Next(100, 1000);
            b = rnd.Next(100, 1000);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a - b;

        }

        private void btnCikarma2_Clicked(object sender, EventArgs e)
        {
            if (lblSonuc.Text == c.ToString())
            {

                puan += 10;

                lblPuan.Text = "Puan : " + puan.ToString();
                olumluRenk();

            }
            else if (lblSonuc.Text != c.ToString())
            {

                lblPuan.Text = "Oyun Bitti!!! \n Puan : " + puan.ToString();
                olumsuzRenk();
                btntekrar.IsVisible = true;
                btnCikis.IsVisible = true;
                lblEksi.IsVisible = false;
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
                btnCikarma2.IsVisible = false;
                sayi1.IsVisible = false;
                sayi2.IsVisible = false;
                lblEsittir.IsVisible = false;
                btnEksi.IsVisible = false;
                puan = 0;
            }
            lblSonuc.Text = "";
            if (puan < 100)
            {
                metod1();
            }

            else if (puan >= 100 && puan < 300)
            {
                metod2();
            }
            else if (puan >= 300 && puan < 500)
            {
                metod3();
            }
            else if (puan >= 500 && puan < 700)
            {
                metod4();
            }
            else if (puan >= 700 && puan < 900)
            {
                metod5();
            }
            else if (puan >= 900 && puan < 1100)
            {
                metod6();

            }
            else if (puan >= 1100)
            {
                metod7();
            }
        }

        private void btntekrar_Clicked(object sender, EventArgs e)
        {
            notrRenk();
            btntekrar.IsVisible = false;
            btnCikis.IsVisible = false;
            lblEksi.IsVisible = true;
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
            btnCikarma2.IsVisible = true;
            sayi1.IsVisible = true;
            sayi2.IsVisible = true;
            lblEsittir.IsVisible = true;
            btnEksi.IsVisible = true;
            lblPuan.Text = "Puan : " + puan.ToString();
        }

        private void btnCikis_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
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
    }
}