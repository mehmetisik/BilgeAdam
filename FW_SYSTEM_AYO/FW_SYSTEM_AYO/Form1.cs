using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FW_SYSTEM_AYO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Width = 60;
            btn.Height = 60;
            btn.Left = 30;
            btn.Top = 50;
            btn.BackgroundImage = FW_SYSTEM_AYO.Properties.Resources.Koala;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            this.Controls.Add(btn);
        }
    }
}
