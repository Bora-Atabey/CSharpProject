using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inner_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ilişkisel veri tabanına benzer.örneğin bir müşteri nesnesi oluşturduğumuzda ismi,
             *soyismi,id'si gibi unique değerleri olabilirken adres,tel no gibi farklı değerler alabilen 
             *değeri de olabilir.
             *
             *Müşteri nesnesi içinde custom oluşturduğumuz nesneleri(adres,tel no vb.) çağırdığımız zaman bir inner type
             *işlemi yapmış oluruz*/

            Musteri m1= new Musteri();
            m1.id = 1;
            m1.tckimlikno = "19037226000";
            m1.isim = "Bora";
            m1.soyisim = "Atabey";
            m1.olusturmaTarih = DateTime.Now;

            //m1.musteriAdresBilgileri = new MusteriAdres[5]; ---->böyle inner type'ı örnekleyebiliriz ama tercih edilmez.

            m1.musteriAdresBilgileri[0] = new MusteriAdres()
            {
                il = "İstanbul",
                ilce = "Beylikdüzü",
                adres = "Barış Mah. Ada Çifltiği Cad. Melodi Apt. No:9 Kat:2 Daire:12",
                adresTip = "Ev"

            };

            m1.musteriAdresBilgileri[0].MusteriAdresTestMetot();//m1e ulaştık onun adres bilgileri inner type'ının 0. indeksindeki bilgiyi işaret ettik sonra metotu çağırdık.
            m1.musteriUrunBilgileri[0] = new MusteriUrun()
            {
                urunAdi = "Steel Series mouse",
                urunFiyat = 900,
                urunSKT = DateTime.Now,
            };






            
        }
    }
}
