using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UsingClass
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult Sonuc = MessageBox.Show("Formun Arka Plan Rengini Kımızı yapmak İstiyomusunuz?","Kırmızı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (Sonuc == DialogResult.Yes)
            {

                this.BackColor = Color.Red;
            }
            
        }

        private void buttonGozat_Click(object sender, EventArgs e)
        {
            openFileDialogDosya.Filter = "jpg|*.jpeg|png|*.png|gif|*.gif";
            if (openFileDialogDosya.ShowDialog() == DialogResult.OK)
            {
                pictureBoxResim.Image = Image.FromFile(openFileDialogDosya.FileName);
            }
        }
    }
}
