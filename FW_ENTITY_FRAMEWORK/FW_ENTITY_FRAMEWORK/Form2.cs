using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FW_ENTITY_FRAMEWORK
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public delegate void EklendiEventHandler();
        public event EklendiEventHandler eklendi;
        private void Form2_Load(object sender, EventArgs e)
        {



        }

        northwindEntities db = new northwindEntities();
        private void button1_Click(object sender, EventArgs e)
        {

            category c = new category();
            c.CategoryName = textBoxKategori.Text;
            c.Description = "Yok";
            db.categories.AddObject(c);
            db.SaveChanges();
            //eklendi();

            Form1.catlist = db.categories.ToList();

        }
    }
}
