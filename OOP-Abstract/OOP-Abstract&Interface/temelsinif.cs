using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstract
{
    public abstract class temelsinif//abstract veya interface yapıldığında bir şablona çevirirz classın dışına çıkar aynı zamanda örneklenemez
    //şablonu da başka bir sınıfta kullanırsın
    //sealed kullanılamaz.
    {

        public DateTime kayitTarih { get; set; }
        public DateTime guncellemeTarih { get; set; }
        public temelsinif()//abstract yaptığımız için yapıcı metodu da çalışmaz ancak başka bir classa kalıtırsak onda çalışacağı için sadec onun için çalışır
        {
            kayitTarih = DateTime.Now;
            guncellemeTarih=DateTime.Now;
        }
        public abstract void testAbstract();
        //{--->abstract metotların body'leri olmaz.
        //}

    }
}
