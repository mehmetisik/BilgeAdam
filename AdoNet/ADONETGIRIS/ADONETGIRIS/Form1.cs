using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADONETGIRIS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBaglan_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            //Hangi veri kaynağı olursa olsun mutlaka bağlantı bilgisini string tipteki ConnectionString özelliği ile belirtiyoruz

            /*
             * server=.   server=localhost    server=127.0.0.1
             * database=Northwind
             * Windows Authentication için Integrated Security=True ya da Trusted_Connection=True
             * ifadeleri kullanılır ve her bir ifade ; ile ayrılır.
             * */
            baglanti.ConnectionString = "server=.;database=Northwind;Integrated Security=True";

            baglanti.Open();//Bağlantıyı Open metodu ile açıyoruz.

            //State property'si bağlantı durumunu kontrol etmemizi sağlar.ConnectionState ile durumu kontrol ediyoruz.
            if (baglanti.State == ConnectionState.Open)
            {

                MessageBox.Show("Bağlantı Kuruldu!");
            
            }
            baglanti.Close();
        }
    }
}
