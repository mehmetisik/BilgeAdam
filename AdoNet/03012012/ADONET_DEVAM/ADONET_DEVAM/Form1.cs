using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADONET_DEVAM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("server=.;database=Northwind;Integrated Security=True");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglanti;
            cmd.CommandText = "insert Categories(CategoryName) values('" + textBoxCategoryName.Text + "')";

            baglanti.Open();
            int etkilenenkayitsayisi = cmd.ExecuteNonQuery();

            if (etkilenenkayitsayisi > 0)
            {

                MessageBox.Show("Kayıt Başarıyla Eklendi.");

            }

            baglanti.Close();
        }
    }
}
