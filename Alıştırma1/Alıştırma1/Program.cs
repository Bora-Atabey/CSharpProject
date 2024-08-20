using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alıştırma1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan isim,soyisim ve şehir bilgilerini alıp ekrana yazdıran uygulama.

            string isim, soyisim, sehir;
            Console.Write("Lutfen isminizi girin:");
            isim = Console.ReadLine();//isim değişkenine kullanıcıdan değer alma 
            Console.Write("Lutfen soyisminizi girin:");
            soyisim = Console.ReadLine();//soyisim değişkenine kullanıcıdan değer alma    
            Console.Write("Lutfen yasadiginiz sehri girin:");
            sehir = Console.ReadLine();//sehir değişkenine kullanıcıdan değer alma

            Console.Clear();//ekranda bu komuta kadar yazılan her şeyi temizler

            Console.WriteLine("isminiz:"+ isim);
            Console.WriteLine("soyisminiz: " + soyisim);
            Console.WriteLine("yasadiginiz sehir: "+sehir);//ekrana daha önce kullanıcıdan aldığımız bilgileri gösterme
            Console.ReadLine();


        }
    }
}
