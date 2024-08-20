using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_sınıflar
{
    internal class Program//internal erişimcisi o namespace'in içindekilerin erişmesine izin verir.
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();//oluşturduğumuz classtan nesne oluşturma
            m1.isim = "Bora";//public olarak açtığımız string isim'i çağırabildik ve değer ataması yaptık.
            m1.soyisim = "Atabey";
            m1.cinsiyet = 717770001;
            m1.tcKimlikNo = "19037226000";

            Musteri m2 = m1;//m1'le aynı bölgeye bakıyorlar heap'te değerleri de aynı oluyor.

            m2.isim = "Canburak";//burda m2'in değerini değiştirince m1'in de isim değeri değişir aynı bölgeye baktıkları için.

            m2 = null;//null yaptığımızda m2'in görüşünü kesmiş gibi oluruz. yani veriler silinmez m1 hala üstteki değerleri gösterir ancak
            //m2 artık null gösterir(yani bişey göstermez).
            

            //m1'i de nulla çekersek heap bölgede olan veri kümesini gösteren bir nesne olmaz ve bu nesne ramden garbage collector'a düşer.



        }
    }
}
