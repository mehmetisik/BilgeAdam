using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace Remoting.Object
{
    //Ağ üzerinde taşınacak herhangi bir nesne mutlaka MarshallByRefObject sınıfından miras almalıdır.
    public class TasiBeni:MarshalByRefObject
    {

        private int _sayi;

        public int Sayi
        {
            get { return _sayi; }
            set { _sayi = value; }
        }
        
        

        public void SayiArttir()
        {
            this.Sayi++;
            
        }

        public byte[] GoruntuVer()
        {

            Graphics grafik;
            Bitmap resim;


            resim = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);

            grafik = Graphics.FromImage(resim);

            grafik.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size);


            string path = Guid.NewGuid().ToString();
            resim.Save("C://" + path + ".png", ImageFormat.Png);

            FileStream fs = new FileStream("C://" + path + ".png", FileMode.Open);
            byte[] donecek_data = new byte[fs.Length];
            fs.Read(donecek_data, 0, donecek_data.Length);
            fs.Close();

            try
            {
                File.Delete("C://" + path + ".png");
            }
            catch 
            {
              
            }
            return donecek_data;
        
        
        
        }

    }
}
