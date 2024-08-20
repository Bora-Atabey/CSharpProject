using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karar_yapıları_alıştırmalar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcak 3 adet not alıp ortalamasını hesaplayıp kalıp kalmadığını gösteren program

            Console.WriteLine("Ortalma hesaplamaya hoşgeldiniz!!");
            Console.Write("İlk notunuzu girin:");
            string not1=Console.ReadLine();
            Console.Write("İkinci notunuzu girin: ");
            string not2=Console.ReadLine();
            Console.Write("Üçüncü notunuzu girin:");
            string not3=Console.ReadLine();

            int gnot1 = Convert.ToInt32(not1);
            int gnot2 = Convert.ToInt32(not2);
            int gnot3 = Convert.ToInt32(not3);

            decimal ortalama = (gnot1 + gnot2 + gnot3) / 3;

            if(ortalama<45 && ortalama >= 0)
            {
                Console.WriteLine("KALDINIZ... ORTALAMANIZ:"+ortalama);
                Console.ReadLine();
            }
            else if(ortalama<70 && ortalama >= 45)
            {
                Console.WriteLine("ORTA İLE GEÇTİNİZ...ORTALAMANIZ:" + ortalama);
                Console.ReadLine();
            }
            else if(ortalama<90 && ortalama >= 70)
            {
                Console.WriteLine("İYİ İLE GEÇTİNİZ...ORTALAMANIZ:" + ortalama);
                Console.ReadLine();
            }
            else if(ortalama<=100 && ortalama >= 90)
            {
                Console.WriteLine("TEBRİKLER DERECE YAPTINIZ..ORTALAMANIZ:" + ortalama);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("hatalı not girişi yaptınız!!!");
                Console.ReadLine();
            }

        }
    }
}
