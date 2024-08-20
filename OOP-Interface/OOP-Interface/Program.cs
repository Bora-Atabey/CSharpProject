using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface
{
    internal class Program
    {
        static void Main(string[] args)
            //Interface'in en önemli noktası bir standart belirlemesidir. belli metotlar ve fieldlar tanımlanır ondan kalıtılan classlar,
            //kendi işlerine göre field ve metotları düzenleyip kullanır.Böylece çok kişili yapılan projelerde belli bir standart oluşmuş olur.
        {
            musteri m1 = new musteri();
            m1.isim = "Beytullah";
            m1.soyisim = "Göçer";
            m1.id = 123;
            m1.yenikayit("Bora", "Atabey");

        }
    }
}
