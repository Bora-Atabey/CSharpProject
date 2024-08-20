using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Döngüler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* -FOR-
             * 
             * for (başlangıç değeri ; şart ; artırma veya azaltma işlemi){}
             * 
            int toplam=0;
            int i = 0;
            for (i = 0; i <= 100; i++) {
                if (i % 2 == 0)
                {
                    toplam += i; //1den 100'e kadar(100 dahil) olan çift sayıların toplamı.        
                }         
            }
            Console.WriteLine("1'den 100e kadar olan çift sayıların toplamı : " + toplam);
            Console.ReadLine();
            */

            //------------------------------------------------------------------------------------

            /* -kullanıcının girdiği sayının faktöriyelini alan uygulama-
             *

            int i=1,fakt=1;

            Console.Write("Faktöriyelini alınmasını istediğiniz sayıyı girin: ");
            string sayi = Console.ReadLine();
            int dgstr = Convert.ToInt32(sayi);


            if (dgstr >= 0)
            {
                for (i = 1; i <= dgstr; i++)
                {
                    fakt *= i;
                }
                Console.WriteLine(dgstr + " sayısının faktoriyeli: " + fakt);
                Console.ReadLine();
            }
            else
            {

                Console.WriteLine("negatif değer giremezsiniz!!!!");
                Console.ReadLine();
            }
            */
            //------------------------------------------------------------------------------------

            /*
             * Break:döngüyü kırar ve program alttaki bloktan devam eder.
             * 
             * Continue:bu kelime geldiği zaman şart sağlandığında alttaki blokları umursamaz ve döngüye
             * geri dönüp sonraki aşamadan devam eder.
             */

            //------------------------------------------------------------------------------------

            /*    -ÇARPIM TABLOSU PROGRAMI-İÇ İÇE FOR DÖNGÜSÜ-
            int i = 0, j = 0,carpim;

            for (i = 1; i <= 9; i++)
            {
                for(j=1; j <= 9; j++)
                {
                    carpim = i * j;
                    Console.Write("{0}*{1}:{2}\t",i,j,carpim);    
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
            */

            //-------------------------------------------------------------------------------------

            /* -WHILE-
             *

            int i = 0;

            while (i < 10)//şart true olduğu sürece döngü devam eder.false dönünce döngü biter.
            {
                Console.WriteLine("naber müdür");
                i++;
            }
            Console.ReadLine();      
            */
            //-------------------------------------------------------------------------------------

            /* sistemin tuttuğu sayıyı(1 ve 10 arası) kullanıcının bilene kadar sayı girdiği program.

            int sistemUretSayi = 0;
            Random rnd = new Random();
            sistemUretSayi = rnd.Next(1, 10);//ilerde görücez,rastgele sayı üretme.

            while (true)
            {
                Console.WriteLine("Tahmin sayınızı girin:");
                string kullaniciTahmin = Console.ReadLine();
                int tahminSayi = Convert.ToInt32(kullaniciTahmin);

                if (tahminSayi == sistemUretSayi)
                {
                    Console.WriteLine("tebrikler doğru tahmin");
                  Console.ReadLine();
                    break;                  
                }              
            }
            
            */

            //-----------------------------------------------------------------------------------

            /* -DO WHILE-
             * 
             * şart ne olursa olsun döngüyü bi kere döndürür eğer şart sağlanmıyorsa çıkar.

            do
            {
                Console.WriteLine("naber");
            }
            while (1 == 2);//bir kere ekrana naber yazar. 

            //-------------------------------------------------------------------------------------

            int i = 1;   //Kullanıcıdan "Demo" adı ve "Demo" şifresi alana kadar giriş yapmasını isteyen uygulama

            while (true)
            {
                Console.Write("Kullanıcı adını girin: ");
                string adStr = Console.ReadLine();
                Console.Write("Şifrenizi girin: ");
                string sifreStr = Console.ReadLine();

                if (adStr=="Demo" && sifreStr == "Demo")
                {
                    Console.WriteLine("Tebrikler giriş başarılı...");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Giris basarisiz lutfen tekrar deneyin! Deneme sayınız:{0}",i);
                }

                i++;
            }
            */


        


            








        }
    }
}
