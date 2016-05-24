using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FW_EVENT_DELEGATE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.elemaneklendi += new Form2.Eklendi(frm_elemaneklendi);
            frm.Show();
        }

        void frm_elemaneklendi(string eklenen)
        {
            listBox1.Items.Add(eklenen);
        }

        
    }
}
