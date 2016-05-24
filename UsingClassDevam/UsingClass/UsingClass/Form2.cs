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
          DialogResult sonuc=MessageBox.Show("Formun arka plan rengini kırmızı yapmak istiyor musunuz?", "Kırmızı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //Eğer kullanıcı Yes butonuna bastıysa...
          if (sonuc == DialogResult.Yes)
          {

              this.BackColor = Color.Red;
          
          }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            openFileDialogDosya.Filter = "jpg|*.jpg|png|*.png|gif|*.gif";

            if (openFileDialogDosya.ShowDialog() == DialogResult.OK)
            {

                pictureBoxResim.Image = Image.FromFile(openFileDialogDosya.FileName);
            
            
            }
        }
    }
}
