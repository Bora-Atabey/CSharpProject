using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //static: nesne örneği alınmadan ulaşabildiğimiz metot,field veya sınıf olabilir.
            // tip değişken adı= new tip(); ----->bu şekil hep tanılama yapıyoz.
            //tip.(static fieldın metotlarını çağırabiliyoz)


            StaticOgrenci ogr;//stack bölge içinde pointerımız oluştu.

            //stack bölgede pointer oluştuğu zaman static olan bir yapıcı metot çalıştı ve yine classta tanımlı olan static field,
            //metot,static dediğimiz bölgede oluşturuldu.

            StaticOgrenci.Test2();

            ogr=new StaticOgrenci();//stack bölgede açılan pointer kendisini heap bölgede tamamladı.static olmayan tanımlarını tamamladı

            ogr.Test1();//nesne örneği alındıktan sonra test1 metoduna ulaşabildik

            /*-STATIC VE RAMDEKİ MANTIĞI-
             * Yeni classla bir ogr pointerı oluşturduğumuzda ramin stack bölgesinde bir pointer oluşur.Static tanımıyla oluşturduğumz 
             * fieldlar veya metotlara bu pointer üzerinden ulaşamayız.o pointer sadece heap bölgedeki veri yığınına ulaşabilir.
             * class adıyla ancak static bölgedeki metotlara veya fieldlara ulaşabiliriz
             * 
             * StaticOgrenci.blabla---->burda static bölgedeki yerlere ulaşabiliyoruz
             * ogr.blabla---->burda da heapdeki yerlere ulaşabiliriz
             *  
             */            

        }
    }
}
