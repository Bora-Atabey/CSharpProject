using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class Ogrenci
    {
        public void OgrenciSelamla()
        {

            Console.WriteLine("SELAMLAR ÖĞRENCİ");
        }
        public void OgrenciMetot1(string ogrAd, string ogrSoyad)
        {
            Console.Write("Öğrencinin Adı : {0} Soyadı : {1}", ogrAd, ogrSoyad);
            Console.ReadLine();
        }

    }
}
