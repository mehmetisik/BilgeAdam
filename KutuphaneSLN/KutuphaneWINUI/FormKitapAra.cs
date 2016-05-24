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
using System.Collections;

namespace KutuphaneWINUI
{
    public partial class FormKitapAra : Form
    {
        public FormKitapAra()
        {
            InitializeComponent();
        }

        private void textBoxKitap_TextChanged(object sender, EventArgs e)
        {
            listViewKitaplar.Items.Clear();
            if (!string.IsNullOrEmpty(textBoxKitap.Text.Trim()))
            {

               ArrayList gelenliste=KitapIslem.KitapAra(textBoxKitap.Text);

               foreach (Kitap item in gelenliste)
               {

                   ListViewItem lvi = new ListViewItem();
                   lvi.Tag = item;
                   lvi.Text = item.KitapAD;
                   lvi.SubItems.Add(item.ISBNNO);
                   lvi.SubItems.Add(item.BasimTarihi.ToString());
                   listViewKitaplar.Items.Add(lvi);
               
               }
                
            
            }

        }
    }
}
