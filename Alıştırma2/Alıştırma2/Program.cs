using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alıştırma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan ad,soyad,şehir ve yaş(string halde) alıp yaşı integera çevirip ekrana tüm değerlerin yazan program
            string ad, soyad, sehir, yas;
            Console.WriteLine("Merhaba");
            Console.Write("lutfen adinizi girin:");
            ad= Console.ReadLine();
            Console.Write("lutfen soyadinizi girin:");
            soyad= Console.ReadLine();
            Console.Write("lutfen yasadiginiz sehri girin:");
            sehir= Console.ReadLine();
            Console.Write("lutfen yasinizi giriniz:");
            yas= Console.ReadLine();
            int degistir=Convert.ToInt32(yas);
            Console.Clear();

            Console.WriteLine("adiniz"+ad);
            Console.WriteLine("soyadiniz:"+soyad);
            Console.WriteLine("yasadiginiz sehir:" + sehir);
            Console.WriteLine("yasiniz:"+degistir);
            Console.ReadLine();
              

            /*convert işlemini;
             * int cevir=Convert.ToInt32(Console.Readline()); ---->şeklinde de yapabilirdik.bu şekilde direkt aldığımız
             * gibi çevirme işlemi olacağından daha kısa bi şekilde yazım oluyor.*/



        }
    }
}
