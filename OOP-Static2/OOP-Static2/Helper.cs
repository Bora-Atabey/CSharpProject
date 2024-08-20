using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Static2
{
    public static class Helper
    {
        //!!!!Statik classların nesne örneği alınmaz!!!
        // Helper h1=new Helper();--->yapamam
        /*
         *  public void yardım()
        {

        }
         * static classların içinde standart metotlar kullanılmaz yukardaki gibi.
         * aynı şekilde static olmayan field tanımı da yapılmaz. 
         *
         *Static yapıcı metot yazmak istiyorsak;
         *
         *static Helper()
         *{
         *  ----->uygulama içerisinde istediği kadar çağırılsınlar yanlızca bir ker çalışır.
         *}
         *
         *şeklinde tanımlayabiliriz.
         */
        public static void emailGonder(string aliciAdres, string konu, string icerik)//static metot sadece teorik,bir işlem yok
        {
            //email işlemleri...
            Console.WriteLine("Mail gönderim işlemi başarılı");
        }


    }
}
