using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace FW_COLLECTIONS
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Stack liste = new Stack();
        private void Form3_Load(object sender, EventArgs e)
        {
           
            liste.Push("Burak");
            liste.Push("Yiğit");
            liste.Push("Samet");
            liste.Push("Çağrı");

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (liste.Count > 0)
            {
                MessageBox.Show(liste.Pop().ToString());
            }
        }
    }
}
