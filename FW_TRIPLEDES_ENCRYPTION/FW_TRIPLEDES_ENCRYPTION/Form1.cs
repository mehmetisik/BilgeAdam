using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FW_TRIPLEDES_ENCRYPTION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSifrele_Click(object sender, EventArgs e)
        {

            SifreciDayi dayi = new SifreciDayi();
            byte[] sifrelenecek = Encoding.GetEncoding(1254).GetBytes(textBoxSifrelenecek.Text);

            byte[] sifrelenmis = dayi.Sifrele(sifrelenecek);

            textBoxSifrelenmis.Text = Encoding.GetEncoding(1254).GetString(sifrelenmis);

        }

        private void buttonCoz_Click(object sender, EventArgs e)
        {
            SifreciDayi dayi = new SifreciDayi();

            byte[] cozulecek = Encoding.GetEncoding(1254).GetBytes(textBoxSifrelenmis.Text);

            byte [] cozulmus=dayi.Desifrele(cozulecek);

            MessageBox.Show(Encoding.GetEncoding(1254).GetString(cozulmus));
        }
    }
}
