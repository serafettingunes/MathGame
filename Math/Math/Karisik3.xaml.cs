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
    public partial class Karisik3 : ContentPage
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


        Random karisik = new Random();
        Random rnd = new Random();
        double a;
        double b;
        double c;
        int puan;
        int k, k2;
        int aktif;
        int r;


        public void metodBtnAktif()
        {
            r = rnd.Next(1, 9);
            k2 = rnd.Next(1, 5);
            if (k2 == 1)
            {

                aktif = 1;
                btn1.Text = c.ToString();
                btn2.Text = (c + r).ToString();
                btn3.Text = (c - r).ToString();
                btn4.Text = (c + r + 3).ToString();

            }
            else if (k2 == 2)
            {
                aktif = 2;
                btn2.Text = c.ToString();
                btn1.Text = (c + r).ToString();

                btn3.Text = (c - 10).ToString();
                btn4.Text = (c + r + 3).ToString();

            }
            else if (k2 == 3)
            {
                aktif = 3;
                btn3.Text = c.ToString();
                btn4.Text = (c - r).ToString();
                btn1.Text = (c + r + 3).ToString();
                btn2.Text = (c + r).ToString();
            }
            else if (k2 == 4)
            {
                aktif = 4;
                btn4.Text = c.ToString();
                btn3.Text = (c - r).ToString();
                btn1.Text = (c + r + 3).ToString();
                btn2.Text = (c + r).ToString();

            }
        }

        public void islemler()
        {

            k = karisik.Next(1, 29);
            if (k == 1)
            {
                lblCarpma.IsVisible = true;
                lblArti.IsVisible = false;
                lblBolme.IsVisible = false;
                lblEksi.IsVisible = false;

                m1();

            }
            else if (k == 2)
            {

                lblCarpma.IsVisible = true;
                lblArti.IsVisible = false;
                lblBolme.IsVisible = false;
                lblEksi.IsVisible = false;

                m2();
            }
            else if (k == 3)
            {

                lblCarpma.IsVisible = true;
                lblArti.IsVisible = false;
                lblBolme.IsVisible = false;
                lblEksi.IsVisible = false;

                m3();

            }
            else if (k == 4)
            {

                lblCarpma.IsVisible = true;
                lblArti.IsVisible = false;
                lblBolme.IsVisible = false;
                lblEksi.IsVisible = false;

                m4();
            }

            else if (k == 5)
            {

                lblCarpma.IsVisible = true;
                lblArti.IsVisible = false;
                lblBolme.IsVisible = false;
                lblEksi.IsVisible = false;

                m4();
            }
            else if (k == 6)
            {

                lblArti.IsVisible = false;
                lblCarpma.IsVisible = false;
                lblEksi.IsVisible = false;
                lblBolme.IsVisible = true;

                m8();

            }
            else if (k == 7)
            {

                lblCarpma.IsVisible = false;
                lblBolme.IsVisible = false;
                lblEksi.IsVisible = false;
                lblArti.IsVisible = true;

                m16();
            }
            else if (k == 8)
            {

                lblArti.IsVisible = false;
                lblCarpma.IsVisible = false;
                lblEksi.IsVisible = false;
                lblBolme.IsVisible = true;

                m8();

            }
            else if (k == 9)
            {

                lblArti.IsVisible = false;
                lblCarpma.IsVisible = false;
                lblEksi.IsVisible = false;

                lblBolme.IsVisible = true;
                m9();
            }
            else if (k == 10)
            {

                lblArti.IsVisible = false;
                lblCarpma.IsVisible = false;
                lblEksi.IsVisible = false;

                lblBolme.IsVisible = true;
                m10();
            }
            else if (k == 11)
            {

                lblArti.IsVisible = false;
                lblCarpma.IsVisible = false;
                lblEksi.IsVisible = false;

                lblBolme.IsVisible = true;
                m11();
            }
            else if (k == 12)
            {

                lblArti.IsVisible = false;
                lblCarpma.IsVisible = false;
                lblEksi.IsVisible = false;

                lblBolme.IsVisible = true;
                m12();
            }
            else if (k == 13)
            {

                lblArti.IsVisible = false;
                lblCarpma.IsVisible = false;
                lblEksi.IsVisible = false;

                lblBolme.IsVisible = true;
                m13();
            }
            else if (k == 14)
            {

                lblCarpma.IsVisible = false;
                lblBolme.IsVisible = false;
                lblEksi.IsVisible = false;
                lblArti.IsVisible = true;

                m15();
            }
            else if (k == 15)
            {

                lblCarpma.IsVisible = false;
                lblBolme.IsVisible = false;
                lblEksi.IsVisible = false;
                lblArti.IsVisible = true;

                m15();
            }
            else if (k == 16)
            {

                lblCarpma.IsVisible = false;
                lblBolme.IsVisible = false;
                lblEksi.IsVisible = false;
                lblArti.IsVisible = true;

                m16();
            }
            else if (k == 17)
            {

                lblCarpma.IsVisible = false;
                lblBolme.IsVisible = false;
                lblEksi.IsVisible = false;
                lblArti.IsVisible = true;

                m17();
            }
            else if (k == 18)
            {

                lblCarpma.IsVisible = false;
                lblBolme.IsVisible = false;
                lblEksi.IsVisible = false;
                lblArti.IsVisible = true;

                m18();
            }
            else if (k == 19)
            {

                lblCarpma.IsVisible = false;
                lblBolme.IsVisible = false;
                lblEksi.IsVisible = false;
                lblArti.IsVisible = true;

                m19();

            }
            else if (k == 20)
            {

                lblCarpma.IsVisible = false;
                lblBolme.IsVisible = false;
                lblEksi.IsVisible = false;
                lblArti.IsVisible = true;

                m20();
            }
            else if (k == 21)
            {


                lblCarpma.IsVisible = false;
                lblBolme.IsVisible = false;
                lblEksi.IsVisible = false;
                lblArti.IsVisible = true;

                m21();
            }
            else if (k == 22)
            {

                lblCarpma.IsVisible = false;
                lblBolme.IsVisible = false;
                lblArti.IsVisible = false;

                lblEksi.IsVisible = true;
                m22();
            }
            else if (k == 23)
            {

                lblCarpma.IsVisible = false;
                lblBolme.IsVisible = false;
                lblArti.IsVisible = false;

                lblEksi.IsVisible = true;
                m23();
            }
            else if (k == 24)
            {

                lblCarpma.IsVisible = false;
                lblBolme.IsVisible = false;
                lblArti.IsVisible = false;

                lblEksi.IsVisible = true;
                m24();
            }
            else if (k == 25)
            {
                lblCarpma.IsVisible = false;
                lblBolme.IsVisible = false;
                lblArti.IsVisible = false;

                lblEksi.IsVisible = true;
                m25();

            }
            else if (k == 26)
            {

                lblCarpma.IsVisible = false;
                lblBolme.IsVisible = false;
                lblArti.IsVisible = false;

                lblEksi.IsVisible = true;
                m26();
            }
            else if (k == 27)
            {
                lblCarpma.IsVisible = false;
                lblBolme.IsVisible = false;
                lblArti.IsVisible = false;

                lblEksi.IsVisible = true;

                m27();
            }
            else if (k == 28)
            {
                lblCarpma.IsVisible = false;
                lblBolme.IsVisible = false;
                lblArti.IsVisible = false;

                lblEksi.IsVisible = true;

                m28();
            }

        }
        Random rnd2 = new Random();
        int l, m;
        public void rndMetod()
        {
            l = rnd2.Next(1, 7);
            m = rnd2.Next(1, 7);

        }

        public void m1()
        {
            rndMetod();

            a = rnd.Next(1, 5);
            b = rnd.Next(1, 5);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();

            c = a * b;
            metodBtnAktif();

        }

        public void m2()
        {
            rndMetod();
            a = rnd.Next(1, 10);
            b = rnd.Next(1, 10);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a * b;
            metodBtnAktif();
        }
        public void m3()
        {
            rndMetod();
            a = rnd.Next(1, 15);
            b = rnd.Next(1, 15);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a * b;
            metodBtnAktif();
        }
        public void m4()
        {
            rndMetod();
            a = rnd.Next(1, 20);
            b = rnd.Next(1, 20);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a * b;
            metodBtnAktif();
        }




        public void m8()
        {
            rndMetod();
            a = rnd.Next(1, 7);
            b = rnd.Next(1, 3);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a / b;
            metodBtnAktif();
        }

        public void m9()
        {
            rndMetod();
            a = rnd.Next(1, 10);
            b = rnd.Next(1, 3);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a / b;
            metodBtnAktif();
        }
        public void m10()
        {
            rndMetod();
            a = rnd.Next(1, 20);
            b = rnd.Next(1, 3);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a / b;
            metodBtnAktif();
        }
        public void m11()
        {
            rndMetod();
            a = rnd.Next(1, 50);
            b = rnd.Next(1, 3);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a / b;
            metodBtnAktif();
        }
        public void m12()
        {
            rndMetod();
            a = rnd.Next(10, 100);
            b = rnd.Next(1, 3);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a / b;
            metodBtnAktif();
        }
        public void m13()
        {
            rndMetod();
            a = rnd.Next(10, 500);
            b = rnd.Next(100, 101);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a / b;
            metodBtnAktif();
        }




        public void m15()
        {
            rndMetod();
            a = rnd.Next(1, 10);
            b = rnd.Next(1, 10);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a + b;
            metodBtnAktif();
        }

        public void m16()
        {
            rndMetod();
            a = rnd.Next(1, 20);
            b = rnd.Next(1, 20);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a + b;
            metodBtnAktif();
        }
        public void m17()
        {
            rndMetod();
            a = rnd.Next(1, 30);
            b = rnd.Next(1, 30);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a + b;
            metodBtnAktif();
        }
        public void m18()
        {
            rndMetod();
            a = rnd.Next(10, 50);
            b = rnd.Next(10, 50);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a + b;
            metodBtnAktif();
        }
        public void m19()
        {
            rndMetod();
            a = rnd.Next(10, 100);
            b = rnd.Next(10, 100);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a + b;
            metodBtnAktif();
        }
        public void m20()
        {
            rndMetod();
            a = rnd.Next(50, 500);
            b = rnd.Next(50, 500);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a + b;
            metodBtnAktif();
        }


        public void m21()
        {
            rndMetod();
            a = rnd.Next(100, 500);
            b = rnd.Next(100, 500);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a + b;
            metodBtnAktif();
        }
        public void m22()
        {
            rndMetod();
            a = rnd.Next(1, 10);
            b = rnd.Next(1, 10);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a - b;
            metodBtnAktif();
        }

        public void m23()
        {
            rndMetod();
            a = rnd.Next(1, 20);
            b = rnd.Next(1, 20);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a - b;
            metodBtnAktif();
        }
        public void m24()
        {
            rndMetod();
            a = rnd.Next(10, 50);
            b = rnd.Next(10, 50);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a - b;
            metodBtnAktif();
        }
        public void m25()
        {
            rndMetod();
            a = rnd.Next(10, 100);
            b = rnd.Next(10, 100);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a - b;
            metodBtnAktif();
        }
        public void m26()
        {
            rndMetod();
            a = rnd.Next(50, 200);
            b = rnd.Next(50, 200);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a - b;
            metodBtnAktif();
        }
        public void m27()
        {
            rndMetod();
            a = rnd.Next(50, 500);
            b = rnd.Next(50, 500);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a - b;
            metodBtnAktif();
        }


        public void m28()
        {
            rndMetod();
            a = rnd.Next(100, 500);
            b = rnd.Next(100, 500);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a - b;
            metodBtnAktif();
        }




        public Karisik3()
        {
            InitializeComponent();
            islemler();
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            if (c.ToString() == btn1.Text)
            {
                puan += 10;
                lblPuan.Text = "Puan : " + puan.ToString();
                olumluRenk();
            }
            else if (c.ToString() != btn1.Text)
            {
                puan -= 10;
                lblPuan.Text = "Puan : " + puan.ToString();
                olumsuzRenk();
            }
            islemler();
        }

        private void btn2_Clicked(object sender, EventArgs e)
        {
            if (c.ToString() == btn2.Text)
            {
                puan += 10;
                lblPuan.Text = "Puan : " + puan.ToString();
                olumluRenk();
            }
            else if (c.ToString() != btn2.Text)
            {
                puan -= 10;
                lblPuan.Text = "Puan : " + puan.ToString();
                olumsuzRenk();
            }
            islemler();
        }
        private void btn3_Clicked(object sender, EventArgs e)
        {
            if (c.ToString() == btn3.Text)
            {
                puan += 10;
                lblPuan.Text = "Puan : " + puan.ToString();
                olumluRenk();
            }
            else if (c.ToString() != btn3.Text)
            {
                puan -= 10;
                lblPuan.Text = "Puan : " + puan.ToString();
                olumsuzRenk();
            }
            islemler();
        }

        private void btn4_Clicked(object sender, EventArgs e)
        {
            if (c.ToString() == btn4.Text)
            {
                puan += 10;
                lblPuan.Text = "Puan : " + puan.ToString();
                olumluRenk();
            }
            else if (c.ToString() != btn4.Text)
            {
                puan -= 10;
                lblPuan.Text = "Puan : " + puan.ToString();
                olumsuzRenk();
            }
            islemler();
        }
    }
}