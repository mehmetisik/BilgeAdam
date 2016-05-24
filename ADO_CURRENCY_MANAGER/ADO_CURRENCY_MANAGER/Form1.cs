using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO_CURRENCY_MANAGER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        CurrencyManager cm;
        SqlDataAdapter da;
        DataTable dt;
        private void Form1_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("server=.;database=Northwind;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("select * from Products", conn);

            da=new SqlDataAdapter(cmd);

            dt = new DataTable();

            da.Fill(dt);//DataTable'ın içini dolduruyoruz.


            //İleri ya da geri gitmemizi sağlayacak CurrencyManager tipindeki nesnemize veri kaynağını veriyoruz.
            cm =(CurrencyManager)this.BindingContext[dt];


            textBoxProductName.DataBindings.Add("Text", dt, "ProductName");
            textBoxUnitPrice.DataBindings.Add("Text", dt, "UnitPrice");
            textBoxUnitsInStock.DataBindings.Add("Text", dt, "UnitsInStock");
            textBoxQuantityPerUnit.DataBindings.Add("Text", dt, "QuantityPerUnit");

            //Add metodu(string olarak Property adı,veri kaynağı,sorgunun içeridiği ilgili sütun değeri)
            checkBoxDiscontinued.DataBindings.Add("Checked", dt, "Discontinued");





        }

        private void buttonIleri_Click(object sender, EventArgs e)
        {
            cm.Position++;
        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            cm.Position--;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cm.Position = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cm.Position = dt.Rows.Count - 1;
        }
    }
}
