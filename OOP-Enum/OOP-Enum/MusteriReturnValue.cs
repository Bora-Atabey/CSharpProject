using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Enum
{
    public enum MusteriReturnValue//enum bir integer değer alırlar verilmezse 0dan başlarlar enum kadar devam ederler.
    {
        kayitBasarili,
        kayitBasarisiz,
        varolanMusteri,
        parametreHatasi,
        calismaZamaniHatasi
    }
}
