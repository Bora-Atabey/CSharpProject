using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Sanal_Metot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * sanal metotlar çağırdığımızda default haliyle gelir ancak istersek değiştirebiliyoruz.
             * 
             * Object-->ToString();
             * 
             */
            //Musteri m1= new Musteri();
            //m1.isim = "Bora";
            //m1.soyisim = "Atabey";
            //m1.musteriId = 29;
            //string mesaj =m1.ToString();//standart davranışı---->OOP_Sanal_Metot.Musteri    //değiştirdğimizde ise-->Bora Atabey
            //Console.WriteLine(mesaj);
            //Console.ReadLine();

            Urun u1= new Urun();
            u1.ekranayaz("merhaba");//burda override edilmiş haliyle çalıştı
           
            BaseClass b1= new BaseClass();
            b1.ekranayaz("merhaba");//burda default halde çalıştı

           



        }
    }
}
