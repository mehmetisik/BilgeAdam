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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        northwindEntities db = new northwindEntities();
        public static List<category> catlist;
        private void Form1_Load(object sender, EventArgs e)
        {
            catlist = db.categories.ToList();

            //category cat = new category();
            //cat.CategoryName = "Entity";
            //cat.Description = "Framework";

            ////Ekleme olayı
            ////LinqtoSql class InsertOnSubmit 
            ////EF AddObject
            //db.categories.AddObject(cat);
            //db.SaveChanges();//Değişiklikler kaydedilmeli.

            KategoriGetir();


        }

        private void KategoriGetir()
        {
            comboBox1.DataSource = null;
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategooryId";
            //comboBox1.DataSource = db.categories.ToList();
            comboBox1.DataSource = catlist;
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
           category guncellenecek=db.categories.Single(c => c.CategooryId == 3);
           guncellenecek.CategoryName = "Karagözlü";
           guncellenecek.Description = "Çingene";
           db.SaveChanges();



        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            category cat = db.categories.Single(x => x.CategooryId == 3);

            db.categories.DeleteObject(cat);
            db.SaveChanges();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            //frm.eklendi += new Form2.EklendiEventHandler(frm_eklendi);
            frm.Show();
        }

        void frm_eklendi()
        {
            KategoriGetir();
        }
    }
}
