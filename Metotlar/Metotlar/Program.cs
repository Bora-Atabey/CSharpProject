using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Namespace koca bir uzaydır içinde classları bulundurur.classların içinde de birden çok metot olabilir.
             * Uygulama main metodunda çalışır.
             * void kelimesi ile metod çalışır ama herhangi bi değer döndürmez.
             */


            Ogrenci o1= new Ogrenci();//bir nesne oluşturduk public class ile.
            o1.OgrenciSelamla();//nesneyi oluşturduk ve o classtaki ogrenciSelamla metodunu çağırdık.

            /*
             * [ErişimBelirleyicisi]<GeriDönüşDeğeri> MetotAdı (parametreler istenir[gerekirse])
             * {
             *   //metot için gereken kodlar...
             * }
             * 
             * -ERİŞİM BELİRLEYİCİLERİ-
             * Public : bu classa ulaşan herkesin metoda da ulaşabilir.
             * Private : İçerisinde bulunan class düzeyinde çağırılabilir.
             * Portected : Nesneler kalıtıldığında protected olarak kullanılabilir(OOP)
             * Internal : ilgili kütüphane içinde metoda ulaşılabilir.
             * Internal Protected : uyhulama içinde ve kalıtıldığında ulaşulabilir.
             */

            //Console.WriteLine("adınızı soyadınızı sırayla girin: ");
            //string ad= Console.ReadLine();
            //string soyad= Console.ReadLine();

            //Ogrenci isim=new Ogrenci();
            //isim.OgrenciMetot1(ad, soyad);


            //-------------------------------------------------------------------------------------

            //TOPLAMA ÇIKARMA ÇARPMA BÖLME YAPAN PROGRAM ANCAK CLASS VE METOT KULLANARAK
            /*
            Matematik islem = new Matematik();
            islem.menu();
            string istek=Console.ReadLine();
            int istekDgstr=Convert.ToInt32(istek);
            Console.Write("ilk sayiyi girin: ");
            decimal sayi1=Convert.ToDecimal(Console.ReadLine());
            Console.Write("ikinci sayiyi girin: ");
            decimal sayi2 = Convert.ToDecimal(Console.ReadLine());



            switch (istekDgstr) {
                case 1: 
                    Console.WriteLine("{0} ve {1}'in toplamı : {2}",sayi1,sayi2,islem.topla(sayi1, sayi2));
                    break;
                case 2: Console.WriteLine("{0} ve {1}'in farkı : {2}", sayi1, sayi2, islem.cikart(sayi1, sayi2)); 
                    break;
                case 3: Console.WriteLine("{0} ve {1}'in çarpımı : {2}", sayi1, sayi2, islem.carp(sayi1, sayi2));
                    break;
                case 4:
                    Console.WriteLine("{0} ve {1}'in bölümü : {2}", sayi1, sayi2, islem.bol(sayi1,sayi2));
                    break;
                default:
                    Console.WriteLine("yanlış tuş yabanzi");
                    break;

            }
            Console.ReadLine();
            */

            //----------------------------------------------------------------------------------------------

            /* RETURN->fonksiyonu çağırırken girdiğimiz değeri işlemler sonucunda geri gönderir.
             */

            //----------------------------------------------------------------------------------------------

            /*
             * eğer bir metot yazarken bir parametrenin değerini değiştirilebilir ancak girilmeyedebilir halde tutmak istiyorsak;
             * public void blabla(decimal deger1,decimal deger2 = 45)--->yani deger2 değeri girilmezse 45 olarak işlem yapılır.
             * eğer opsiyonel parametre kullanırsan en sonda tanımlaman gerekli(kural bra).
            */

            //------------------------------------------------------------------------------------------------

            /* REF-OUT KULLANIMI
             * main'deki bir parametreyi metotta referansıyla kullanmak için yazılır.veya tam tersi şeklinde de kullanım olur.
             * public void blabla(ref int a)
             * 
             *
             //işlemler...
             * 
             *
             main----> blabla(ref a);

            */

            //-------------------------------------------------------------------------------------------------

            /* PARAMS KULLANIMI
             * istediğimiz kadar parametre alma işine yarar.dizi şeklinde alır.params ifadeleri parametrelerin son ifadesi olmalıdır.
             * 
             */

           // topla(5, 9, 45, 62, 78, 21);



        }
       /* static void topla(params int[] sayilar)//params kullanımı
        {
            int toplam;
            for(int i=0;i< sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            Console.WriteLine("Toplam : "+toplam);
       */




        }
        
    }

