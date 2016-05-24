using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiziDonguDevam2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonBak_Click(object sender, EventArgs e)
        {

            //Eğer TextBox uzunluğu 1 değilse hiçbir işlem yaptırmıyoruz.
            if (textBoxHarf.Text.Length != 1)
            {

                MessageBox.Show("Lütfen tek bir tane harf giriniz!");
                return;
            
            }

            bool varMi = false;
            int kacTane = 0;//Text içinde aranan karakterin kaç gere geçtiğini tutacak değişken
            foreach (char harf in textBoxIfade.Text)
            {

                if (harf == textBoxHarf.Text[0])
                {
                    //varMi = true;
                    //break;//döngüyü sonlandırır.Yani döngünün scope bitiminden kodu devam ettirir.
                   // return;//Hangi event içinde tanımlıysa o eventin scope bitişine gider.
                    kacTane++;



                }
               
            
            
            }//Döngünün bittiği yer

            //if (varMi)
            //{
            //    MessageBox.Show("ğ karakterinden var");

            //}
            //else
            //{
            //    MessageBox.Show("Text içinde yok!");
            
            //}

            if (kacTane == 0)
            {
                MessageBox.Show(textBoxHarf.Text + " karakteri metin içerisinde bulunamadı!");

            }
            else
            {

                MessageBox.Show(textBoxHarf.Text + " karakterinden " + kacTane + " adet bulundu!");  
            
            }

        }
    }
}
