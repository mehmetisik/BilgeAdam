using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MdiForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public static bool acildiMi;//Varsayılan değeri false'tur.
        private void yönetimModülüToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (acildiMi == false)
            {

                Form2 frm = new Form2();
                frm.MdiParent = this;
                frm.Show();
                acildiMi = true;//açıldıktan sonra değişkenin değerini true yapıyoruz.
            }
        }
    }
}
