using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Sanal_Metot
{
    public class Musteri//:Object yazmayız zaten Framework standart olarak tüm nesneleri objectten türetir.
    {
        public int musteriId { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }

        //override yazıp olduğun classın kalıtıldığı classtaki metotları görür ve seçersin.değiştirme işlemleri vs. için
       public override string ToString()
        {
            return isim + " " + soyisim;//tostring çağırdığımda isim + soyisim versin şeklinde değiştirdik
        }

    }
}
