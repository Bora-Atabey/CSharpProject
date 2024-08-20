using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Enum
{
    public class Program
    {
        static void Main(string[] args)
        {
            //okunabilirliği arttıran,projede başka birileri çalışacaksa anlamayı kolaylaştıran yapılardır.

            Musteri m1= new Musteri();
            m1.id = 1;
            m1.musteriNo = "MSN165654";
            m1.isim = "Bora";
            m1.soyisim = "Atabey";
            m1.email = "boraatabey@gmail.com";
            SanalDataBase sb= new SanalDataBase();

            MusteriReturnValue musteriKayitSonuc=sb.yeniKayit(m1);
            if (musteriKayitSonuc ==  MusteriReturnValue.kayitBasarili)
            {

                
            }





        }
    }
}
