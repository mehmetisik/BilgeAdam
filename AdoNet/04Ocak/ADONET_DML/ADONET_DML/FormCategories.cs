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
    public partial class FormCategories : Form
    {
        public FormCategories()
        {
            InitializeComponent();
        }

        private void FormCategories_Load(object sender, EventArgs e)
        {
            FillListView();

        }

        private void FillListView()
        {
            listViewCategories.Items.Clear();
            foreach (Category item in Categories.GetAllCategories())
            {

                ListViewItem lvi = new ListViewItem();
                lvi.Tag = item;
                lvi.ImageIndex = 0;
                lvi.Text = item.CategoryName;
                lvi.SubItems.Add(item.Description);
                listViewCategories.Items.Add(lvi);


            }
        }

        int char_count = 15;
        private void listViewCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Bir eleman seçili ise ,seçili elemanın bilgilerini sağ tarafta gösteriyoruz.
            if (listViewCategories.SelectedItems.Count > 0)
            {

                Category secilen = (Category)listViewCategories.SelectedItems[0].Tag;
                textBoxName.Text = secilen.CategoryName;
                textBoxDesc.Text = secilen.Description;


            }
            else
            {

                Temizle();

            }

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

            labelChars.Text = (char_count - textBoxName.Text.Length).ToString();
        }



        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char_count - textBoxName.Text.Length == 0)
            {
                //Kalan karakter sayısı 0 ise sadece BackSpace'e basabilir.
                if (Convert.ToInt32(e.KeyChar) != 8)
                    e.Handled = true;

            }
            else
            {
                e.Handled = false;

            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

            //Seçili eleman var demektir ve bu bir güncelleme işlemi olacaktır.
            if (listViewCategories.SelectedItems.Count > 0)
            {

                Category guncellenecek = (Category)listViewCategories.SelectedItems[0].Tag;
                guncellenecek.CategoryName = textBoxName.Text;
                guncellenecek.Description = textBoxDesc.Text;

                Categories.UpdateObject(guncellenecek);

                //Güncellenmiş olan ListViewItem'daki bilgileri yeniliyoruz.
                listViewCategories.SelectedItems[0].Text = guncellenecek.CategoryName;
                listViewCategories.SelectedItems[0].SubItems[1].Text = guncellenecek.Description;

            }
            else
            {

                Category yeni = new Category();
                yeni.CategoryName = textBoxName.Text;
                yeni.Description = textBoxDesc.Text;

                Categories.AddObject(yeni);

                FillListView();


            }

        }


        void Temizle()
        {

            textBoxName.Clear();
            textBoxDesc.Clear();

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            Temizle();

            //
            if (listViewCategories.SelectedItems.Count > 0)
            {

                listViewCategories.SelectedItems[0].Selected = false;

            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {

            if (listViewCategories.SelectedItems.Count > 0)
            {
                try
                {

                    Category secilen = (Category)listViewCategories.SelectedItems[0].Tag;

                    bool silindiMi = Categories.DeleteObject(secilen);

                    if (silindiMi)
                    {

                        listViewCategories.SelectedItems[0].Remove();//ListView'den sildiğimiz elemanı kaldırıyoruz.

                    }





                }
                catch
                {



                }


            }
            else
            {
                MessageBox.Show("Silmek için listeden bir eleman seçmeniz gerekli.");

            }
        }
    }
}
