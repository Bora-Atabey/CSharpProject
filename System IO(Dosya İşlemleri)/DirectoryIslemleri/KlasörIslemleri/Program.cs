using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KlasörIslemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dosyaOlustur("C:\\Users\\btyazilimstajyer\\Desktop\\Odev\\merhaba.txt");
            dosyayaEkle("C:\\Users\\btyazilimstajyer\\Desktop\\Odev\\merhaba.txt", "SELAM TÜRKİYE");
           string metinDeger= dosyaOku("C:\\Users\\btyazilimstajyer\\Desktop\\Odev\\merhaba.txt");
            Console.WriteLine(metinDeger);
            Console.ReadLine();
        }
        static void dosyaOlustur(string yol)
        {
           FileStream fst= File.Create(yol);//verilen yolda bir dosya oluşturur.
            fst.Close();//close metoduyla kapatmazsak hata alırız.
        }
        static bool dosyaVarlikKontrol(string yol)
        {
            bool kontrol=File.Exists(yol);//boolean değer döndürür.dosyanın var olup olmadığını söyler.
            return kontrol;
        }
        static void dosyaSil(string yol)
        {
            File.Delete(yol);//dosyayı siler.
        }
        static void dosyayıTaşı(string kaynak,string alıcı)
        {
            File.Move(kaynak, alıcı);//ilk aldığı parametre kaynağı,ikincisi de nereye olacağını belirten taşıma metodu.
        }
        static void dosyaKopyala(string kaynak,string alıcı)
        {
            File.Copy(kaynak, alıcı);//verdiğimiz ilk değerdeki dosyayı kopyalayıp ikinci değere kopyalar
        }
        static void dosyayaEkle(string yol,string değerler)//ilk değer girilecek dosya,ikinci değer ise içine yazılacak değerleri alır ve dosyaya ekler.
        {
            File.AppendAllText(yol, değerler);
        }
        static string dosyaOku(string yol)//dosyadaki değerleri okur.
        {
            return File.ReadAllText(yol);
        }

    }
}
