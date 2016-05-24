using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ADONET_STORED_PROC.DAL;
using ADONET_STORED_PROC.Entity;
using Northwind.Facade;
using System.Media;
using System.Runtime.InteropServices;

namespace ADONET_STORED_PROC
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {

            #region Kategorilerin Getirilmesi
            comboBoxCategories.DisplayMember = "CategoryName";
            comboBoxCategories.ValueMember = "CategoryId";
            comboBoxCategories.DataSource = Categories.GetAllCategories();
            #endregion

            Product gelen = Form1.secilen_product;
            textBoxName.Text = gelen.ProductName;
            textBoxPerUnit.Text = gelen.QuantityPerUnit.ToString();
            textBoxPrice.Text = gelen.UnitPrice.ToString();
            textBoxStock.Text = gelen.UnitsInStock.ToString();
            textBoxUnitsOnOrder.Text = gelen.UnitsOnOrder.ToString();
            if (gelen.Discontinued)
            {

                checkBoxDiscontinued.Checked = true;

            }
            else
            {

                checkBoxDiscontinued.Checked = false;
            
            }
            comboBoxCategories.SelectedValue = gelen.CategoryId;

            if (gelen.UnitsInStock < 5)
            {

                buttonStockLevel.BackColor = Color.Red;
                buttonStockLevel.Text = "Stock Level:Critical";
                SoundPlayer sp = new SoundPlayer(ADONET_STORED_PROC.Properties.Resources.Blip);
                sp.Play();
            
            }
            else if (gelen.UnitsInStock >= 5 && gelen.UnitsInStock < 10)
            {

                buttonStockLevel.BackColor = Color.Yellow;
                buttonStockLevel.Text = "Stock Level:Normal";

            }
            else
            {

                buttonStockLevel.BackColor = Color.Green;
                buttonStockLevel.Text = "Stock Level:Fantastic";
            
            }

            

        }

        [DllImport("winmm.dll")]
        public static extern void mciSendString(string sb);
        private void button1_Click(object sender, EventArgs e)
        {
            mciSendString("set cdaudio door open");
        }
    }
}
