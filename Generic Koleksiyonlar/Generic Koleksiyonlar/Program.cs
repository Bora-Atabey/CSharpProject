using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //arraylistin generic versiyonu

            ArrayList l1 = new ArrayList();
            l1.Add(1);
            l1.Add("bir");


            // <T> tipi demek .net framework içerisinde veya bizim oluşturduğumuz herhangi bir tip anlamına gelir.

            List<int> listegeneric = new List<int>();
            listegeneric.Add(1);
            listegeneric.Add(2);
            //listegeneric.Add("uc");

            List<string> isimler = new List<string>();

            isimler.Add("Bora");
            isimler.Add("Kuzey");
            //isimler.Add(3563);


            //oluşturduğumuz nesne ile list içine yazma.

            List<Musteri> nesneliste = new List<Musteri>();

            nesneliste.Add(new Musteri()
            {
                id = 1,
                isim = "Bora",
                soyisim = "Atabey"
            });

            for (int i = 0; i < listegeneric.Count; i++)//generic listenin içindekileri görme
            {
                Console.WriteLine(listegeneric[i]);
            }

            //------------------------------------------------------------------------------

            List<int> sayilar = new List<int>();

            int[] dizi = new int[5];
            dizi[0] = 1;
            dizi[1] = 2;
            dizi[2] = 3;
            dizi[3] = 4;
            dizi[4] = 5;

            sayilar.AddRange(dizi);

            int sayi = sayilar.Count;
            int kapasite = sayilar.Capacity;

            sayilar.ForEach(i => Console.WriteLine(i));//delege konusu ilerde gelicez sadece bu şekilde değer yazılabileceğini bil.
            //ilgili koleksiyon içerisinde arama yap...
            // => linq konusu.


            int deger = sayilar[3];
            Console.WriteLine("list<T> koleyksiyonu içerisinde 3. indekste bulunan değer: " + deger);


            sayilar.Insert(5, 150);//ilkine indeksi ikincisinde de verilecek değeri alır ancak değer silmez arasına ekler.yani 3teki 4 olur devam eder.


            bool kontrol1 = sayilar.Any();//koleksiyon içinde bir değer varsa true,yoksa false döndürür.
            bool kontrol2 = sayilar.Any(i => i > 5);//koleksiyon içinde 5den büyük değer varsa true döndürür.


            sayilar.Sort();//a-z veya 1-n doğru bir sıralama yapar.
            sayilar.Reverse();//z-a sıralama

            sayilar.Remove(150);//içine yazılan değeri bulup siler.
            sayilar.RemoveAll(i => i > 50);//50den büyük olan tüm değerleri siler.
            sayilar.RemoveAt(0);//içerisindeki indeksi siler.

            sayilar.Max();//en yüksek değeri verir
            sayilar.Min();//en düşük değeri verir
            sayilar.Sum();//sayıların toplamını verir.

            // DICTIONARY VE SORTED LIST KOLEKSİYONLARI

            // Dictionary<TKey,TValue> şeklinde olur

            Dictionary<int, string> diclist = new Dictionary<int, string>();//hashtable gibi bir unique key değeri bir de onun karşılığı olur.biz içerde belirleriz o değeri

            diclist.Add(1, "Bir");
            diclist.Add(2, "İki");
            diclist.Add(3, "Üç");

            bool silmesonuc = diclist.Remove(1);//key değeri alır boolean döner eğer keyi bulup silerse true yoksa false döner;
            if (silmesonuc)
            {
                Console.WriteLine("değer başarıyla silindi");
            }
            else
            {
                Console.WriteLine("böyle bir key değeri bulunamadı.");
            }
            Console.ReadLine();

            bool keykontrol = diclist.ContainsKey(3);//key değerini arar varsa true döner yoksa false.
            if (keykontrol)//değer varsa onu değiştirdik yoksa ekrana bulunamadı yazdırdık
            {
                string gelendeger = diclist[3];
                gelendeger = "merhaba";
                diclist[3] = gelendeger;
                Console.WriteLine(gelendeger);
            }
            else
            {
                Console.WriteLine("aranan değer koleksiyon içerisinde bulunamadı");
            }
            Console.ReadLine();

            bool valuekontrol=diclist.ContainsValue("merhaba");//değeri arar bulursa true yoksa false döner.
            if (valuekontrol)
            {
                Console.WriteLine("aranan değer bulundu");
            }
            else
            {
                Console.WriteLine("aranan değer bulunamadı");
            }
            foreach(KeyValuePair<int,string>items in diclist)//keyleri ve valueleri dönen bölüm
            {
                Console.WriteLine("Anahtar: {0} || Değer:{1}",items.Key,items.Value);
            }
            //SORTEDLIST
            SortedList<int,string> sorlist= new SortedList<int,string>();//dictionary'nin tüm işlemleri yapar ancak keylere göre sıralar.
            sorlist.Add(1, "bir");
            sorlist.Add(150, "yüzelli");
            sorlist.Add(5, "beş");
            sorlist.Add(12, "oniki");
            sorlist.Add(1000, "bin");





        }
    }
}
