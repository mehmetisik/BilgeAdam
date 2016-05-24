using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Net;
using System.IO;

namespace HaberTurkXml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XmlDocument xdoc = new XmlDocument();
        XmlNodeList nodelistesi;
        private void Form1_Load(object sender, EventArgs e)
        {

            xdoc.Load("http://www.haberturk.com/haberturk.xml");

            //channel tag'inin child node'larını almış olduk.
            nodelistesi = xdoc.DocumentElement.ChildNodes[0].ChildNodes;

            foreach (XmlNode xn in nodelistesi)
            {

                if (xn.Name == "item")
                {

                    listBoxHaberler.Items.Add(xn.ChildNodes[0].InnerText);

                }

            }

        }

        private void listBoxHaberler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxHaberler.SelectedItems.Count > 0)
            {
                panelBilgi.Visible = true;

                foreach (XmlNode xn in nodelistesi)
                {

                    if (xn.ChildNodes[0].InnerText == listBoxHaberler.SelectedItem.ToString())
                    {

                        WebClient wc = new WebClient();
                        byte[] gelen_data = wc.DownloadData(xn.ChildNodes[3].InnerText);
                        pictureBoxResim.Image = Image.FromStream(new MemoryStream(gelen_data));
                        string aciklama = xn.ChildNodes[1].InnerText;

                        string [] dizi = aciklama.Split(' ');

                        int baslangic_indeksi = 0,bitis_indeksi=0;
                        for (int indeks = 0; indeks < dizi.Length; indeks++)
                        {

                            if (dizi[indeks].Contains("alt"))
                            {

                                baslangic_indeksi = indeks;
                            
                            }
                            if (dizi[indeks].Contains("align"))
                            {

                                bitis_indeksi = indeks - 1;
                            
                            }
                        
                        
                        }

                        aciklama = "";
                        for (int i = baslangic_indeksi; i <= bitis_indeksi; i++)
                        {

                            aciklama += dizi[i] + " ";
                        
                        }
                        aciklama=aciklama.Remove(aciklama.Length - 1);
                        aciklama=aciklama.Replace("alt=", ""); 
                        linkLabelAciklama.Text = aciklama;

                        linkLabelAciklama.Tag = xn.ChildNodes[7].InnerText;



                    }

                }


            }
            else
            {
                panelBilgi.Visible = false;

            }
        }

        private void linkLabelAciklama_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore", linkLabelAciklama.Tag.ToString());
        }
    }
}
