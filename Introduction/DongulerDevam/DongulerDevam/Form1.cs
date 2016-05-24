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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFor_Click(object sender, EventArgs e)
        {
            listBoxFor.Items.Clear();

            //5'ten 25'e kadar olan sayıların listeye eklenmesi
            for (byte sayi = 5; sayi < 25; sayi++)
            {

                listBoxFor.Items.Add(sayi);
            
            }
        }

        private void buttonWhile_Click(object sender, EventArgs e)
        {

            int sayi = 5;//Başlangıç durumu

            while (sayi < 25)
            { 
            
                //Sayinin 25'ten küçük olma koşulu sağlandığı müddetçe çalışacak kod....
                listBoxWhile.Items.Add(sayi);
                sayi++;

            
            }

        }

        private void buttonDoWhile_Click(object sender, EventArgs e)
        {

            int sayi=5;
            do
            {
                //Koşul sonda kontrol edildiğinden döngü en az bir defa çalışacaktır.
                listBoxDoWhile.Items.Add(sayi);
                sayi++;


            } while (sayi < 25);
        }
    }
}
