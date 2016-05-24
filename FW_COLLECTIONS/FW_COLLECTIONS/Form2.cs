using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FW_COLLECTIONS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        NorthwindDataContext db = new NorthwindDataContext();
        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (var item in db.sp_MusteriSatis())
            { 
            
             //   item.
            
            }

            db.Products.Where(x=>x.Category.CategoryName=="Beverages")
                ;

           MessageBox.Show(db.Order_Details.Where(x=>x.Order.Employee.FirstName=="Nancy").Sum(x=>x.Quantity*x.UnitPrice).ToString());
        }
    }
}
