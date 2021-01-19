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
    public partial class Carpma4 : ContentPage
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
        int tiklandi1 = -1;

        public Carpma4()
        {
            InitializeComponent();
            timer(6);
            metod1();
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
            lblSonuc.IsVisible = false;
            lblSure.IsVisible = false;
            btntekrar.IsVisible = true;
            btnCikis.IsVisible = true;
            sayi1.IsVisible = false;
            sayi2.IsVisible = false;
            lblEsittir.IsVisible = false;
        }
        public void metod1()
        {

            r = rnd.Next(1, 10);
            k = rnd.Next(1, 5);
            a = rnd.Next(1, 7);
            b = rnd.Next(1, 7);
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
            a = rnd.Next(3, 12);
            b = rnd.Next(3, 12);
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

        public void metod5()
        {
            r = rnd.Next(1, 10);
            k = rnd.Next(1, 5);
            a = rnd.Next(5, 11);
            b = rnd.Next(5, 11);
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
            a = rnd.Next(8, 20);
            b = rnd.Next(8, 20);
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

        public void marginOzellik()
        {
            lblSure.Margin = new Thickness(10);
        }

        private void btntekrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
            Navigation.PushModalAsync(new Carpma4());
        }

        private void btnCikis_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

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

            if (puan < 150)
            {
                timer(6);
                metod1();

            }
            else if (puan >= 150 && puan <= 250)
            {
                timer(8);
                metod2();
            }
            else if (puan >= 250 && puan <= 500)
            {
                timer(10);
                metod3();
            }
            else if (puan >= 500 && puan <= 750)
            {
                timer(12);
                metod4();
            }
            else if (puan >= 750 && puan <= 1000)
            {
                timer(14);
                metod5();
            }
            else if (puan > 1000)
            {
                timer(16);
                metod6();
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

            if (puan < 150)
            {
                timer(6);
                metod1();

            }
            else if (puan >= 150 && puan <= 250)
            {
                timer(8);
                metod2();
            }
            else if (puan >= 250 && puan <= 500)
            {
                timer(10);
                metod3();
            }
            else if (puan >= 500 && puan <= 750)
            {
                timer(12);
                metod4();
            }
            else if (puan >= 750 && puan <= 1000)
            {
                timer(14);
                metod5();
            }
            else if (puan > 1000)
            {
                timer(16);
                metod6();
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

            if (puan < 150)
            {
                timer(6);
                metod1();

            }
            else if (puan >= 150 && puan <= 250)
            {
                timer(8);
                metod2();
            }
            else if (puan >= 250 && puan <= 500)
            {
                timer(10);
                metod3();
            }
            else if (puan >= 500 && puan <= 750)
            {
                timer(12);
                metod4();
            }
            else if (puan >= 750 && puan <= 1000)
            {
                timer(14);
                metod5();
            }
            else if (puan > 1000)
            {
                timer(16);
                metod6();
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

            if (puan < 150)
            {
                timer(6);
                metod1();

            }
            else if (puan >= 150 && puan <= 250)
            {
                timer(8);
                metod2();
            }
            else if (puan >= 250 && puan <= 500)
            {
                timer(10);
                metod3();
            }
            else if (puan >= 500 && puan <= 750)
            {
                timer(12);
                metod4();
            }
            else if (puan >= 750 && puan <= 1000)
            {
                timer(14);
                metod5();
            }
            else if (puan > 1000)
            {
                timer(16);
                metod6();
            }
        }
    }
}