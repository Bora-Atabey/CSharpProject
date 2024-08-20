using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot_ödev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ortalama hesabı ancak metod ile
            decimal not1, not2, not3;
            Ogrenci ogrenciIslem= new Ogrenci();
            ogrenciIslem.OgrenciSelamla();

            Console.Write("Notlarınızı girin: ");
            not1=Convert.ToDecimal(Console.ReadLine());
            not2 = Convert.ToDecimal(Console.ReadLine());
            not3= Convert.ToDecimal(Console.ReadLine());

           decimal sonuc= ogrenciIslem.OrtalamaHesapla(not1 ,not2 ,not3 );

            if (sonuc < 45 && sonuc>0)
            {
                Console.WriteLine("Maalesef kaldınız...");
                Console.WriteLine("ortalamanız:{0} ", sonuc);
            }
            else if(sonuc >=45 && sonuc<100)
            {
                Console.WriteLine("tebrikler geçtiniz!!");
                Console.WriteLine("ortalamanız: {0}", sonuc);
            }
            else
            {
                Console.WriteLine("hatalı not girişi yaptınız...");
            }
            Console.ReadLine();


        }
    }
}
