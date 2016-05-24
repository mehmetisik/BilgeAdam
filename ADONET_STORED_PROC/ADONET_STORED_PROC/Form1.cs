using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Northwind.Entity;
using Northwind.Facade;
using ADONET_STORED_PROC.Entity;
using ADONET_STORED_PROC.DAL;

namespace ADONET_STORED_PROC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBoxCategories.DisplayMember = "CategoryName";
            comboBoxCategories.ValueMember = "CategoryId";
            comboBoxCategories.DataSource = Categories.GetAllCategories();
        }

        private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MessageBox.Show(comboBoxCategories.SelectedValue.ToString());

            listViewProducts.Items.Clear();
            int secilen_kategoriId = Convert.ToInt32(comboBoxCategories.SelectedValue);

            foreach (Product p in Products.GetProducts(secilen_kategoriId))
            {

                ListViewItem lvi = new ListViewItem();
                lvi.Tag = p;
                lvi.Text = p.ProductName;
                lvi.SubItems.Add(p.UnitPrice.ToString());
                lvi.SubItems.Add(p.UnitsInStock.ToString());
                listViewProducts.Items.Add(lvi);
            
            
            }


        }

        public static Product secilen_product;//Detay formuna taşınacak nesne...
        private void listViewProducts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewProducts.SelectedItems.Count > 0)
            {

                secilen_product = (Product)listViewProducts.SelectedItems[0].Tag;

                FormProduct frm = new FormProduct();
                frm.ShowDialog();
            
            }

        }
    }
}
