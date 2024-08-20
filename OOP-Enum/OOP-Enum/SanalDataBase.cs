using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Enum
{
    public class SanalDataBase
    {
        ArrayList sanaldb=new ArrayList();

        public MusteriReturnValue yeniKayit(Musteri m)//enum dönüşü yapmak için böyle yazılır
        {
            sanaldb.Add(m);
            return MusteriReturnValue.kayitBasarili;
        }
       




    }
}
