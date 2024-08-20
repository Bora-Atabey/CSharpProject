using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3_odev_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri m1=new Musteri();
            m1.id = 1;
            m1.isim = "Bora";
            m1.soyisim = "Atabey";
            m1.emailAdres = "bora.atabey@gmail.com";
            m1._kullaniciAdi = "bora.atabey";
            m1.sifre = "1105195960";

            Musteri.MusteriEkle(m1);

            Musteri m2 = new Musteri()
            {
                id = 2,
                isim = "Kuzey",
                soyisim = "Atabey",
                emailAdres = "kuzey.atabey@gmail.com",
                _kullaniciAdi = "kuzey.atabey",
                sifre = "123456"
            };
            Musteri.MusteriEkle(m2);

            Musteri m3 = new Musteri();//burda varolan bir müşteriyi eklemeye çalıştığımızdaki hatayı göreceğiz.
            m3.id = 1;
            m3.isim = "Bora";
            m3.soyisim = "Atabey";
            m3.emailAdres = "bora.atabey@gmail.com";
            m3._kullaniciAdi = "bora.atabey";
            m3.sifre = "1105195960";
            Musteri.MusteriEkle(m3);


        }
    }
}
