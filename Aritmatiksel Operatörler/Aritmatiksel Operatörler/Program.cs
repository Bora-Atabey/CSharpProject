using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aritmatiksel_Operatörler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*-TOPLAMA(+)-
             * int + int (toplama işlemi yapar)
             * string+int veya string+int veya string+string (string döner)
             

            int a, b,toplam;
            a = 16;
            b = 74;
            toplam = a + b;
            Console.WriteLine("toplam:"+toplam);
            */

            //--------------------------------------------------------------


            /* -ÇIKARMA(-)-
             * byte,int,float,double,decimal değişkenlerinde kullanılabilir.
             

            decimal s1, s2, sonuc;

            s1 = 45.102m;
            s2=44.267m;
            sonuc = s1 - s2;
            Console.WriteLine(sonuc);
            */

            //------------------------------------------------------------------

            /* -ÇARPMA(*)-
             byte,int,double,float,decimal değişkenlerinde kullanılabilir.

            int sayi1 = 60;
            int sayi2 = 2;
            int carpim = sayi1 * sayi2;
            Console.WriteLine(carpim);


            double a,b;
            a = 10.6;
            b = 12.9;
            int sonuc = (int)(a * b);//çarpımı yapar ve tam sayı kısmını alır.

            Console.WriteLine(sonuc);
            Console.ReadLine();*/

            //--------------------------------------------------------------------

            /* -BÖLME(/)-
             * byte,int,double,float,decimal değişkenlerinde kullanılabilir.
             *
            int s1 = 8;
            int s2 = 2;
            int sonuc=s1/s2;
            Console.WriteLine(sonuc);*/

            //---------------------------------------------------------------------

            /* -MOD(%)-
             * Bölümden kalanı bulmak için kullanılan operatör.
             *
            int s1 = 5;
            int sonuc = s1 % 2;*/


            //-------------------------------------------------------------------

            /*   "++" operatörü
             *   int i=5;
             *   int sonuc1= i++;----->burda önce i değerini sonuc1'e atar sonra değeri 1 arttırır.


            int j=5;
            int sonuc2=++j;----->burada ise önce değeri bir arttırır sonra atama işlemi yapar.



        }
    }
}