using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintingGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void printDocumentYazdirilacak_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Graphics grafik = e.Graphics;
            float yNoktasi=10;
            foreach (string urun in listBoxUrunler.Items)
            {

                grafik.DrawString(urun, new Font("Arial", 10), Brushes.Red, 10, yNoktasi);

                yNoktasi += 15;
            
            }

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //Graphics g = this.CreateGraphics();
            //g.FillEllipse(Brushes.Red, e.X, e.Y, 5, 5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialogOnIzleyici.ShowDialog();
        }

        private void buttonYazdir_Click(object sender, EventArgs e)
        {
            printDocumentYazdirilacak.Print();
        }
    }
}
