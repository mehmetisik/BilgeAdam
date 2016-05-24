using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace XMLGiris
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        XmlDocument xdoc = new XmlDocument();
        XmlNodeList nodelistesi;
        private void Form2_Load(object sender, EventArgs e)
        {

            xdoc.Load("http://www.tcmb.gov.tr/kurlar/today.xml");

            nodelistesi = xdoc.DocumentElement.ChildNodes;

            foreach (XmlNode xn in nodelistesi)
            {

                comboBoxKurlar.Items.Add(xn.ChildNodes[1].InnerText);
            }

        }

        private void comboBoxKurlar_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (XmlNode xn in nodelistesi)
            {

                if (xn.ChildNodes[1].InnerText == comboBoxKurlar.SelectedItem.ToString())
                {
                    try
                    {
                        labelAlis.Text = xn.ChildNodes[3].InnerText;
                        labelSatis.Text = xn.ChildNodes[4].InnerText;
                        break;
                    }
                    catch
                    {
                        labelAlis.Text = "?";
                        labelSatis.Text = "?";
                    }
                 
                
                
                }
            
            }

        }
    }
}
