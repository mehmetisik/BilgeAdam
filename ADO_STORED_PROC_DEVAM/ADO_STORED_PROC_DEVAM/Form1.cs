using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ADO_STORED_PROC_DEVAM.Entity;
using ADO_STORED_PROC_DEVAM.Facade;

namespace ADO_STORED_PROC_DEVAM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePickerSon.Value < dateTimePickerIlk.Value)
            {

                MessageBox.Show("İlk tarih değeri ikincisinden küçük olmalıdır.");
                return;


            }

            listView1.Items.Clear();
            foreach (Rapor item in RaporIslem.SatislariGetir(dateTimePickerIlk.Value, dateTimePickerSon.Value))
            {


                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.Calisan;
                lvi.SubItems.Add(item.ProductName);
                lvi.SubItems.Add(item.Toplam.ToString());
                lvi.SubItems.Add(item.OrderDate.ToShortDateString());
                listView1.Items.Add(lvi);
            
            
            }


        }
    }
}
