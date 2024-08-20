using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inner_Type
{
    public class MusteriIletisim
    {
        public int iletisimTip { get; set; }//717770001: Mobil - 717770002: Sabit hat
        public string  alankodu { get; set; }
        public string numara { get; set; }
        public bool aktiflikDurum { get; set; }
        public void MusteriIletisimTestMetot()
        {
            Console.WriteLine("Müşteri iletişim bilgileri test metot ");
        }
    }
}
