using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FW_GENERICS.Entity;

namespace FW_GENERICS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Products p=new Products();
            //Categories c=new Categories();
            //c.CategoryName = "Generic";
            //c.Description = "Generic güzel bir şey.";

            p.ProductName = "Generic Urun";
            p.UnitPrice = 100;
            p.UnitsInStock = 25;
            
            Islemci i = new Islemci();
            i.Ekle<Products>(p);
            //i.Ekle<Categories>(c);
        }
    }
}
