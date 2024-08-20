using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alıştırma_Aritmetik_Operatör
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //girilen iki sayıyı decimala çevirip toplamını,farkını,çarpımını,bölümünü ve modunu alan program.  
            string s1, s2;
            Console.Write("1.sayıyı girin : ");
            s1= Console.ReadLine();
            Console.Write("2. sayıyı girin : ");
            s2 = Console.ReadLine();

            Console.Clear();

            decimal dgs1=Convert.ToDecimal(s1);
            decimal dgs2=Convert.ToDecimal(s2);

            Console.WriteLine("Toplam : "+(dgs1+dgs2));
            Console.WriteLine("Çıkarma : "+(dgs1-dgs2));
            Console.WriteLine("Çarpım : "+(dgs1*dgs2));
            Console.WriteLine("Bölüm : "+(dgs1/dgs2));
            Console.WriteLine("Mod : "+(dgs1%dgs2));
            Console.ReadLine();
        }
    }
}
