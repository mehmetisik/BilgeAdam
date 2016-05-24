using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MdiLoginliGiris
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Hide();//Bu from gizlenecek!

            Form1 frm = new Form1();

            if (frm.ShowDialog() == DialogResult.OK)
            {

                this.Show();
                labelGirisDetay.Text = Form1.tasinacak_data;

            }
            else
            {

                Application.Exit();//Uygulamayı sonlandır.
            
            }

           


        }

        int secilen_koltukNo;
        private void rezervasyonToolStripMenuItem_Click(object sender, EventArgs e)
        {

            for (int koltuk_no = 1; koltuk_no < 45; koltuk_no++)
            {

                Button btn = new Button();
                btn.Text = koltuk_no.ToString();
                btn.Width = 30;
                btn.MouseEnter += new EventHandler(btn_MouseEnter);
                btn.Tag = koltuk_no;
                btn.Height = 30;
                btn.ContextMenuStrip = contextMenuStripMenu;
                btn.BackColor = Color.Green;
                btn.ForeColor = Color.White;
                flowLayoutPanelKoltuklar.Controls.Add(btn);

            
            }


        }

        void btn_MouseEnter(object sender, EventArgs e)
        {
            Button uzerinegelinen = (Button)sender;
            secilen_koltukNo = Convert.ToInt32(uzerinegelinen.Tag);
            //MessageBox.Show(secilen_koltukNo.ToString());
        }

        private void rezerveEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenkDegistir(Color.Yellow);
        }

        private void satışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenkDegistir(Color.Red);
        }

        void RenkDegistir(Color renk)
        {

            foreach (Control ctrl in flowLayoutPanelKoltuklar.Controls)
            {

                if (ctrl is Button)
                {

                    //Gezmiş olduğumuz butonun arka planında tutulan Tag değerini int'e çeviriyoruz.
                    int gezilen_no = Convert.ToInt32((ctrl as Button).Tag);


                    if (secilen_koltukNo == gezilen_no)
                    {

                        (ctrl as Button).BackColor = renk;


                    }




                }


            }
        
        
        }

        private void iptalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenkDegistir(Color.Green);
        }
    }
}
