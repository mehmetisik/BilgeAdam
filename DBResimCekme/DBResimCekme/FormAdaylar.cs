using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBResimCekme.Facade;
using System.Collections;
using DBResimCekme.Entity;
using System.IO;

namespace DBResimCekme
{
    public partial class FormAdaylar : Form
    {
        public FormAdaylar()
        {
            InitializeComponent();
        }

        public static Aday tasinacak;
        private void FormAdaylar_Load(object sender, EventArgs e)
        {

            ArrayList adaylar = Adaylar.AdaylariGetir();

            foreach (Aday aday in adaylar)
            {

                PictureBox pb = new PictureBox();
                pb.Width = 100;
                pb.Height = 100;
                pb.MouseEnter += new EventHandler(pb_MouseEnter);
                pb.MouseLeave += new EventHandler(pb_MouseLeave);
                pb.Image = Image.FromStream(new MemoryStream(aday.Resim));
                pb.Tag = aday;
                pb.MouseDoubleClick += new MouseEventHandler(pb_MouseDoubleClick);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                flowLayoutPanelAdaylar.Controls.Add(pb);
            
            
            
            }


        }

        void pb_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).BorderStyle = BorderStyle.None;
        }

        void pb_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).BorderStyle = BorderStyle.Fixed3D;
        }

        void pb_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            PictureBox tiklanan = (PictureBox)sender;
            tasinacak = (Aday)tiklanan.Tag;
            Form1 frm = new Form1();
            frm.ShowDialog();
        }
    }
}
