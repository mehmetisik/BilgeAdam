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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        SqlDataAdapter adaptor;
        DataTable ramdekitablo;
        private void Form2_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("server=.;database=Northwind;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("select * from Products", conn);

            //SqlDataAdapter bağlantıyı kendi açıp kapatan ve sorguyu çalıştıran çift yünlü çalışa bir nesnedir.DB->RAM    RAM->DB
           adaptor = new SqlDataAdapter(cmd);


            ramdekitablo = new DataTable();//DataTable veritabanındaki tabloya karşılık ram'deki tablo gibi düşünülebilir.

            //Fill metodu ile DataTable'ın içini dolduruyoruz.
            adaptor.Fill(ramdekitablo);

            dataGridViewProducts.DataSource = ramdekitablo;






        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cmd = new SqlCommandBuilder(adaptor);
            adaptor.Update(ramdekitablo);
        }
    }
}
