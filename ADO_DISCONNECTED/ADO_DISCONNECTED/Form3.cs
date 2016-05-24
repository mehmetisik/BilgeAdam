using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO_DISCONNECTED
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection("server=.;database=Northwind;Integrated Security=True");


            SqlCommand cmd = new SqlCommand("select * from Products where UnitsInStock<10", conn);


            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable("Product");

            da.Fill(dt);

            DataSet ramdekiveritabani = new DataSet("Products");

            ramdekiveritabani.Tables.Add(dt);

            ramdekiveritabani.WriteXml("C:/UrunStok.xml");


        }
    }
}
