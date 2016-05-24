using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FutbolMerkeziWebServis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FutbolMerkeziServis.FM_Web_Service servis = new FutbolMerkeziServis.FM_Web_Service();
        private void Form1_Load(object sender, EventArgs e)
        {

          DataTable dt=servis.GetTopScorers(FutbolMerkeziServis.MatchType.TurkcellSüperLig);
           // servis.GetTopScorersCompleted += new FutbolMerkeziServis.GetTopScorersCompletedEventHandler(servis_GetTopScorersCompleted);
          //dataGridView1.DataSource = dt;

          foreach (DataRow item in dt.Rows)
          {
              listBox1.Items.Add(item["Name_Tr"] + "------> " + item["GoalCount"]);
          }

        }

        void servis_GetTopScorersCompleted(object sender, FutbolMerkeziServis.GetTopScorersCompletedEventArgs e)
        {
            
        }
    }
}
