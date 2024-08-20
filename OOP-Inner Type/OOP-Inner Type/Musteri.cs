using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inner_Type
{
    public class Musteri
    {
        #region TEKİL OLARAK KULLANILAN FIELD'LAR
        public int id { get; set; }
        public string tckimlikno { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime olusturmaTarih { get; set; }
        public int kullaniciId { get; set; }
        #endregion
        #region INNER TYPE GEREKTİREN FIELD'LAR

        public MusteriAdres[] musteriAdresBilgileri;//bu şekilde diğer classtaki bilgilere erişim sağlayabiliyoruz.
        public MusteriIletisim[] musteriIletisimBilgileri;
        public MusteriUrun[] musteriUrunBilgileri;
        #endregion
        public Musteri()
        {
            musteriAdresBilgileri= new MusteriAdres[5];//diğer classı tanımlama işlemini ana classta yapıcı metotta yapmak en sağlıklısı
            musteriIletisimBilgileri = new MusteriIletisim[5];
            musteriUrunBilgileri=new MusteriUrun[5];
        }
      
    }
}
