using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OOPLib;
using System.Drawing;

namespace KutuphaneKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {

            Araba arb = new Araba();
            arb.Marka = "BMW";
            arb.Renk = Color.Red;

            Console.Beep(10000, 1000);
            Console.WriteLine(arb.Marka+" arabanın rengi:"+arb.Renk.Name);
            Console.Read();
        }
    }
}
