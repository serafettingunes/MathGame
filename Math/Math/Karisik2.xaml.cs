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
    public partial class Karisik2 : ContentPage
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
        Random karisik = new Random();
        double a;
        double b;
        double c;
        int puan;
        int k;

        public Karisik2()
        {
            InitializeComponent();
            btnKarisik.IsVisible = true;
            islemler();
        }

        public void islemler()
        {
            sayi1.IsVisible = true;
            sayi2.IsVisible = true;
            k = karisik.Next(1, 29);
            if (k == 1)
            {
                lblCarpma.IsVisible = true;
                lblArti.IsVisible = false;
                lblBolme.IsVisible = false;
                lblEksi.IsVisible = false;
                btnVirgul.IsVisible = false;
                btnEksi.IsVisible = false;
                m1();

            }
            else if (k == 2)
            {
                btnEksi.IsVisible = false;
                lblCarpma.IsVisible = true;
                lblArti.IsVisible = false;
                lblBolme.IsVisible = false;
                lblEksi.IsVisible = false;
                btnVirgul.IsVisible = false;
                m2();
            }
            else if (k == 3)
            {
                btnEksi.IsVisible = false;
                lblCarpma.IsVisible = true;
                lblArti.IsVisible = false;
                lblBolme.IsVisible = false;
                lblEksi.IsVisible = false;
                btnVirgul.IsVisible = false;
                m3();

            }
            else if (k == 4)
            {
                btnEksi.IsVisible = false;
                lblCarpma.IsVisible = true;
                lblArti.IsVisible = false;
                lblBolme.IsVisible = false;
                lblEksi.IsVisible = false;
                btnVirgul.IsVisible = false;
                m4();
            }

            else if (k == 5)
            {
                btnEksi.IsVisible = false;
                lblCarpma.IsVisible = true;
                lblArti.IsVisible = false;
                lblBolme.IsVisible = false;
                lblEksi.IsVisible = false;
                btnVirgul.IsVisible = false;
                m4();
            }
            else if (k == 6)
            {
                lblArti.IsVisible = false;
                lblCarpma.IsVisible = false;
                lblEksi.IsVisible = false;
                btnVirgul.IsVisible = true;
                lblBolme.IsVisible = true;
                m10();
            }
            else if (k == 7)
            {
                lblArti.IsVisible = false;
                lblCarpma.IsVisible = false;
                lblEksi.IsVisible = false;
                btnVirgul.IsVisible = true;
                lblBolme.IsVisible = true;
                m10();
            }
            else if (k == 8)
            {
                btnEksi.IsVisible = false;
                lblArti.IsVisible = false;
                lblCarpma.IsVisible = false;
                lblEksi.IsVisible = false;
                lblBolme.IsVisible = true;
                btnVirgul.IsVisible = true;
                m8();

            }
            else if (k == 9)
            {
                btnEksi.IsVisible = false;
                lblArti.IsVisible = false;
                lblCarpma.IsVisible = false;
                lblEksi.IsVisible = false;
                btnVirgul.IsVisible = true;
                lblBolme.IsVisible = true;
                m9();
            }
            else if (k == 10)
            {
                btnEksi.IsVisible = false;
                lblArti.IsVisible = false;
                lblCarpma.IsVisible = false;
                lblEksi.IsVisible = false;
                btnVirgul.IsVisible = true;
                lblBolme.IsVisible = true;
                m10();
            }
            else if (k == 11)
            {
                btnEksi.IsVisible = false;
                lblArti.IsVisible = false;
                lblCarpma.IsVisible = false;
                lblEksi.IsVisible = false;
                btnVirgul.IsVisible = true;
                lblBolme.IsVisible = true;
                m11();
            }
            else if (k == 12)
            {
                btnEksi.IsVisible = false;
                lblArti.IsVisible = false;
                lblCarpma.IsVisible = false;
                lblEksi.IsVisible = false;
                btnVirgul.IsVisible = true;
                lblBolme.IsVisible = true;
                m12();
            }
            else if (k == 13)
            {
                btnEksi.IsVisible = false;
                lblArti.IsVisible = false;
                lblCarpma.IsVisible = false;
                lblEksi.IsVisible = false;
                btnVirgul.IsVisible = true;
                lblBolme.IsVisible = true;
                m13();
            }
            else if (k == 14)
            {

                btnEksi.IsVisible = false;
                lblArti.IsVisible = false;
                lblCarpma.IsVisible = false;
                lblEksi.IsVisible = false;
                btnVirgul.IsVisible = true;
                lblBolme.IsVisible = true;
                m13();
            }

            else if (k == 15)
            {

                lblCarpma.IsVisible = false;
                lblBolme.IsVisible = false;
                lblEksi.IsVisible = false;
                lblArti.IsVisible = true;
                btnVirgul.IsVisible = false;
                m15();
            }
            else if (k == 16)
            {

                lblCarpma.IsVisible = false;
                lblBolme.IsVisible = false;
                lblEksi.IsVisible = false;
                lblArti.IsVisible = true;
                btnVirgul.IsVisible = false;
                m16();
            }
            else if (k == 17)
            {
                btnEksi.IsVisible = false;
                lblCarpma.IsVisible = false;
                lblBolme.IsVisible = false;
                lblEksi.IsVisible = false;
                lblArti.IsVisible = true;
                btnVirgul.IsVisible = false;
                m17();
            }
            else if (k == 18)
            {
                btnEksi.IsVisible = false;
                lblCarpma.IsVisible = false;
                lblBolme.IsVisible = false;
                lblEksi.IsVisible = false;
                lblArti.IsVisible = true;
                btnVirgul.IsVisible = false;
                m18();
            }
            else if (k == 19)
            {
                btnEksi.IsVisible = false;
                lblCarpma.IsVisible = false;
                lblBolme.IsVisible = false;
                lblEksi.IsVisible = false;
                lblArti.IsVisible = true;
                btnVirgul.IsVisible = false;
                m19();

            }
            else if (k == 20)
            {
                btnEksi.IsVisible = false;
                lblCarpma.IsVisible = false;
                lblBolme.IsVisible = false;
                lblEksi.IsVisible = false;
                lblArti.IsVisible = true;
                btnVirgul.IsVisible = false;
                m20();
            }
            else if (k == 21)
            {
                btnEksi.IsVisible = false;
                btnVirgul.IsVisible = false;
                lblCarpma.IsVisible = false;
                lblBolme.IsVisible = false;
                lblEksi.IsVisible = false;
                lblArti.IsVisible = true;

                m21();
            }
            else if (k == 22)
            {
                btnVirgul.IsVisible = false;
                lblCarpma.IsVisible = false;
                lblBolme.IsVisible = false;
                lblArti.IsVisible = false;
                btnEksi.IsVisible = true;
                lblEksi.IsVisible = true;
                m22();
            }
            else if (k == 23)
            {
                btnVirgul.IsVisible = false;
                lblCarpma.IsVisible = false;
                lblBolme.IsVisible = false;
                lblArti.IsVisible = false;
                btnEksi.IsVisible = true;
                lblEksi.IsVisible = true;
                m23();
            }
            else if (k == 24)
            {
                btnVirgul.IsVisible = false;
                lblCarpma.IsVisible = false;
                lblBolme.IsVisible = false;
                lblArti.IsVisible = false;
                btnEksi.IsVisible = true;
                lblEksi.IsVisible = true;
                m24();
            }
            else if (k == 25)
            {
                lblCarpma.IsVisible = false;
                lblBolme.IsVisible = false;
                lblArti.IsVisible = false;
                btnEksi.IsVisible = true;
                lblEksi.IsVisible = true;
                btnVirgul.IsVisible = false;
                m25();

            }
            else if (k == 26)
            {
                btnVirgul.IsVisible = false;
                lblCarpma.IsVisible = false;
                lblBolme.IsVisible = false;
                lblArti.IsVisible = false;
                btnEksi.IsVisible = true;
                lblEksi.IsVisible = true;
                m26();
            }
            else if (k == 27)
            {
                lblCarpma.IsVisible = false;
                lblBolme.IsVisible = false;
                lblArti.IsVisible = false;
                btnEksi.IsVisible = true;
                lblEksi.IsVisible = true;
                btnVirgul.IsVisible = false;
                m27();
            }
            else if (k == 28)
            {
                lblCarpma.IsVisible = false;
                lblBolme.IsVisible = false;
                lblArti.IsVisible = false;
                btnEksi.IsVisible = true;
                lblEksi.IsVisible = true;
                btnVirgul.IsVisible = false;
                m28();
            }

        }

        public void m1()
        {

            a = rnd.Next(1, 5);
            b = rnd.Next(1, 5);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a * b;

        }

        public void m2()
        {

            a = rnd.Next(1, 10);
            b = rnd.Next(1, 10);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a * b;

        }
        public void m3()
        {

            a = rnd.Next(1, 15);
            b = rnd.Next(1, 15);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a * b;

        }
        public void m4()
        {

            a = rnd.Next(1, 20);
            b = rnd.Next(1, 20);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a * b;

        }




        public void m8()
        {

            a = rnd.Next(1, 7);
            b = rnd.Next(1, 3);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a / b;

        }

        public void m9()
        {

            a = rnd.Next(1, 10);
            b = rnd.Next(1, 3);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a / b;

        }
        public void m10()
        {

            a = rnd.Next(1, 20);
            b = rnd.Next(1, 3);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a / b;

        }
        public void m11()
        {

            a = rnd.Next(1, 50);
            b = rnd.Next(1, 3);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a / b;

        }
        public void m12()
        {

            a = rnd.Next(10, 100);
            b = rnd.Next(1, 3);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a / b;

        }
        public void m13()
        {

            a = rnd.Next(10, 500);
            b = rnd.Next(1, 3);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a / b;

        }




        public void m15()
        {

            a = rnd.Next(1, 10);
            b = rnd.Next(1, 10);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a + b;

        }

        public void m16()
        {

            a = rnd.Next(1, 20);
            b = rnd.Next(1, 20);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a + b;

        }
        public void m17()
        {

            a = rnd.Next(1, 30);
            b = rnd.Next(1, 30);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a + b;

        }
        public void m18()
        {

            a = rnd.Next(1, 50);
            b = rnd.Next(1, 50);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a + b;

        }
        public void m19()
        {

            a = rnd.Next(1, 70);
            b = rnd.Next(1, 70);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a + b;

        }
        public void m20()
        {

            a = rnd.Next(10, 100);
            b = rnd.Next(10, 100);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a + b;

        }


        public void m21()
        {

            a = rnd.Next(50, 200);
            b = rnd.Next(50, 200);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a + b;

        }
        public void m22()
        {

            a = rnd.Next(1, 10);
            b = rnd.Next(1, 10);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a - b;

        }

        public void m23()
        {

            a = rnd.Next(1, 20);
            b = rnd.Next(1, 20);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a - b;

        }
        public void m24()
        {

            a = rnd.Next(1, 30);
            b = rnd.Next(1, 30);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a - b;

        }
        public void m25()
        {

            a = rnd.Next(1, 50);
            b = rnd.Next(1, 50);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a - b;

        }
        public void m26()
        {

            a = rnd.Next(1, 100);
            b = rnd.Next(1, 100);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a - b;

        }
        public void m27()
        {

            a = rnd.Next(10, 100);
            b = rnd.Next(10, 100);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a - b;

        }


        public void m28()
        {

            a = rnd.Next(50, 200);
            b = rnd.Next(50, 200);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a - b;

        }


        private void btntekrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
            Navigation.PushModalAsync(new Karisik2());
        }

        private void btnCikis_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void btnKarisik_Clicked(object sender, EventArgs e)
        {
            if (lblSonuc.Text == c.ToString())
            {

                puan += 10;

                lblPuan.Text = "Puan : " + puan.ToString();
                olumluRenk();
                islemler();
            }
            else if (lblSonuc.Text != c.ToString())
            {
                olumsuzRenk();
                lblPuan.Text = "Oyun Bitti!!! \n Puan : " + puan.ToString();
                lblEksi.IsVisible = false;
                btntekrar.IsVisible = true;
                lblCarpma.IsVisible = false;
                btnCikis.IsVisible = true;
                lblBolme.IsVisible = false;
                btnKarisik.IsVisible = false;
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

                puan = 0;
            }
            lblSonuc.Text = "";

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