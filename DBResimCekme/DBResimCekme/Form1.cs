using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBResimCekme.Tool;
using System.Data.SqlClient;
using DBResimCekme.Facade;
using System.IO;
using DBResimCekme.Entity;

namespace DBResimCekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                

                if (Baglanti.con.State == ConnectionState.Closed)
                {

                    Baglanti.con.Open();
                
                }

                    MessageBox.Show(Baglanti.con.State.ToString());
                
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Baglanti.con.Close();
            
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            comboBoxMezuniyetler.DisplayMember = "MezuniyetDurumu";
            comboBoxMezuniyetler.ValueMember = "MezuniyetId";
            comboBoxMezuniyetler.DataSource = Mezuniyetler.MezuniyetleriGetir();


            textBoxAd.Text = FormAdaylar.tasinacak.Ad;
            pictureBoxResim.Image = Image.FromStream(new MemoryStream(FormAdaylar.tasinacak.Resim));
            comboBoxMezuniyetler.SelectedValue = Convert.ToInt32(FormAdaylar.tasinacak.MezuniyetId);


        }

        byte[] resim_data;
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg|*.jpg|png|*.png|jpeg|*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                resim_data = new byte[fs.Length];
                fs.Read(resim_data, 0, resim_data.Length);
                fs.Close();

                pictureBoxResim.Image = Image.FromFile(ofd.FileName);
            
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            Aday eklenecek = new Aday();
            eklenecek.Ad = textBoxAd.Text;
            eklenecek.MezuniyetId = Convert.ToInt32(comboBoxMezuniyetler.SelectedValue);
            eklenecek.Resim = resim_data;
            int etkilenen=Adaylar.AdayEkle(eklenecek);

            if (etkilenen>0)
            {
                MessageBox.Show("Tebrikler,kazandınız");
            }
        }
    }
}
