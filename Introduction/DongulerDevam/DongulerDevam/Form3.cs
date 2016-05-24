using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DongulerDevam
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonLoto_Click(object sender, EventArgs e)
        {
            listBoxSayilar.Items.Clear();

            Random r = new Random();

            int kacTane = 0;
            int donussayisi = 0;
            while (kacTane < 6)
            {

                //1'^den 49 dahil bu aralıkta rastgele bir sayı oluşturuyoruz.
                int rastgele_sayi = r.Next(1, 10);

                //Oluşturulan sayı liste içerisinde içerilmiyorsa..
                if (!listBoxSayilar.Items.Contains(rastgele_sayi))
                {

                    listBoxSayilar.Items.Add(rastgele_sayi);
                    kacTane++;
                
                }

                donussayisi++;

            }//Döngünün bitiş scopu

            MessageBox.Show(donussayisi.ToString());
        }
    }
}
