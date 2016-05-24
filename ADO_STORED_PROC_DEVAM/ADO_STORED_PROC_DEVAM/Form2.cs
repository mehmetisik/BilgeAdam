using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ADO_STORED_PROC_DEVAM.Facade;

namespace ADO_STORED_PROC_DEVAM
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = RaporIslem.SatisGetir(dateTimePickerIlk.Value, dateTimePickerSon.Value);
        }
    }
}
