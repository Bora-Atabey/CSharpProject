using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Static
{
    public class StaticOgrenci
    {

        public string isim { get; set; }//hem field hem property yapmış olduk böyle.
        public string soyisim { get; set; }
        public string emailadres { get; set; }

        public void Test1()
        {
            Console.WriteLine("Nesne örneği alındıktan sonra çalışan metot");
            Test2();//static olmayan bir metot static metotu çağırabilir.


        }

        public static void Test2()
        {
            Console.WriteLine("Nesne örneği ALINMADAN kullanılabilir.");
        }




    }
}
