using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FW_OOP_SIGORTA
{
    class Program
    {
        static void Main(string[] args)
        {

            Sigorta sg = new Sigorta(1);

            for (int i = 1; i < 10; i++)
            {
                System.Threading.Thread.Sleep(1000);
                sg.Amper = i;
                Console.WriteLine("Akım Değeri:" + i);

                if (sg.Amper > 5)
                {

                    sg.sigortayandi += new Sigorta.SigortaAtti(sg_sigortayandi);
                
                }
            
            
            }
            Console.Read();
        }

        static void sg_sigortayandi()
        {
            Console.Beep();
        }
    }
}
