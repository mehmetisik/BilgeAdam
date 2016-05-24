using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ApiMehmet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("winmm.dll")]
        public static extern void mciSendString(string command,StringBuilder sb,int hede,IntPtr ptr);

        [DllImport("user32.dll")]
        public static extern bool ExitWindowsEx(uint uFlags, long dwReason);
 
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                mciSendString("set cdAudio door open",null,0,IntPtr.Zero);
            }
            catch
            {
                
                
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                mciSendString("set cdAudio door closed",null,0,IntPtr.Zero);
            }
            catch
            {
                
               
            }
          
        }

        string fileName;
        private void button3_Click(object sender, EventArgs e)
        {
            string Pcommand = "Open \"" + listView1.SelectedItems[0].Tag.ToString() +
                                "\" type mpegvideo alias mediafile";
            mciSendString(Pcommand, null, 0, IntPtr.Zero);
            isOpen = true;
            Play(true);

        }

        bool isOpen;
        string Pcommand;
        public void Play(bool loop)
        {
            if (isOpen)
            {
                Pcommand = "play MediaFile";
                if (loop)
                    Pcommand += " REPEAT";
                mciSendString(Pcommand, null, 0, IntPtr.Zero);
            }
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
             string[] dosya =(string []) e.Data.GetData(DataFormats.FileDrop);
             ListViewItem lvi = new ListViewItem();
             lvi.Tag = dosya[0];
             string[] dizi = dosya[0].Split('\\');
             lvi.Text = dizi[dizi.Length - 1];
             listView1.Items.Add(lvi);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExitWindowsEx(0, 1);
        }
    }
}
