using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_ve_Parse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Convert-Parse işlemi bir stringde tutulan sayıyı int değişkenine aktarma şeklinde olur.

            string metin1 = "100";
            int degistir = int.Parse(metin1);//stringi alıp integer'a çevirir
            int degistir2=Convert.ToInt32(metin1);//aynı işlem

            string metin2 = "True";
            bool cevir=bool.Parse(metin2);//stringi alıp boolean'a çevirir
            bool cevir2=Convert.ToBoolean(metin2);//aynı işlem

/*convert ve parse arasındaki fark ise bir değiştirme işleminde değer null ise yani boşsa parse işleminde program hata
 * verirken convert işleminde hata vermeyip atanmaya çalışılan değişkenin default değerini verip devam eder.*/

        //convert kullanmak daha avantajlı!



        }
    }
}
