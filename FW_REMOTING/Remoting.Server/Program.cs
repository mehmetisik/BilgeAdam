using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;
using Remoting.Object;

namespace Remoting.Server
{
    class Program
    {
        static void Main(string[] args)
        {

            TcpChannel kanal = new TcpChannel(15000);

            ChannelServices.RegisterChannel(kanal);

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(TasiBeni), "Cemsit", WellKnownObjectMode.Singleton);

            Console.WriteLine("Bağlantı Kuruldu.");
            Console.ReadLine();

        }
    }
}
