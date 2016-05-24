using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;

namespace AdamAsmaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string[] kelimeler = { "Ankara", "Bursa", "Van", "Eskişehir", "Malatya", "Edirne", "Kahramanmaraş" };

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int button_left = 20, button_top = 20;
        int kacTane = 1;//Oluşturulan buton sayısını kontrol edecek değişken
        private void buttonOyna_Click(object sender, EventArgs e)
        {
            groupBoxButonlar.Controls.Clear();
            groupBoxKelime.Controls.Clear();
            AdamiSifirla();
            dogrusayisi = 0;
            yanlissayisi = 0;
            button_left = 20;
            button_top = 20;
            kacTane = 1;

            #region KelimeyeBagliLabelOlusturulması
            Random rastgele = new Random();

            //Diziden eleman alacağımızdan rastgele bir indeks değeri üretiyoruz.0 ile dizinin eleman sayısı kadar verip indeksin dizi sınırlarına taşmasını önlüyoruz.
            int rastgele_indeks = rastgele.Next(0, kelimeler.Length);

            string gelen_kelime = kelimeler[rastgele_indeks].ToUpper();

            int label_sol = 30;
            int label_ust = 30;
            foreach (char harf in gelen_kelime)
            {

                Label lbl = new Label();
                lbl.Width = 50;
                lbl.Text = "__";
                lbl.Tag = harf;//Her bir label için oluşturduğumuz labellerın her birinin arka planında harfi tutuyoruz.
                lbl.Top = label_ust;
                lbl.Left = label_sol;
                groupBoxKelime.Controls.Add(lbl);
                label_sol += 60;

            }
            #endregion


            for (char karakter = 'A'; karakter <= 'Z'; karakter++)
            {
                //Eğer bu karakterlerden biri gelirse,alttaki işlemler yapılmadan direk döngüde artıma gidiyoruz.Bu işlemi continue anahtar kelimesi ile gerçekleştiririz.
                if (karakter == 'Q' || karakter == 'W' || karakter == 'X')
                    continue;


                ButonOlustur(karakter);


                switch (karakter)
                {

                    case 'C':
                        ButonOlustur('Ç');
                        break;

                    case 'S':
                        ButonOlustur('Ş');
                        break;
                    case 'G':
                        ButonOlustur('Ğ');
                        break;
                    case 'U':
                        ButonOlustur('Ü');
                        break;
                    case 'I':
                        ButonOlustur('İ');
                        break;
                    case 'O':
                        ButonOlustur('Ö');
                        break;

                }






            }




        }



        void ButonOlustur(char _karakter)
        {

            Button btn = new Button();
            btn.Click += new EventHandler(btn_Click);
            btn.Text = _karakter.ToString();
            btn.Width = 40;
            btn.Height = 40;


            btn.BackColor = Color.Blue;
            btn.ForeColor = Color.White;
            btn.Left = button_left;
            btn.Top = button_top;


            //Buton sayısı 10 olduğunda,yeni butonları aynı hizada aşağıadn arttırmak için Top'ı arttıyoruz ve Left'i başlangıç değerine çekiyoruz.
            if (kacTane % 10 == 0)
            {

                button_left = 20;
                button_top += 50;

            }
            else
            {

                button_left += 50;

            }
            groupBoxButonlar.Controls.Add(btn);
            kacTane++;

        }


        int dogrusayisi, yanlissayisi;
        void btn_Click(object sender, EventArgs e)
        {
            //Hangi butona tıklarsak tıklayalım bu metod çalışacaktır.Dolayısıyla tahmin işlemini burada yapıyoruz.

            bool Varmi = false;//Kullanıcın tahmin ettiği harf labellerda var mı yok mu bunu kontrol edecek değişken
            Button tiklanan = (Button)sender;
            tiklanan.Enabled = false;
            tiklanan.BackColor = Color.Red;
            //Form ya da groupbox farketmez,içindeki bütün elemanlar Control tipindedir.Herhangi bir groupbox'ın kontrollerinde gezmek istersek,aşağıdaki gibi döngü yapısını kullanırız.
            foreach (Control c in groupBoxKelime.Controls)
            {

                //Gezdiğimiz kontrolün özel olarak button,label ya da textbox olup olmadığını kontrol etmek için is anahtar kelimesi kullanırız.
                if (c is Label)//Kontrol tipindeki c değişkeni label ise....
                {

                    //Her bir label içinde dolaşıp Taglerinde sakladığımız değerleri kontrol ediyoruz.
                    Label gezilen = (Label)c;

                    //Tahmine edilen harf labellerda var mı?
                    if (gezilen.Tag.ToString() == tiklanan.Text)
                    {

                        gezilen.Text = tiklanan.Text;
                        Varmi = true;
                        dogrusayisi++;

                    }


                }

            }//Döngünün bittiği yer......

         
            if (dogrusayisi == groupBoxKelime.Controls.Count)
            {

                MessageBox.Show("Tebrikler,kazandınız!");
                ButonlariPasifYap();
                return;

            }

            if (Varmi == false)
            {

                yanlissayisi++;

                switch (yanlissayisi)
                {

                    case 1:
                        lineShapeAgac1.Visible = true;
                        break;
                    case 2:
                        lineShapeAgac2.Visible = true;
                        break;
                    case 3:
                        lineShapeIp.Visible = true;
                        break;
                    case 4:
                        ovalShapeKafa.Visible = true;
                        break;
                    case 5:
                        lineShapeGovde.Visible = true;
                        break;
                    case 6:
                        lineShapeKol1.Visible = true;
                        lineShapeKol2.Visible = true;
                        break;
                    case 7:
                        lineShapeAyak1.Visible = true;
                        lineShapeAyak2.Visible = true;
                        MessageBox.Show("Game Over!");

                        //Tahmin butonlarının hepsini pasif ve arka plan renklerini kırmızıya çeviriyoruz.
                        ButonlariPasifYap();
                        break;




                }

            }


        }

        private void ButonlariPasifYap()
        {
            foreach (Control c in groupBoxButonlar.Controls)
            {

                if (c is Button)
                {

                    Button button = (Button)c;
                    button.Enabled = false;
                    button.BackColor = Color.Red;

                }

            }
        }

        void AdamiSifirla()
        {

            lineShapeAgac1.Visible = false;
            lineShapeAgac2.Visible = false;
            lineShapeAyak1.Visible = false;
            lineShapeAyak2.Visible = false;
            lineShapeGovde.Visible = false;
            lineShapeIp.Visible = false;
            lineShapeKol1.Visible = false;
            lineShapeKol2.Visible = false;
            ovalShapeKafa.Visible = false;



        }




    }
}
