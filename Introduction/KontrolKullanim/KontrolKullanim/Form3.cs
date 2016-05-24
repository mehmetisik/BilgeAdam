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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void tmrKos_Tick(object sender, EventArgs e)
        {

            Random rastgele = new Random();//rastgele isimli nesne,bize rastgele bir sayı oluşturacak.

            //Sayı oluşturmak için Random tipindeki bu nesnenin Next metodundan faydalanırız.



            //pbResim1.Left += 10;
            //pbResim2.Left += 6;
            //pbResim3.Left += 2;

            pbResim1.Left += rastgele.Next(1, 11);
            pbResim2.Left += rastgele.Next(1, 11);
            pbResim3.Left += rastgele.Next(1, 11);
        }
    }
}
