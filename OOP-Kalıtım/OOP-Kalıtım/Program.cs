using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kalıtım
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kalıtım,bir nesneden nesne türetme işidir.Obejct nesnesi her nesnenin atasıdır.Yani her nesne objectten kalıtılır.

            
            //Ogrenci o1= new Ogrenci();
            //o1. yaptığımız zaman sadece oluşturduğumuz nesnenin ilgili yapıları değil object türünün uygun olan yapılarını da görürüz.
            //bu da kalıtımın bir sonucudur.
            Egitmen e1= new Egitmen();

            //e1. yaptığımızda egitim classını temelTip classından kalıttığımız için temeltipdeki fieldları da görebiliyoz


            //kalıtılan fielddaki bir değere random bi değer atamak istiyorsak bunu o classın(burda temelTip) içinde yapmak
            //en doğrusu olur böylece o değeri diğer kalıttığımız yerlerde de kullanabiliriz.


            object o1 = e1;//boxing
            e1=(Egitmen)o1;//unboxing

            /*Özel tiplerde boxing-unboxing işlemleri
             * 
             * bizim object nesnemiz nedir?--> temelTip
             * 
             *  temelTip t1;
             *  t1=e1;---> hata alınmaz çünkü egitmen classı temeltip'ten türediği için onun alt fieldlarını kapsar.
             * 
             * e1=(egitmen)t1---->bu şekilde unboxing yaparsak doğru olur
             */

            //----------------------------------------------------------------------------------------------

            //İstiyoruz ki türemiş olan tiplerim türeyemesin..
            //object-->temeltip-->Personel-->X
            //                 --> Ogrenci-->X
            //                 --> Egitmen-->X

            //Test t1= new Test();
            //t1.-->yaptığımızda temeltipin ve ogrencinin metotlarına fieldlarına erişebiliyoruz çünkü testi eğitmene bağladık.ancak bunu istemiyoruz

            //kalıtılmasını istemediğimiz classı(burda öğrenci)-->Ogrenci sealed ile kalıtılmasını engelleriz

            /*
             *  public: uygulamamızın içerisinde veya dışarısında ulaşılabilir anlamı taşır.
             *  private: sadece tanımlandığı class içerisinde erişilebilir olur.
             *  protected: normal kullanımda private olarak davranır.ancak kalıtım yoluyla çağırıldığında public işlevi görür.
             */

            //temelTip t31= new temelTip();
            //t31.TemelTipTestMetot2();//yapamıyoruz çünkü protected.



        }
    }
}
