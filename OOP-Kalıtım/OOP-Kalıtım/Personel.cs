using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kalıtım
{
    public class Personel:temelTip
    {
        public DateTime isBaslangicTarihi { get; set; }
        public DateTime isBitisTarihi { get; set; }
        public int izinGunSayisi { get; set; }
        public Personel()
        {
            //TemelTipTestMetot2();--->protected olarak işaretlendiği için ve bu nesne temeltipten kalıtıldığı için çalıştı
        }
    }
}
