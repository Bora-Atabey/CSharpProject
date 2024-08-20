using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot_ödev
{
    public class Ogrenci
    {
        public void OgrenciSelamla() {
            Console.WriteLine("---Öğrenci Not Sistemine Hoşgeldiniz---");
            Console.WriteLine("---Bu sistemde 3 notunuz alıp ortalamanız alınacaktır ve geçip geçmediğiniz söylenecektir---");
            
        }

        public decimal OrtalamaHesapla(decimal not1, decimal not2, decimal not3) {

            
            return (not1 + not2 + not3) / 3;

        }


    }
}
