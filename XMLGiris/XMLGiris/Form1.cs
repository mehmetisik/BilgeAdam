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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			XmlDocument xdoc = new XmlDocument();//Bir Xml dökümanının içeriğini okumak için kullandığımız class XmlDocument...


			// "\" karakteri string içinde kullanıldığında kaçış karakteri(escape sequence) karakter olarak algılanır.Eğer path bilgisi tek \ karakterli ile kullanılacaksa bunun escape seq karakter olarak algılanmaması için string'in başına @ işareti konulur.
			xdoc.Load(@"c:\documents and settings\administrator\my documents\visual studio 2010\Projects\XMLGiris\XMLGiris\Ogrenciler.xml");

			//xdoc.DocumentElement xml dosyasını bir ağaç gibi düşünürsek,ağacın kökü olarak söylenebilir.Ogrenciler.xml için bu Ogrenciler tagine karşılık gelir.
			//kökün sahip olduğu ana dalları alıyoruz.Her bir Ogrenci tag'i document element'in bir child node'una karşılık gelir.
			XmlNodeList nodelistesi = xdoc.DocumentElement.ChildNodes;

			foreach (XmlNode xn in nodelistesi)
			{

				// MessageBox.Show(xn.Name);
				//xn bir Ogrenci tag'ine karşılık gelir.Ogrenci tag'inin alt nodelarından 0.  ilk elemana yani Ad tag'ine karşılk gelir.
				string ad = xn.ChildNodes[0].InnerText;
				string soyad = xn.ChildNodes[1].InnerText;
				comboBoxOgrenciler.Items.Add(ad + " " + soyad);
				
			}

		}
	}
}
