using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;

namespace BinarySerialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Personel prs = new Personel();
            //prs.Ad = "Burak";
            //prs.Soyad = "Olgaç";
            //prs.Yas = 17;

            //Personel.liste.Add(prs);

            //FileStream fs = new FileStream("F:/Selami.sel", FileMode.Create);

            //BinaryFormatter bf = new BinaryFormatter();
            //bf.Serialize(fs, Personel.liste);
            //fs.Close();


            FileStream fs = new FileStream("F:/Selami.sel", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            ArrayList liste = (ArrayList)bf.Deserialize(fs);
            dataGridView1.DataSource = liste;





        }
    }
}
