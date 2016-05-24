using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MerhabaCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Form kontrolünün varsayılan olayı yani event'i Load eventidir.Ve ilk olarak Form yüklenirken çalışır.
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Butonun ise varsayılan olayı Click eventidir.Bir kontrolün üzerine çift tıklandğında varsayılan event çalışır
        private void btnTikla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba CSharp");
            
        }

        //Mouse ile butonun üzerine gelindiği zaman gerçekleşecek olay...
        private void btnTikla_MouseEnter(object sender, EventArgs e)
        {
            btnTikla.BackColor = Color.Red;//Butonun arka plan rengi kırmızı olsun
        }

        private void btnTikla_MouseLeave(object sender, EventArgs e)
        {
            btnTikla.BackColor = Color.Blue;
        }

        
    }
}
