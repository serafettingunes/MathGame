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
    public partial class Carpma3 : ContentPage
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
        int k;
        int aktif;
        int r;
        public Carpma3()
        {
            InitializeComponent();
            metod1();

        }

        public void metod1()
        {
            r = rnd.Next(1, 10);
            k = rnd.Next(1, 5);
            a = rnd.Next(1, 5);
            b = rnd.Next(1, 5);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a * b;
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
            a = rnd.Next(1, 10);
            b = rnd.Next(1, 10);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a * b;
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
            a = rnd.Next(3, 10);
            b = rnd.Next(3, 10);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a * b;
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
            a = rnd.Next(5, 10);
            b = rnd.Next(5, 10);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a * b;
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
            a = rnd.Next(5, 15);
            b = rnd.Next(5, 15);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a * b;
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
            a = rnd.Next(10, 21);
            b = rnd.Next(10, 21);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a * b;
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