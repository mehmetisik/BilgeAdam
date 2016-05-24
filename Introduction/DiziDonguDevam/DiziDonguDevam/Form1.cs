using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiziDonguDevam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        //3 elemanlı int tipinde bir dizi tanımlaması
        int[] sayilar = new int[3];
        int indeks;

        
        private void buttonEkle_Click(object sender, EventArgs e)
        {

            if (indeks < 3)
            {
                sayilar[indeks] = Convert.ToInt32(textBoxSayi.Text);
                indeks++;
                
            }
            else
            {
                //Her seferinde dizinin boyutunu bir önceki boyuta göre 1 arttırıyoruz.
                Array.Resize(ref sayilar, sayilar.Length + 1);
                sayilar[indeks] = Convert.ToInt32(textBoxSayi.Text);
                indeks++;
                
            
            }
            textBoxSayi.Clear();
        }
    }
}
