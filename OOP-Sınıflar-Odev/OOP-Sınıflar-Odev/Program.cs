using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Sınıflar_Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //araç nesnesi oluşturulacak.Marka-Model-ModelYıl-Km-YakıtTipi-VitesTipi-AlısFiyat-SatısFiyat-MaxIndirimTutar-Fiyat
            //Marka Model
            //Marka Model ModelYıl 
            //Marka Model ModelYıl Km
            //şeklinde yapıcı metotlar olacak
            //void bilgileriGoruntule() 
            //Void fiyatAta(fiyat) 
            //şeklinde metotlar olacak fiyatata'da satışfiyat-maxindirimtutarı şeklinde


            Araç a1=new Araç("Honda","Civic",2014,10000);
            a1.alisFiyat = 875000;
            a1.satisFiyat = 900000;
            a1.maxIndirimTutari = 20000;
            a1.bilgileriGoster();
            a1.FiyatAta(888000);
            Console.ReadLine();







        }
    }
}
