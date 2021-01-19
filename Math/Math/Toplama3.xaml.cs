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
    public partial class Toplama3 : ContentPage
    {

        Random rnd = new Random();
        int a;
        int b;
        int c;
        int puan;
        int k;
        int aktif;
        int r;
        public Toplama3()
        {
            InitializeComponent();
            metod1();
        }

        public void metod1()
        {
            r = rnd.Next(1, 10);
            k = rnd.Next(1, 5);
            a = rnd.Next(1, 11);
            b = rnd.Next(1, 11);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a + b;
            if (k == 1)
            {

                aktif = 1;
                btn1.Text = c.ToString();
                btn2.Text = (c + r).ToString();
                btn3.Text = (c - r).ToString();
                btn4.Text = (c + r + 3).ToString();

            }
            else if (k == 2)
            {
                aktif = 2;
                btn2.Text = c.ToString();
                btn1.Text = (c + r).ToString();

                btn3.Text = (c - 10).ToString();
                btn4.Text = (c + r + 3).ToString();

            }
            else if (k == 3)
            {
                aktif = 3;
                btn3.Text = c.ToString();
                btn4.Text = (c - r).ToString();
                btn1.Text = (c + r + 3).ToString();
                btn2.Text = (c + r).ToString();
            }
            else if (k == 4)
            {
                aktif = 4;
                btn4.Text = c.ToString();
                btn3.Text = (c - r).ToString();
                btn1.Text = (c + r + 3).ToString();
                btn2.Text = (c + r).ToString();

            }

        }

        public void metod2()
        {
            r = rnd.Next(1, 10);
            k = rnd.Next(1, 5);
            a = rnd.Next(10, 50);
            b = rnd.Next(10, 50);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a + b;
            if (k == 1)
            {

                aktif = 1;
                btn1.Text = c.ToString();
                btn2.Text = (c + r).ToString();
                btn3.Text = (c - 10).ToString();
                btn4.Text = (c + r + 3).ToString();

            }
            else if (k == 2)
            {
                aktif = 2;
                btn2.Text = c.ToString();
                btn1.Text = (c + r).ToString();

                btn3.Text = (c - 10).ToString();
                btn4.Text = (c + r + 3).ToString();

            }
            else if (k == 3)
            {
                aktif = 3;
                btn3.Text = c.ToString();
                btn4.Text = (c - 10).ToString();
                btn1.Text = (c + r + 3).ToString();
                btn2.Text = (c + r).ToString();
            }
            else if (k == 4)
            {
                aktif = 4;
                btn4.Text = c.ToString();
                btn3.Text = (c - 10).ToString();
                btn1.Text = (c + r + 3).ToString();
                btn2.Text = (c + r).ToString();

            }

        }

        public void metod3()
        {
            r = rnd.Next(1, 10);
            k = rnd.Next(1, 5);
            a = rnd.Next(50, 100);
            b = rnd.Next(50, 100);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a + b;
            if (k == 1)
            {

                aktif = 1;
                btn1.Text = c.ToString();
                btn2.Text = (c + r).ToString();
                btn3.Text = (c - 10).ToString();
                btn4.Text = (c + r + 3).ToString();

            }
            else if (k == 2)
            {
                aktif = 2;
                btn2.Text = c.ToString();
                btn1.Text = (c + r).ToString();

                btn3.Text = (c - 10).ToString();
                btn4.Text = (c + r + 3).ToString();

            }
            else if (k == 3)
            {
                aktif = 3;
                btn3.Text = c.ToString();
                btn4.Text = (c - 10).ToString();
                btn1.Text = (c + r + 3).ToString();
                btn2.Text = (c + r).ToString();
            }
            else if (k == 4)
            {
                aktif = 4;
                btn4.Text = c.ToString();
                btn3.Text = (c - 10).ToString();
                btn1.Text = (c + r + 3).ToString();
                btn2.Text = (c + r).ToString();

            }

        }

        public void metod4()
        {
            r = rnd.Next(1, 10);
            k = rnd.Next(1, 5);
            a = rnd.Next(150, 500);
            b = rnd.Next(150, 500);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a + b;
            if (k == 1)
            {

                aktif = 1;
                btn1.Text = c.ToString();
                btn2.Text = (c + r).ToString();
                btn3.Text = (c - 10).ToString();
                btn4.Text = (c + r + 3).ToString();

            }
            else if (k == 2)
            {
                aktif = 2;
                btn2.Text = c.ToString();
                btn1.Text = (c + r).ToString();

                btn3.Text = (c - 10).ToString();
                btn4.Text = (c + r + 3).ToString();

            }
            else if (k == 3)
            {
                aktif = 3;
                btn3.Text = c.ToString();
                btn4.Text = (c - 10).ToString();
                btn1.Text = (c + r + 3).ToString();
                btn2.Text = (c + r).ToString();
            }
            else if (k == 4)
            {
                aktif = 4;
                btn4.Text = c.ToString();
                btn3.Text = (c - 10).ToString();
                btn1.Text = (c + r + 3).ToString();
                btn2.Text = (c + r).ToString();

            }

        }

        public void metod5()
        {
            r = rnd.Next(1, 10);
            k = rnd.Next(1, 5);
            a = rnd.Next(500, 1000);
            b = rnd.Next(500, 1000);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a + b;
            if (k == 1)
            {

                aktif = 1;
                btn1.Text = c.ToString();
                btn2.Text = (c + r).ToString();
                btn3.Text = (c - 10).ToString();
                btn4.Text = (c + r + 3).ToString();

            }
            else if (k == 2)
            {
                aktif = 2;
                btn2.Text = c.ToString();
                btn1.Text = (c + r).ToString();

                btn3.Text = (c - 10).ToString();
                btn4.Text = (c + r + 3).ToString();

            }
            else if (k == 3)
            {
                aktif = 3;
                btn3.Text = c.ToString();
                btn4.Text = (c - 10).ToString();
                btn1.Text = (c + r + 3).ToString();
                btn2.Text = (c + r).ToString();
            }
            else if (k == 4)
            {
                aktif = 4;
                btn4.Text = c.ToString();
                btn3.Text = (c - 10).ToString();
                btn1.Text = (c + r + 3).ToString();
                btn2.Text = (c + r).ToString();

            }

        }

        public void metod6()
        {
            r = rnd.Next(1, 10);
            k = rnd.Next(1, 5);
            a = rnd.Next(1000, 5000);
            b = rnd.Next(1000, 5000);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a + b;
            if (k == 1)
            {

                aktif = 1;
                btn1.Text = c.ToString();
                btn2.Text = (c + r).ToString();
                btn3.Text = (c - 100).ToString();
                btn4.Text = (c + r + 3).ToString();

            }
            else if (k == 2)
            {
                aktif = 2;
                btn2.Text = c.ToString();
                btn1.Text = (c + r).ToString();

                btn3.Text = (c - 100).ToString();
                btn4.Text = (c + r + 3).ToString();

            }
            else if (k == 3)
            {
                aktif = 3;
                btn3.Text = c.ToString();
                btn4.Text = (c - 100).ToString();
                btn1.Text = (c + r + 3).ToString();
                btn2.Text = (c + r).ToString();
            }
            else if (k == 4)
            {
                aktif = 4;
                btn4.Text = c.ToString();
                btn3.Text = (c - 100).ToString();
                btn1.Text = (c + r + 3).ToString();
                btn2.Text = (c + r).ToString();

            }

        }

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

            if (puan < 150)
            {
                metod1();
            }
            else if (puan >= 150 && puan <= 250)
            {
                metod2();
            }
            else if (puan >= 250 && puan <= 500)
            {
                metod3();
            }
            else if (puan >= 500 && puan <= 750)
            {
                metod4();
            }
            else if (puan >= 750 && puan <= 1000)
            {
                metod5();
            }
            else if (puan > 1000)
            {
                metod6();
            }
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


            if (puan < 150)
            {
                metod1();
            }
            else if (puan >= 150 && puan <= 250)
            {
                metod2();
            }
            else if (puan >= 250 && puan <= 500)
            {
                metod3();
            }
            else if (puan >= 500 && puan <= 750)
            {
                metod4();
            }
            else if (puan >= 750 && puan <= 1000)
            {
                metod5();
            }
            else if (puan > 1000)
            {
                metod6();
            }
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
            if (puan < 150)
            {
                metod1();
            }
            else if (puan >= 150 && puan <= 250)
            {
                metod2();
            }
            else if (puan >= 250 && puan <= 500)
            {
                metod3();
            }
            else if (puan >= 500 && puan <= 750)
            {
                metod4();
            }
            else if (puan >= 750 && puan <= 1000)
            {
                metod5();
            }
            else if (puan > 1000)
            {
                metod6();
            }
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

            if (puan < 150)
            {
                metod1();
            }
            else if (puan >= 150 && puan <= 250)
            {
                metod2();
            }
            else if (puan >= 250 && puan <= 500)
            {
                metod3();
            }
            else if (puan >= 500 && puan <= 750)
            {
                metod4();
            }
            else if (puan >= 750 && puan <= 1000)
            {
                metod5();
            }
            else if (puan > 1000)
            {
                metod6();
            }
        }
    }
}