using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Northwind.Facade;

namespace ADONET_DML
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Employees.employeesleriListele(int.Parse(textBox1.Text));

            foreach (DataRow item in dt.Rows)
            {
                listBox1.Items.Add(item["Firstname"]);
            }
        }
    }
}
