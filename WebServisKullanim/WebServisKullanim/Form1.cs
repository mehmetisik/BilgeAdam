using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace WebServisKullanim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        KurCevirici.CurrencyConvertor cevirgec = new KurCevirici.CurrencyConvertor();

        MeteorolojiHedesi.GlobalWeather havaciefendi = new MeteorolojiHedesi.GlobalWeather();
        private void button1_Click(object sender, EventArgs e)
        {
           double para=cevirgec.ConversionRate(KurCevirici.Currency.GBP, KurCevirici.Currency.USD);
           MessageBox.Show(para.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(havaciefendi.GetWeather("Istanbul", "Turkey"));

            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(havaciefendi.GetWeather("Istanbul","Turkey"));

            XmlNodeList nodelistesi = xdoc.DocumentElement.ChildNodes;

            foreach (XmlNode xn in nodelistesi)
            {

                if (xn.Name == "Temperature")
                {
                    string item = xn.InnerText;//4F (8C)
                    string duzenlenmis = item.Split('(')[1];
                    duzenlenmis= duzenlenmis.Remove(duzenlenmis.Length - 1);

                    MessageBox.Show(duzenlenmis);
                
                }
            
            }



        }
    }
}
