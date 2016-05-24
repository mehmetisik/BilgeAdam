using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KontrolKullanim
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void tmrKorkut_Tick(object sender, EventArgs e)
        {

            //Form ile işlem yapacaksak formu temsil eden anahtar kelime this anahtar kelimesidir.this içinde bulundupğumuz formu temsil eder.

            Random r = new Random();

            //Screen.PrimaryScreen.Bounds.Width ekran genişliği
            //Ekran dışına çıkmaması için en fazla formun sola olan uzaklığı ekran genişliği-formun genişliği olacaktır.
            this.Left = r.Next(0, Screen.PrimaryScreen.Bounds.Width - this.Width);

            //Herhangi bir kontrolün yukarıya olan uzaklığı ise Top property'si ile belirlenir.


            /*
             
             * Left=sola olan uzaklık
             * Width:Genişlik
             * Height:Yükseklik
             * Top=Yukarıya olan uzaklık
             * 
             */

            this.Top = r.Next(0, Screen.PrimaryScreen.Bounds.Height - this.Height);

            this.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));


            


        }
    }
}
