using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdamAsmaca
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int sayi =400;

            //byte deger = Convert.ToByte(sayi);
            byte deger = (byte)sayi;

            MessageBox.Show(deger.ToString());
        }
    }
}
