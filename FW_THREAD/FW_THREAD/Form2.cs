using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace FW_THREAD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            t1 = new Thread(new ThreadStart(birinciislem));
            t2 = new Thread(new ThreadStart(ikinciislem));

            t1.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Normal;
        }

        Thread t1, t2;
        private void button1_Click(object sender, EventArgs e)
        {
            t1.Start();
        }

        void birinciislem()
        {

            for (int i = 1; i <= 250000; i++)
            {

                label1.Text = i.ToString();
            
            
            }
        
        
        }

        void ikinciislem()
        {


            for (int i = 1; i <= 250000; i++)
            {

                label2.Text = i.ToString();


            }
        
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t2.Start();
        }
    }
}
