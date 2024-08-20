using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kalıtım
{
    public sealed class Ogrenci:temelTip//sealed anahtar sözcüğü dışarıdan erişilebilir,
                                        //ancak bundan bir class kalıtılamaz demek.
    {
        public Ogrenci()
        {
            //TemelTipTestMetot2();--->protected olarak işaretlendiği için ve bu nesne temeltipten kalıtıldığı için çalıştı       
        }
        public string bolum { get; set; }
        public int sinif { get; set; }

    }


}
