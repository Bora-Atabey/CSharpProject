using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3_odev_
{
    public class Musteri
    {

        static ArrayList musteriDatabase;
        static Musteri()
        {
            musteriDatabase = new ArrayList();

        }
    

        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string emailAdres { get; set; }
        public string sifre { get; set; }

        private string kullaniciAdi;

        public string _kullaniciAdi
        {
            get { return this.kullaniciAdi; }

            set
            {
                bool kontrol = kullaniciadiKontrol(value);
                if (kontrol)
                {
                    Console.WriteLine("Eklemek istediğiniz kullanıcı adı sistemde var");
                    this.kullaniciAdi=string.Empty;
                }
                else
                {
                    this.kullaniciAdi = value;
                }


            }
        }
        static bool kullaniciadiKontrol(string kullaniciAdi)
        {
            bool bayrak = false;
            for(int i = 0; i < musteriDatabase.Count; i++)
            {
                Musteri temp=(Musteri)musteriDatabase[i];//arraylistteki obje tipini oluşturduğumuz nesneye çevirme
                if (temp.kullaniciAdi == kullaniciAdi)
                {
                    bayrak = true;
                    break;
                }
            }
            return bayrak;
        }
        public static void MusteriEkle(Musteri M)
        {
            if (M != null && !string.IsNullOrEmpty(M.kullaniciAdi) && !string.IsNullOrEmpty(M.emailAdres))//nesnenin kullanıcı adı ve mailinin dolu olduğnun kontrolü
            {
                bool mailkontrol =MusteriMailKontrol(M.emailAdres);//mail kontrolden döndüğümüz true veya false değeri
                if (mailkontrol)
                {
                    Console.WriteLine("Eklemek istediğiniz kullanıcı sistemde var");
                }
                else
                {
                    musteriDatabase.Add(M);
                    Console.WriteLine("Yeni kayıt işlemi başarılı");
                }
            }

        }
        static bool MusteriMailKontrol(string adres)
        {
            bool mailkontrol = false;
            for (int i = 0;i<musteriDatabase.Count ; i++)
            {
                Musteri Temp = (Musteri)musteriDatabase[i];//arraylistteki obje tipini oluşturduğumuz nesneye çevirme
                if (Temp.emailAdres == adres)
                {
                    mailkontrol = true;
                    break;
                }

            }
            return mailkontrol;
        }
    }
}
