using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.IO;

namespace FW_WINDOWS_SERVICE
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {

            System.Timers.Timer tmr = new System.Timers.Timer();
            tmr.Interval = 5000;
            tmr.Elapsed += new System.Timers.ElapsedEventHandler(tmr_Elapsed);
            tmr.Start();

           

        }

        void tmr_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("C:/Zaman.txt",true);
            
            sw.WriteLine(DateTime.Now.ToLongTimeString());
            sw.Close();
        }

        protected override void OnStop()
        {

            this.CanStop = false;
        }
    }
}
