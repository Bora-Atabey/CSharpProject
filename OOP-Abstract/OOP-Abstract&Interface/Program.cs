using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //temelsinif t1= new temelsinif();//örneklenemez abstract olduğu için.
            Musteri m1= new Musteri();//böyle tanım yapınca 
            m1.testAbstract();
            Console.ReadLine();
            
            SuperMusteri sm1= new SuperMusteri();
            sm1.testAbstract();//burda direkt çağırabiliyoruz çünkü müşteriden kalıttık supermusteriyi.
            
        }
    }
}
