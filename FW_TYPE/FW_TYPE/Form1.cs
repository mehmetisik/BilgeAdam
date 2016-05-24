using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace FW_TYPE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Herhangi bir tipi almak için typeof kullanılır.
            Type t = typeof(Personel);

            //tip içerisindeki Property'ler içerisinde dolaşıyoruz.t.GetProperties geriye ProperyInfo [] döndürür.
            foreach (PropertyInfo pi in t.GetProperties())
            { 
            
                MessageBox.Show(pi.Name.ToString());
            
            }

          

        }
    }
}
