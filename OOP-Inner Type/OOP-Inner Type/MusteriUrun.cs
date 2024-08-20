using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inner_Type
{
    public class MusteriUrun
    {
        public string urunAdi { get; set; }
        public decimal  urunFiyat { get; set; }
        public DateTime urunSKT{ get; set; }

        public void MusteriUrunBilgileriTestMetot()
        {
            Console.WriteLine("müşteri ürün bilgileri test metodu");
        }
    }
}
