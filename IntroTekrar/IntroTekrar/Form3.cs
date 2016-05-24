using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IntroTekrar
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string[] kelimeler = { "Kapat Beni", "Kapatamazsın ki", "Uğraşma Boşuna", "Naber", "Uğraşmaya Devam Et" };
        private void Form3_Load(object sender, EventArgs e)
        {
            Random rastgele = new Random();

            

                while (true)
                {

                    int indeks = rastgele.Next(0, kelimeler.Length);
                    MessageBox.Show(kelimeler[indeks]);
                }
        }
    }
}
