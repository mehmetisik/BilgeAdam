using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace FW_COLLECTIONS
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        Queue ekmekkuyrugu = new Queue();//FIFO(First In First Out)->İlk giren eleman ilk çıkar.
        Queue<Button> butonlar = new Queue<Button>();

        private void Form4_Load(object sender, EventArgs e)
        {
            //Eleman ekleme
            ekmekkuyrugu.Enqueue("Vatandaş 1");
            ekmekkuyrugu.Enqueue("Vatandaş 2");
            ekmekkuyrugu.Enqueue("Vatandaş 3");

            butonlar.Enqueue(new Button { Width = 100, Height = 100, Text = "Birinci" });

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Eleman Alma
            MessageBox.Show(ekmekkuyrugu.Dequeue().ToString());

            this.Controls.Add(butonlar.Dequeue());
        }
    }
}
