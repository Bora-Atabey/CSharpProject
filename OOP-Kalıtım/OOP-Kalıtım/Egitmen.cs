using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kalıtım
{
    public class Egitmen : temelTip //temelTip fieldları egitmen classı tarafından kullanılabilsin,kalıtılsın demek
    {
        public string brans { get; set; }
        public int seviye { get; set; }
        public DateTime isBaslangicTarihi { get; set; }
        public DateTime isBitisTarihi { get; set; }
        public Egitmen()
        {
            Console.WriteLine("egitmen classının yapıcı metodu çalıştı");
        }

        
    }
}
