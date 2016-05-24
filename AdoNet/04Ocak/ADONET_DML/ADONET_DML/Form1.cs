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

namespace ADONET_DML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Category[] categories = new Category[5];

            Category c = new Category();
            c.CategoryName = "Beverages";

            categories[0] = c;
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            Category eklenecek = new Category();
            eklenecek.CategoryName = textBoxCategoryName.Text;
            eklenecek.Description = textBoxDescription.Text;

            Categories.AddObject(eklenecek);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Category silinecek = new Category
            {

                CategoryId = 24,
                CategoryName="Hugo"

            };

            Categories.DeleteObject(silinecek);


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
