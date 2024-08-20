using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //merhabaHataYonetimi();
            hataYakalama();
        }
        //static void merhabaHataYonetimi()
        //{
        //    Console.Write("Bir Sayı Girin :");
        //    int sayi1=int.Parse(Console.ReadLine());
        //    //Burada kullanıcıdan bir integer değer bekliyoruz ancak kullanıcı string değer girerse hata alıyoruz
        //}

        static void hataYakalama()
        {
            try
            {
                //normal kodumuzu kullandığımız,yazdığımız bloktur.
                Console.Write("Bir Sayı Girin :");
                int sayi1 = int.Parse(Console.ReadLine());
            }
            catch (FormatException fx)//format exception yanlış tuş girimi hatasıdır.
            {
                Console.WriteLine("Sizden beklenen değer sayısaldır!");
                Console.WriteLine(fx.Message);
            }
            catch (Exception ex)//exception nesnesi tüm hataların olduğu nesnedir yani hata yönetiminde base classtır.
            {
                Console.WriteLine("Herhangi bir hata oluştu.");
                Console.WriteLine(ex.Message);//aldığımız hatayı konsola da yazdırdık.
                //catch bloğu ise sistem içinde çalışma zamanında alınan hataların
                //loglanmasına ve kullanıcıya daha açıklayıcı hata mesajları vermemize yarayan bloklardır.
                throw;
            }
            finally
            {
                //try kısmında bizim kodlarımız çalışır.
                //catch kısmında hata yönetimini yaparız.
                //finally kod tarafında herhangi bi hata almasak da alsak da finally kısmı çalışmaya devam eder.
                Console.WriteLine("finally bloğu çalıştı");
            }
           
            Console.WriteLine("Uygulama bitti...");
            Console.ReadLine();
        }

    }
}
