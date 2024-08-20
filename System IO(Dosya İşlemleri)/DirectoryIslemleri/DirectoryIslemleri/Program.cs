using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//io kütüphanesi dosya işlemleri için

namespace DirectoryIslemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //directory sınıfı sabit diskimizde dosya işlemleri yapmaya yarar.
            //yeniKlasörOluştur("C:\\Users\\btyazilimstajyer\\Desktop\\Odev");//verdiğim yolda yeni bir klasör oluşturdu.
            //klasörKontrol("C:\\Users\\btyazilimstajyer\\Desktop\\Odev");//verdiğim yoldaki dosyanın var olup olmadığına baktı.
            //klasörSil("C:\\Users\\btyazilimstajyer\\Desktop\\Odev");//verdiğim yoldaki dosyayı sildi.
            //yeniDosyaOluşturma("C:\\Users\\btyazilimstajyer\\Desktop\\Odev");
            klasorTasima("C:\\Odev", "C:\\Users\\btyazilimstajyer\\Desktop\\Odev");//c'deki ödev klasörünü masaüstüne taşıdı.
        }
        static void yeniKlasörOluştur(string yol)
        {
            DirectoryInfo d1 = Directory.CreateDirectory(yol);//bu statik createdirectory metodu geriye directoryinfo bir değer döndürür içine de string bir yol değeri alır.

        }
        static void klasörKontrol(string yol)
        {
            bool kontrol = Directory.Exists(yol);//verilen yolun var olup olmadığını kontrol eder.bool değer döndürür.

        }
        static void klasörSil(string yol)
        {
            Directory.Delete(yol, true);//geri değer dönmez direkt yoldaki dosyayı siler.
            //ikinci aldığı true-false değeri ise güvenlik kontrolüdür yani eğer dosyanın içinde birşeyler varsa sileyim mi?
            //sorusunun cevabını veririz.
        }
        static void yeniDosyaOluşturma(string yol)//ödev--> bir klasör oluşturma işlemi verilen yerde klasör varsa silip yeni klasör oluşturma işlemi yoksa direkt oluşturma
        {
            if (Directory.Exists(yol))
            {
                Directory.Delete(yol, true);
                Console.WriteLine("Dosyanız mevcuttur şimdi silinecek ve yenisi oluşturulacaktır...");
                Directory.CreateDirectory(yol);
                Console.WriteLine("Yeni dosyanız başarıyla oluşmuştur.");
               Console.ReadLine();

            }
            else
            {
                Directory.CreateDirectory(yol);
                Console.WriteLine("Yeni klasörünüz başarıyla oluşmuştur.");
                Console.ReadLine();
            }

        }
        static void klasorTasima(string kaynak,string hedef)
        {
            Directory.Move(kaynak, hedef);//ilk girdiği değer nereden alacağını,ikincisi de nereye taşınacağını belirtir.
        }
    }
}
