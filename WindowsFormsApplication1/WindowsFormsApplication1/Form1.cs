using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {

            string[] gelendata = (string[])e.Data.GetData(DataFormats.FileDrop);


            string[] dizi = Directory.GetFiles(gelendata[0]);

            foreach (string item in dizi)
            {
                listView1.Items.Add(item);
            }


        }
    }
}
