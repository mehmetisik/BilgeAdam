using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MetotlarGiris
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            string aranacak = textBoxAranan.Text;//Arayacağımız ifade

            string metin = textBoxMetin.Text;//Aranılan yer

            int eskiuzunluk = metin.Length;

            //Aradığımız ifadenin yerine boş karakter atayıp yer değiştiriyoruz.Böylelikle metin de değişiyor.
            metin = metin.Replace(aranacak, "");

            int yeniuzunluk = metin.Length;

            int kacTane = (eskiuzunluk-yeniuzunluk) / aranacak.Length;
            MessageBox.Show(kacTane.ToString() + " adet var!");

            
        }
    }
}
