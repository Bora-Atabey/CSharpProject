using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstract
{
    public class Musteri:temelsinif
    {
        public int id { get; set; }
        public Musteri()
        {
            id = 3123;
        }

        public override void testAbstract()//bu şekilde abstract classtaki body'sini tanımlayamadığımız metodu burda override etmek ZORUNDAYIZ.
        {
            Console.WriteLine("müşteri sınıfının içerisindeki test abstract metodudur.");
        }
    }
}
