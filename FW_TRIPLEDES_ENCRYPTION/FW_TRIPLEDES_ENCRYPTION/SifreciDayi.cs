using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace FW_TRIPLEDES_ENCRYPTION
{
    class SifreciDayi
    {
        //TripleDES algoritmasıyla şifreleme yapıyoruz.
        TripleDES tdes = null;
        Aes aes = null;
        

        //Anahtar oluşturma işlemi 2 tane byte[] işe gerçekleştirilir.

        private byte[] key2 = { 1, 2, 3, 4, 5, 6, 7, 8 }; 
        private byte[] key1 = {1,2,3,4,5,6,7,8,9,10,11,12,18,14,15,16,17,18,19,20,21,22,23,24};

        //ctor+tab+tab Constructor'ın görevi class üyelerine ilk değer atamasını gerçekleştirmektir.
        public SifreciDayi()
        {
            tdes = TripleDESCryptoServiceProvider.Create();
            aes = AesCryptoServiceProvider.Create();
        }

        public byte [] Sifrele(byte[] sifrelenecekdata)
        {

            ICryptoTransform ict = tdes.CreateEncryptor(key1, key2);
            return ict.TransformFinalBlock(sifrelenecekdata, 0, sifrelenecekdata.Length);
            
        
        }

        public byte[] Desifrele(byte[] sifrelenmisdata)
        {

            ICryptoTransform ict = tdes.CreateDecryptor(key1, key2);
            return ict.TransformFinalBlock(sifrelenmisdata, 0, sifrelenmisdata.Length);

            //ICryptoTransform ict = aes.CreateDecryptor(key1, key2);
            //return ict.TransformFinalBlock(sifrelenmisdata, 0, sifrelenmisdata.Length);
        
        }

    }
}
