using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Class
{
    public class MusteriGeneric<T>//örneklenirken bu t tipini de belirtmek durumundayız.
    {
        public T id { get; set; }
        public T musteriNo { get; set; }//bu fieldı alırken t tipi şeklinde almış oluruz.
        public string tcKimlikNo { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime dogumTarih { get; set; }


         public T musteriNumarasiAl()
        {
            return musteriNo;
        }

    }
}
