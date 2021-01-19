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
    public partial class Karisik4 : ContentPage
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
        double a;
        double b;
        double c;
        int puan;
        int k;
        int aktif;
        int r;
        int tiklandi1 = -1;


        public Karisik4()
        {
            InitializeComponent();
            timer(10);
            metod1();
        }

        public void btnAktif()
        {
            btn1.IsVisible = true;
            btn2.IsVisible = true;
            btn3.IsVisible = true;
            btn4.IsVisible = true;
            lblArti.IsVisible = true;
            lblSonuc.IsVisible = true;
            lblSure.IsVisible = true;
            btntekrar.IsVisible = false;
            btnCikis.IsVisible = false;
            sayi1.IsVisible = true;
            sayi2.IsVisible = true;
            lblSonuc.IsVisible = true;
            lblEsittir.IsVisible = true;
        }
        public void btnPasif()
        {
            btn1.IsVisible = false;
            btn2.IsVisible = false;
            btn3.IsVisible = false;
            btn4.IsVisible = false;
            lblArti.IsVisible = false;
            lblBolme.IsVisible = false;
            lblcarpi.IsVisible = false;
            lbleksi.IsVisible = false;
            lblSonuc.IsVisible = false;
            lblSure.IsVisible = false;
            btntekrar.IsVisible = true;
            btnCikis.IsVisible = true;
            sayi1.IsVisible = false;
            sayi2.IsVisible = false;
            lblEsittir.IsVisible = false;
            lblArti.Text = "";
            lblBolme.Text = "";
            lblcarpi.Text = "";
            lbleksi.Text = "";

        }


        public void timer(double time)
        {

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {

                time -= 1;


                if (time == -1)
                {

                    lblPuan.Text = "Oyun Bitti!!!\nPuan : " + puan.ToString();
                    olumsuzRenk();
                    btnPasif();

                    return false;
                }
                else
                {
                    if (tiklandi1 == 1)
                    {
                        tiklandi1 = -1;
                        return false;

                    }
                    else if (tiklandi1 == 0)
                    {
                        tiklandi1 = -1;
                        return false;

                    }

                    lblSure.Text = time.ToString();
                    return true;








                }

            });




        }
        public void metodToplamaisareti()
        {
            lblArti.IsVisible = true;
            lblBolme.IsVisible = false;
            lbleksi.IsVisible = false;
            lblcarpi.IsVisible = false;

        }
        public void metodCikarmaisareti()
        {
            lblArti.IsVisible = false;
            lblBolme.IsVisible = false;
            lbleksi.IsVisible = true;
            lblcarpi.IsVisible = false;

        }
        public void metodCarpmaisareti()
        {
            lblArti.IsVisible = false;
            lblBolme.IsVisible = false;
            lbleksi.IsVisible = false;
            lblcarpi.IsVisible = true;

        }
        public void metodBolmeisareti()
        {
            lblArti.IsVisible = false;
            lblBolme.IsVisible = true;
            lbleksi.IsVisible = false;
            lblcarpi.IsVisible = false;

        }
        public void metod1()
        {
            metodToplamaisareti();
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
            metodToplamaisareti();
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
            metodToplamaisareti();
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
            metodToplamaisareti();
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
            metodToplamaisareti();
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
            metodToplamaisareti();
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

        public void metod7()
        {
            metodCikarmaisareti();
            r = rnd.Next(1, 10);
            k = rnd.Next(1, 5);
            a = rnd.Next(1, 11);
            b = rnd.Next(1, 11);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a - b;
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

        public void metod8()
        {
            metodCikarmaisareti();
            r = rnd.Next(1, 10);
            k = rnd.Next(1, 5);
            a = rnd.Next(10, 50);
            b = rnd.Next(10, 50);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a - b;
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

        public void metod9()
        {
            metodCikarmaisareti();
            r = rnd.Next(1, 10);
            k = rnd.Next(1, 5);
            a = rnd.Next(50, 100);
            b = rnd.Next(50, 100);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a - b;
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

        public void metod10()
        {
            metodCikarmaisareti();
            r = rnd.Next(1, 10);
            k = rnd.Next(1, 5);
            a = rnd.Next(150, 500);
            b = rnd.Next(150, 500);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a - b;
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

        public void metod11()
        {
            metodCikarmaisareti();
            r = rnd.Next(1, 10);
            k = rnd.Next(1, 5);
            a = rnd.Next(500, 1000);
            b = rnd.Next(500, 1000);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a - b;
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

        public void metod12()
        {
            metodCikarmaisareti();
            r = rnd.Next(1, 10);
            k = rnd.Next(1, 5);
            a = rnd.Next(1000, 5000);
            b = rnd.Next(1000, 5000);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a - b;
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


        public void metod13()
        {
            metodCarpmaisareti();
            r = rnd.Next(1, 10);
            k = rnd.Next(1, 5);
            a = rnd.Next(1, 11);
            b = rnd.Next(1, 11);
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

        public void metod14()
        {
            metodCarpmaisareti();
            r = rnd.Next(1, 10);
            k = rnd.Next(1, 5);
            a = rnd.Next(10, 50);
            b = rnd.Next(10, 50);
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

        public void metod15()
        {
            metodCarpmaisareti();
            r = rnd.Next(1, 10);
            k = rnd.Next(1, 5);
            a = rnd.Next(50, 100);
            b = rnd.Next(50, 100);
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

        public void metod16()
        {
            metodCarpmaisareti();
            r = rnd.Next(1, 10);
            k = rnd.Next(1, 5);
            a = rnd.Next(150, 500);
            b = rnd.Next(150, 500);
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

        public void metod17()
        {
            metodCarpmaisareti();
            r = rnd.Next(1, 10);
            k = rnd.Next(1, 5);
            a = rnd.Next(500, 1000);
            b = rnd.Next(500, 1000);
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

        public void metod18()
        {
            metodCarpmaisareti();
            r = rnd.Next(1, 10);
            k = rnd.Next(1, 5);
            a = rnd.Next(1000, 5000);
            b = rnd.Next(1000, 5000);
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

        public void metod19()
        {
            metodBolmeisareti();
            r = rnd.Next(1, 10);
            k = rnd.Next(1, 5);
            a = rnd.Next(1, 11);
            b = rnd.Next(1, 11);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a / b;
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

        public void metod20()
        {
            metodBolmeisareti();
            r = rnd.Next(1, 10);
            k = rnd.Next(1, 5);
            a = rnd.Next(10, 50);
            b = rnd.Next(10, 50);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a / b;
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

        public void metod21()
        {
            metodBolmeisareti();
            r = rnd.Next(1, 10);
            k = rnd.Next(1, 5);
            a = rnd.Next(50, 100);
            b = rnd.Next(50, 100);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a / b;
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

        public void metod22()
        {
            metodBolmeisareti();
            r = rnd.Next(1, 10);
            k = rnd.Next(1, 5);
            a = rnd.Next(150, 500);
            b = rnd.Next(150, 500);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a / b;
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

        public void metod23()
        {
            metodBolmeisareti();
            r = rnd.Next(1, 10);
            k = rnd.Next(1, 5);
            a = rnd.Next(500, 1000);
            b = rnd.Next(500, 1000);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a / b;
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

        public void metod24()
        {
            metodBolmeisareti();
            r = rnd.Next(1, 10);
            k = rnd.Next(1, 5);
            a = rnd.Next(1000, 5000);
            b = rnd.Next(1000, 5000);
            sayi1.Text = a.ToString();
            sayi2.Text = b.ToString();
            c = a / b;
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


        private void btntekrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
            Navigation.PushModalAsync(new Karisik4());
        }

        private void btnCikis_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
        int dortSecenek;
        private void btn1_Clicked(object sender, EventArgs e)
        {

            if (c.ToString() == btn1.Text)
            {
                tiklandi1 = 1;
                puan += 10;
                lblPuan.Text = "Puan : " + puan.ToString();
                olumluRenk();
            }
            else if (c.ToString() != btn1.Text)
            {
                tiklandi1 = 0;
                lblPuan.Text = "Oyun Bitti!!!\nPuan : " + puan.ToString();
                olumsuzRenk();
                btnPasif();
            }
            dortSecenek = rnd.Next(1, 5);
            if (puan < 150)
            {
                if (dortSecenek == 1)
                {
                    timer(10);
                    metod1();

                }
                else if (dortSecenek == 2)
                {
                    timer(10);
                    metod7();
                }
                else if (dortSecenek == 3)
                {
                    timer(10);
                    metod13();
                }
                else if (dortSecenek == 4)
                {
                    timer(10);
                    metod19();
                }


            }
            else if (puan >= 150 && puan <= 250)
            {
                if (dortSecenek == 1)
                {
                    timer(10);
                    metod2();

                }
                else if (dortSecenek == 2)
                {
                    timer(10);
                    metod8();
                }
                else if (dortSecenek == 3)
                {
                    timer(10);
                    metod14();
                }
                else if (dortSecenek == 4)
                {
                    timer(10);
                    metod20();
                }
            }
            else if (puan >= 250 && puan <= 500)
            {
                if (dortSecenek == 1)
                {
                    timer(10);
                    metod3();

                }
                else if (dortSecenek == 2)
                {
                    timer(10);
                    metod9();
                }
                else if (dortSecenek == 3)
                {
                    timer(10);
                    metod15();
                }
                else if (dortSecenek == 4)
                {
                    timer(10);
                    metod21();
                }
            }
            else if (puan >= 500 && puan <= 750)
            {
                if (dortSecenek == 1)
                {
                    timer(10);
                    metod4();

                }
                else if (dortSecenek == 2)
                {
                    timer(10);
                    metod11();
                }
                else if (dortSecenek == 3)
                {
                    timer(10);
                    metod16();
                }
                else if (dortSecenek == 4)
                {
                    timer(10);
                    metod22();
                }
            }
            else if (puan >= 750 && puan <= 1000)
            {
                if (dortSecenek == 1)
                {
                    timer(10);
                    metod5();

                }
                else if (dortSecenek == 2)
                {
                    timer(10);
                    metod12();
                }
                else if (dortSecenek == 3)
                {
                    timer(10);
                    metod17();
                }
                else if (dortSecenek == 4)
                {
                    timer(10);
                    metod23();
                }
            }
            else if (puan > 1000)
            {
                if (dortSecenek == 1)
                {
                    timer(10);
                    metod6();

                }
                else if (dortSecenek == 2)
                {
                    timer(10);
                    metod13();
                }
                else if (dortSecenek == 3)
                {
                    timer(10);
                    metod18();
                }
                else if (dortSecenek == 4)
                {
                    timer(10);
                    metod24();
                }
            }
        }

        private void btn2_Clicked(object sender, EventArgs e)
        {

            if (c.ToString() == btn2.Text)
            {
                tiklandi1 = 1;
                puan += 10;
                lblPuan.Text = "Puan : " + puan.ToString();
                olumluRenk();
            }
            else if (c.ToString() != btn2.Text)
            {
                tiklandi1 = 0;
                lblPuan.Text = "Oyun Bitti!!!\nPuan : " + puan.ToString();
                olumsuzRenk();
                btnPasif();
            }
            dortSecenek = rnd.Next(1, 5);
            if (puan < 150)
            {
                if (dortSecenek == 1)
                {
                    timer(10);
                    metod1();

                }
                else if (dortSecenek == 2)
                {
                    timer(10);
                    metod7();
                }
                else if (dortSecenek == 3)
                {
                    timer(10);
                    metod13();
                }
                else if (dortSecenek == 4)
                {
                    timer(10);
                    metod19();
                }


            }
            else if (puan >= 150 && puan <= 250)
            {
                if (dortSecenek == 1)
                {
                    timer(10);
                    metod2();

                }
                else if (dortSecenek == 2)
                {
                    timer(10);
                    metod8();
                }
                else if (dortSecenek == 3)
                {
                    timer(10);
                    metod14();
                }
                else if (dortSecenek == 4)
                {
                    timer(10);
                    metod20();
                }
            }
            else if (puan >= 250 && puan <= 500)
            {
                if (dortSecenek == 1)
                {
                    timer(10);
                    metod3();

                }
                else if (dortSecenek == 2)
                {
                    timer(10);
                    metod9();
                }
                else if (dortSecenek == 3)
                {
                    timer(10);
                    metod15();
                }
                else if (dortSecenek == 4)
                {
                    timer(10);
                    metod21();
                }
            }
            else if (puan >= 500 && puan <= 750)
            {
                if (dortSecenek == 1)
                {
                    timer(10);
                    metod4();

                }
                else if (dortSecenek == 2)
                {
                    timer(10);
                    metod11();
                }
                else if (dortSecenek == 3)
                {
                    timer(10);
                    metod16();
                }
                else if (dortSecenek == 4)
                {
                    timer(10);
                    metod22();
                }
            }
            else if (puan >= 750 && puan <= 1000)
            {
                if (dortSecenek == 1)
                {
                    timer(10);
                    metod5();

                }
                else if (dortSecenek == 2)
                {
                    timer(10);
                    metod12();
                }
                else if (dortSecenek == 3)
                {
                    timer(10);
                    metod17();
                }
                else if (dortSecenek == 4)
                {
                    timer(10);
                    metod23();
                }
            }
            else if (puan > 1000)
            {
                if (dortSecenek == 1)
                {
                    timer(10);
                    metod6();

                }
                else if (dortSecenek == 2)
                {
                    timer(10);
                    metod13();
                }
                else if (dortSecenek == 3)
                {
                    timer(10);
                    metod18();
                }
                else if (dortSecenek == 4)
                {
                    timer(10);
                    metod24();
                }
            }
        }

        private void btn3_Clicked(object sender, EventArgs e)
        {
            if (c.ToString() == btn3.Text)
            {
                tiklandi1 = 1;
                puan += 10;
                lblPuan.Text = "Puan : " + puan.ToString();
                olumluRenk();
            }
            else if (c.ToString() != btn3.Text)
            {
                tiklandi1 = 0;
                lblPuan.Text = "Oyun Bitti!!!\nPuan : " + puan.ToString();
                olumsuzRenk();
                btnPasif();
            }
            dortSecenek = rnd.Next(1, 5);
            if (puan < 150)
            {
                if (dortSecenek == 1)
                {
                    timer(10);
                    metod1();

                }
                else if (dortSecenek == 2)
                {
                    timer(10);
                    metod7();
                }
                else if (dortSecenek == 3)
                {
                    timer(10);
                    metod13();
                }
                else if (dortSecenek == 4)
                {
                    timer(10);
                    metod19();
                }


            }
            else if (puan >= 150 && puan <= 250)
            {
                if (dortSecenek == 1)
                {
                    timer(10);
                    metod2();

                }
                else if (dortSecenek == 2)
                {
                    timer(10);
                    metod8();
                }
                else if (dortSecenek == 3)
                {
                    timer(10);
                    metod14();
                }
                else if (dortSecenek == 4)
                {
                    timer(10);
                    metod20();
                }
            }
            else if (puan >= 250 && puan <= 500)
            {
                if (dortSecenek == 1)
                {
                    timer(10);
                    metod3();

                }
                else if (dortSecenek == 2)
                {
                    timer(10);
                    metod9();
                }
                else if (dortSecenek == 3)
                {
                    timer(10);
                    metod15();
                }
                else if (dortSecenek == 4)
                {
                    timer(10);
                    metod21();
                }
            }
            else if (puan >= 500 && puan <= 750)
            {
                if (dortSecenek == 1)
                {
                    timer(10);
                    metod4();

                }
                else if (dortSecenek == 2)
                {
                    timer(10);
                    metod11();
                }
                else if (dortSecenek == 3)
                {
                    timer(10);
                    metod16();
                }
                else if (dortSecenek == 4)
                {
                    timer(10);
                    metod22();
                }
            }
            else if (puan >= 750 && puan <= 1000)
            {
                if (dortSecenek == 1)
                {
                    timer(10);
                    metod5();

                }
                else if (dortSecenek == 2)
                {
                    timer(10);
                    metod12();
                }
                else if (dortSecenek == 3)
                {
                    timer(10);
                    metod17();
                }
                else if (dortSecenek == 4)
                {
                    timer(10);
                    metod23();
                }
            }
            else if (puan > 1000)
            {
                if (dortSecenek == 1)
                {
                    timer(10);
                    metod6();

                }
                else if (dortSecenek == 2)
                {
                    timer(10);
                    metod13();
                }
                else if (dortSecenek == 3)
                {
                    timer(10);
                    metod18();
                }
                else if (dortSecenek == 4)
                {
                    timer(10);
                    metod24();
                }
            }
        }

        private void btn4_Clicked(object sender, EventArgs e)
        {
            if (c.ToString() == btn4.Text)
            {
                tiklandi1 = 1;
                puan += 10;
                lblPuan.Text = "Puan : " + puan.ToString();
                olumluRenk();
            }
            else if (c.ToString() != btn4.Text)
            {
                tiklandi1 = 0;
                lblPuan.Text = "Oyun Bitti!!!\nPuan : " + puan.ToString();
                olumsuzRenk();
                btnPasif();
            }
            dortSecenek = rnd.Next(1, 5);
            if (puan < 150)
            {
                if (dortSecenek == 1)
                {
                    timer(10);
                    metod1();

                }
                else if (dortSecenek == 2)
                {
                    timer(10);
                    metod7();
                }
                else if (dortSecenek == 3)
                {
                    timer(10);
                    metod13();
                }
                else if (dortSecenek == 4)
                {
                    timer(10);
                    metod19();
                }


            }
            else if (puan >= 150 && puan <= 250)
            {
                if (dortSecenek == 1)
                {
                    timer(10);
                    metod2();

                }
                else if (dortSecenek == 2)
                {
                    timer(10);
                    metod8();
                }
                else if (dortSecenek == 3)
                {
                    timer(10);
                    metod14();
                }
                else if (dortSecenek == 4)
                {
                    timer(10);
                    metod20();
                }
            }
            else if (puan >= 250 && puan <= 500)
            {
                if (dortSecenek == 1)
                {
                    timer(10);
                    metod3();

                }
                else if (dortSecenek == 2)
                {
                    timer(10);
                    metod9();
                }
                else if (dortSecenek == 3)
                {
                    timer(10);
                    metod15();
                }
                else if (dortSecenek == 4)
                {
                    timer(10);
                    metod21();
                }
            }
            else if (puan >= 500 && puan <= 750)
            {
                if (dortSecenek == 1)
                {
                    timer(10);
                    metod4();

                }
                else if (dortSecenek == 2)
                {
                    timer(10);
                    metod11();
                }
                else if (dortSecenek == 3)
                {
                    timer(10);
                    metod16();
                }
                else if (dortSecenek == 4)
                {
                    timer(10);
                    metod22();
                }
            }
            else if (puan >= 750 && puan <= 1000)
            {
                if (dortSecenek == 1)
                {
                    timer(10);
                    metod5();

                }
                else if (dortSecenek == 2)
                {
                    timer(10);
                    metod12();
                }
                else if (dortSecenek == 3)
                {
                    timer(10);
                    metod17();
                }
                else if (dortSecenek == 4)
                {
                    timer(10);
                    metod23();
                }
            }
            else if (puan > 1000)
            {
                if (dortSecenek == 1)
                {
                    timer(10);
                    metod6();

                }
                else if (dortSecenek == 2)
                {
                    timer(10);
                    metod13();
                }
                else if (dortSecenek == 3)
                {
                    timer(10);
                    metod18();
                }
                else if (dortSecenek == 4)
                {
                    timer(10);
                    metod24();
                }
            }
        }
    }
}