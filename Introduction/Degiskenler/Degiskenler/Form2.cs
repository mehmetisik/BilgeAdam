using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Degiskenler
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //ListBox'a eleman eklerken object tipte değerler veririz.Tipler object'ten türediğinden string,int ya da double tipte bir veriyi direk olarak vermemiz mümkün!
            lstDegerler.Items.Add("İstanbul");
            lstDegerler.Items.Add(10);
            lstDegerler.Items.Add(20.2);
        }
    }
}
