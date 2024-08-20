using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Sanal_Metot
{
    public class Urun:BaseClass
    {
        public override void ekranayaz(string data)//override yazdıktan sonra override edebileceğin metotlar çıkar biz burda baseclasstaki ekranayazı seçtik
        {
            Console.WriteLine("ürün->"+data);
        }
    }
}
