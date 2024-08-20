using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri m1= new Musteri();
            m1.id = 1;
            m1.isim = "Bora";
            m1.soyisim = "Atabey";
            m1.musteriNo = "MS163";
            m1.tcKimlikNo = "38593176943";
            m1.dogumTarih = DateTime.Parse("29.08.2002");


            MusteriGeneric<int> musterigeneric1= new MusteriGeneric<int>();
            musterigeneric1.id = 325;
            musterigeneric1.musteriNumarasiAl();//integer döner


            MusteriGeneric<Guid> musterigeneric2= new MusteriGeneric<Guid>();
            musterigeneric2.musteriNumarasiAl();//guid döner





        }
    }
}
