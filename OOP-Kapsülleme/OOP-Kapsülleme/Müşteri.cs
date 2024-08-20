using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kapsülleme
{
    public class Müşteri
    {

        public Müşteri()
        {
            this.id = IDUret();
            
        }
        private int id;//bunlara field denir  .'dan itibaren çıkan şeyler field'dır.
        //1.Field'a değer ataması yapılamasın ancak değer okunabilsin.
        public int ID//property yaparak private olan fieldımıza işlem yapıyoruz.
        {
            get
            {
                return this.id;
            }
            private set//böyle yaparsak set bloğu dış dünyada çalışmaz böylelikle 1. işlemi yapabiliriz.
            {
                this.id = value;
            }
        }
        public string isim;
        public string soyisim;

        private string emailadres;//bunu dış dünyadan değer döndürmek ama görüntülenemez yapmak istiyoruz.bunu PROPERTY ile yapıyoruz.

        public string EMailAdres//bu bir field olmaz property olur artık
        {
            //get;//database veya farklı bir veri kaynağı...classı çağıran programcıya datayı gösterdiğimiz kısım.
            //set;//dış dünyadan alınan datanın içeride private olarak saklanan field içerisine değer atandığı yer.

            set
            {
                this.emailadres = value;//set ettiğimiz değeri bu blokta private olarak belirlediğimiz field'a atadı.
            }
            get
            {
                return this.emailadres;//var olan değeri kullanıcıya geri döndürür.
            }
        }
        private int IDUret() //id değerini rastgele olarak belirleyen metot.
        { 
            Random rnd = new Random();
            return rnd.Next(10000, 90000);
        }
        private string _tckimlikno;
        public string TcKimlikNo
        {
            private get
            {
                return _tckimlikno;
            }
            set
            {
                if (value.Length == 11)//eğer girilen değer 11 ise işlemlere devam edicez çünkü tc kimlik no 11 haneli.
                {
                    bool kontrol = false;
                    for(int i = 0; i < value.Length; i++)//girilen valuenin uzunluğu kadar dönücez kontrol için
                    {
                        bool karakterKontrol=char.IsNumber(value[i]);//value değerinin her birinin sayı olup olmadığının kontrolü
                        if (karakterKontrol)
                        {
                            //sayısal değer demektir
                        }
                        else
                        {
                            kontrol = true;//sayısaldan farklı bir değer yakaladığımızda kontrolu true yapıp döngüyü kırarız.
                            break;
                        }
                    }
                    if (kontrol)//burada da bir değerimiz sayısaldan farklı olduysa true döndüğümüz kontrol değeri varsa onun işlemleri
                    {
                        Console.WriteLine("tc kimlik no sayısal değer olmalıdır.");
                    }
                    else
                    {
                        this._tckimlikno = value;//tüm kontrol işlemlerinden sonra değer ataması yaptık.
                    }
                }
                else
                {
                    Console.WriteLine("tc kimlik no 11 haneden farklı olamaz!!");
                }
              
            }
        }



    }
}
