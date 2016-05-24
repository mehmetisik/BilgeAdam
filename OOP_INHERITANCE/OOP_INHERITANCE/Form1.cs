using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOP_INHERITANCE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //CepTelefonu tel = new CepTelefonu();
            //tel.Cal();

            //EvTelefonu evtel = new EvTelefonu();
            //evtel.Cal();

            //Pda pda = new Pda();
            //pda.Cal();

            Telefon tel = new Telefon();
            MessageBox.Show(tel.UretimYeri);



            
        }
    }
}
