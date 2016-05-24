using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebServisKullanim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        ServiceReference1.Service1SoapClient sc = new ServiceReference1.Service1SoapClient();
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sc.HelloWorld());

            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            

            foreach (var item in sc.GetCategoryNames())
            {

                listBoxCategories.Items.Add(item);
             
            
            }
        }
    }
}
