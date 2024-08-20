using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kalıtım_Odev
{
    public class BaseClass
    {

        public static int sayac = 1;//ilk oluştuğu zaman 1 değerini otomatik olarak alsın
        public BaseClass()
        {
            _id = sayac;
            sayac = sayac + 1;
        }
        private int _id;
        public int id {
            get     
            {
                return _id;
            } 
            private set 
            {
                //_id = sayac;
                //sayac = sayac + 1;---->böyle yapınca gelmedi çünkü yapıcı metotta yapmamız lazım burda değeri göremiyor uygulama

            } 
        }//kontrol olacak
        public string barkod {
            get
            {
                return this._barkod;
            }
            set
            {
                bool kontrol = SanalDataBase.dbBarkodKontrol(value);//gelen değerin sanal database'de var olup olmadığının kontrolü
                if (!kontrol)//değerin sanal database'inde bulunamamasıyla birlikte bu blok çalışacak
                {
                    this._barkod = value;
                }
                else
                {
                    Console.WriteLine("girdiğiniz barkod sistemde zaten kayıtlı!!");
                }
            }
        }//kontrol olacak
        private string _barkod;
        public DateTime olusturmaTarih { get; set; }

        public int olusturanKullanici { get; set; }
        public DateTime guncellemeTarih { get; set; }
        public int guncelleyenKullanici { get; set; }
        public bool silindi { get; set; }

    }
}
