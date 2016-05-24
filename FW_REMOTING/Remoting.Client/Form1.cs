using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Remoting.Object;
using System.Runtime.Remoting;
using System.IO;

namespace Remoting.Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TasiBeni tasinacak;
        private void button1_Click(object sender, EventArgs e)
        {

            RemotingConfiguration.RegisterWellKnownClientType(typeof(TasiBeni), "tcp://127.0.0.1:15000/Cemsit");
            tasinacak = new TasiBeni();
            MessageBox.Show("Bağlantı Kuruldu.");

        }

        string path;
        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            if (fd.ShowDialog()==DialogResult.OK)
            {
                path = fd.SelectedPath;
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            string dosyaadi=Guid.NewGuid().ToString();
            byte[] gelen = tasinacak.GoruntuVer();
            FileStream fs = new FileStream(path + "/" + dosyaadi + ".png", FileMode.Create);
            fs.Write(gelen, 0, gelen.Length);
            fs.Close();
        }
    }
}
