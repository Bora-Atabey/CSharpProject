using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Değişkenler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* -STRING-
             String değişkeni metinsel karakterleri tutar.

             string isimSoyisim = "Bora Atabey";
            Console.WriteLine(isimSoyisim);----->ekrana Bora Atabey yazdırır.*/

            //--------------------------------------------------------------------------------------

            /* -CHAR-
               Char değişkeni metinsel tek bir karakteri tutar.
            A B C D E F 1 2 3 ...

            char harf;
            harf = 'A';
            Console.WriteLine(harf);--------> ekrana A yazdırır. */

            //--------------------------------------------------------------------------------------

            /*-INT VE BYTE-
             Int ve Byte tam sayılar içindir.
            0 <byte< 255       -2147483648 <int< 2147483647     

        
            int deger1 = 59;
            byte deger2 = 37;

            int enKucukDeger = int.MinValue;
            int enBuyukDeger=int.MaxValue;
            Console.WriteLine(enBuyukDeger);
            Console.WriteLine(enKucukDeger); */

            //---------------------------------------------------------------------------------------

            /* -DOUBLE,FLOAT VE DECIMAL-
              
              ondalıklı değerleri tutmaya yarar.float ve decimalde atama sonunda f(float) ve m(decimal) yazmak gerekli
            ancak double'da gerekmez.
            
             
             


            double ondalik1 = 3.14;
            double ondalik1 = 3.14d;------>böyle de olur ama zorunlu değil.

            decimal ondalik2 = 79.4m;------>böyle yazım zorunlu.

            float ondalik3 = 84.7f;------->böyle yazım zorunlu.    */


            //----------------------------------------------------------------------------------------

            /* -BOOLEAN-
              iki değer döner.0 ve 1 . evet veya hayır.
              
             
            bool kullaniciSonuc=false;
            kullaniciSonuc = true;

            bool deger; --->default değeri false'dur. */


            //-----------------------------------------------------------------------------------------


            /* -DATETIME-
             tarih ve saat saklama işlemi yapılır.
            

            DateTime suanZaman= DateTime.Now;
            Console.WriteLine(suanZaman);------->compile edildiğindeki zamanı gösterir.*/


            //-----------------------------------------------------------------------------------------


            /* -OBJECT-
             * 
             * içine birçok değişken ve custom classları alan tiptir.Tüm değerlerin min değerinden daha min,
             * max değerinden daha max değer alır.

            object obj = 100;
            object obj2 = 10.95;

            */



        }
    }
}
