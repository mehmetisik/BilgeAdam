using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VisiyefciDayi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client();
        private void button1_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(sc.HelloDeBana());

            foreach (var item in sc.UrunAdlariGetir())
            {

                MessageBox.Show(item);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sc.XmleYaz();
        }
    }
}
