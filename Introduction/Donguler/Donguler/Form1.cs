using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Donguler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int sol_uzaklik = 20;//Oluşturulacak butonların sol tarafa(bulundukları container(içerici ki burada içerici groupbox))olan uzaklığını belirler.

            int yukari_uzaklik = 20;//Butonların yukarı tarafa olan uzaklıklarını belirleyecek değişken

            int kacTane = 1;//Kaç buton oluşturduğumuzu tutacak değişken



            for (int baslangic = 1; baslangic <= 10; baslangic++)
            {

                comboBoxSayilar.Items.Add(baslangic);
            
            
            }


            for (char karakter = 'A'; karakter <= 'Z'; karakter++)
            {

                Button btn = new Button();//Her bir karakter için bir buton oluşturuyoruz.
                
                btn.Text = karakter.ToString();
                btn.Width = 40;//Yükseklik
                btn.Height = 40;//Genişlik
                btn.Click += new EventHandler(btn_Click);
                btn.Top = yukari_uzaklik;
                btn.BackColor = Color.Honeydew;
                btn.ForeColor = Color.Blue;
                btn.Left = sol_uzaklik;

                //kacTane değişkenini değeri 10 ve 10'un katlarıysa,10'a bölümünden kalan 0 olacaktır.Ve dolayısıyla yeni oluşturulacak butonları aşağıdan başlayarak oluşturuyoruz.
                if (kacTane % 10 == 0)
                {

                    yukari_uzaklik += btn.Height + 10;
                    sol_uzaklik = 20;

                }
                else//Diğer durumlarda ise buton sol tarafa doğru yanyana oluşturulur.
                {
                    sol_uzaklik += btn.Width + 10;
                
                }


                groupBoxKlavye.Controls.Add(btn);
                kacTane++;//Her eklemeden sonra kacTane'nin değerini arttırıyoruz.
            
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            //Butonlardan herhangi birine tıklandığında ne olacağını yazıyoruz.

            //sender tıkladığımız buton
            Button tiklanan = (Button)sender;//object tipteki sender değişkenini butona çeviriyoruz.

           // MessageBox.Show(tiklanan.Text);

            textBoxYazi.Text += tiklanan.Text;

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

      

        
    }
}
