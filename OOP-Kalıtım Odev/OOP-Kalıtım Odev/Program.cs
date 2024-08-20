using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kalıtım_Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bilgisayar b1= new Bilgisayar();
            //b1.id = 1; //girmek istmeiyorum,uygulamanın bana bu alanı set edilebilir şekilde bırakmasını da istemiyorum.
            b1.marka = "Asus";
            b1.model = "Tuf Gaming";
            b1.islemci = "ryzen7";
            b1.alisFiyat = 20000M;
            b1.satisFiyat = 35000M;
            b1.kampanyaFiyat = 25000M;
            b1.barkod = "386738457";

            SanalDataBase.YeniUrunEkle(b1);

            Bilgisayar b2 = new Bilgisayar();
            
            b2.marka = "Lenovo";
            b2.model = "Z125";
            b2.islemci = "intel5";
            b2.alisFiyat = 20000M;
            b2.satisFiyat = 35000M;
            b2.kampanyaFiyat = 25000M;
            b2.barkod = "386738457";//barkodu aynı bıraktık ki hatayı görelim diye
            SanalDataBase.YeniUrunEkle(b2);

            

        }
    }
}
