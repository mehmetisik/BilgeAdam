using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kutuphane.Facade;
using Kutuphane.Entity;

namespace KutuphaneWINUI
{
    public partial class FormYayinEvi : Form
    {
        public FormYayinEvi()
        {
            InitializeComponent();
        }


        public delegate void ParametresizEventHandler();
        public event ParametresizEventHandler eveklendi;
        public event ParametresizEventHandler evsilindi;
        private void FormYayinEvi_Load(object sender, EventArgs e)
        {

            YayınevleriniListele();

        }

        private void YayınevleriniListele()
        {

            listView1.Items.Clear();
            foreach (DataRow dr in YayinEviIslem.YayinEviGetir().Rows)
            {

                ListViewItem lvi = new ListViewItem();
                YayinEvi item = new YayinEvi();
                item.ID = Convert.ToInt32(dr["ID"]);
                item.YayınEvi = dr["Yayınevi"].ToString();
                lvi.Text = dr["Yayınevi"].ToString();
                lvi.Tag = item;
                listView1.Items.Add(lvi);


            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                YayinEvi secilen = (YayinEvi)listView1.SelectedItems[0].Tag;
                textBoxYayinEvi.Text = secilen.YayınEvi;


            }
            else
            {

                textBoxYayinEvi.Clear();
            
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            YayinEvi yeni = new YayinEvi();
            yeni.YayınEvi = textBoxYayinEvi.Text;
            YayinEviIslem.YayinEviEkle(yeni);
            eveklendi();
            YayınevleriniListele();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                YayinEvi secilen = (YayinEvi)listView1.SelectedItems[0].Tag;
                YayinEviIslem.YayinEviSil(secilen.ID);
                evsilindi();
                YayınevleriniListele();
            
            
            }
        }
    }
}
