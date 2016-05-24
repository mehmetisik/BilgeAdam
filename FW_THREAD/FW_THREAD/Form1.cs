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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t1 = new Thread(new ThreadStart(IslemYap));
            t1.Start();
        }

        private void IslemYap()
        {
            for (int i = 1; i <= 500000; i++)
            {

                listBoxSayilar.Items.Add(i);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        Thread t1;

        private void button3_Click(object sender, EventArgs e)
        {
            if (t1.ThreadState == ThreadState.Running)
            {

                t1.Suspend();
                button3.Text = "Devam Et";
            
            }
            else if (t1.ThreadState == ThreadState.Suspended)
            {

                t1.Resume();
                button3.Text = "Duraklat";
            
            }
        }
    }
}
