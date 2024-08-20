using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*- KOLEKSİYONLAR-
            - object veri tipinden değer kabul ederler.yani her tipten değer tutabilirler.
            - dizilerdeki gibi bir eleman sınırı yoktur.koleksiyonlar kapasitesi dolduğunda kendi kendine arttırır.
            -Array List,HashTable,SortedList,Stack,Queue gibi alt başlıkları vardır. 

            //-------------------------------------------------------------------------------------
            

            ArrayList liste=new ArrayList();
            ArrayList liste2 = new ArrayList();

            liste.Add("Bora Atabey");//arrayliste tek bir nesne ekleme
            liste.Add(31);//her türden değer alabilir.

            liste2.Add("zort");
            liste2.Add("pırt");


            liste.AddRange(liste2);//birçok nesne koyulur. burda liste2'deki nesneleri liste'ye ekledik.

            // count:koleksiyondaki mevcut değer sayısını ifade eder.
            // capacity: koleksiyonun alacağı maksimum değeri gösterir.
            // örneğin içi boş olan bir arrayliste bir değer eklendiğinde count:1 olurken capacity:4 olur ve
            // capacity dolduğunda 4'erli şekilde artar.

            object a1 = liste[3];//liste içindeki bir değere ulaşma.object türünde tanım önemli!!!!

            liste[2] = "dıbzt";//bir indeksteki değeri değiştirme.

            liste.Remove("dıbzt");//elemanı silme.
            liste.RemoveRange(3, 2);//3. indeksten başlayıp 2 eleman silme işlemi.
            liste.RemoveAt(3);//parantez içindeki indeksteki elemanı siler.


            liste.Sort();// arraylist sıralama işlemi A'dan Z'ye(listenin nesneleri aynı tip olmalı yoksa hata alır)
            liste.Reverse();//listeyi ters çevirme


            liste.Contains("çart");//içeri yazılan nesnenin var olup olmadığını kontrol eder.true veya false döner.
            int index = liste.IndexOf("Bora Atabey");//bir nesnenin hangi indekste olduğunu söyler.inte aldık ki sayı olarak atansın.



             liste.Clear();//içini tamamen siler.ancak kapasitesi aynı kalır
            liste.TrimToSize();//kapasiteyi ilk haline geri döndürür.

            
            //-----------------------------------------------------------------------------------


            ArrayList ogr = new ArrayList();//listeye rastgele nesneler alıp Z-A sıralayıp ekrana yazdıran uygulama
            ogr.Add("Zeynep");
            ogr.Add("Özgür");
            ogr.Add("Yakup");
            ogr.Add("Ayşegül");
            ogr.Add("Hakan");
            ogr.Add("Cengiz");
            ogr.Add("Mustafa");
            ogr.Add("Lale");
            ogr.Add("Gökhan");
            ogr.Add("Selim");
            ogr.Add("Nilüfer");
            ogr.Sort();
            ogr.Reverse();
            foreach (object items in ogr)
            {
                Console.WriteLine(items);
               

            }
            Console.ReadLine();
            */

            //-------------------------------------------------------------------------------------


            //LİSTE EKLEME,DÜZENLEME,LİSTELEME,ARAMA VE SİLME İŞLEMLERİNİ YAPAN PROGRAM


            /*
            string islem = string.Empty;
            string ara=string.Empty;
            ArrayList liste = new ArrayList();
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Değer Ekle");
                Console.WriteLine("2 - Değer Listele");
                Console.WriteLine("3 - Değer Ara");
                Console.WriteLine("4 - Değer Düzenle");
                Console.WriteLine("5 - Değer Sil");
                Console.WriteLine("6 - Uygulama Çıkış");

                Console.Write("İstediğiniz işlemi girin:");
                islem = Console.ReadLine();


                switch (islem)
                {
                    case "1":
                        Console.Write("Lutfen eklemek istediğiniz nesneyi girin:");
                        string deger=Console.ReadLine();
                        liste.Add(deger);
                        System.Threading.Thread.Sleep(2000);//2 saniye ekranı bekletir öyle işlemlere devam eder.konsolu sıfırlıcamız icn koydk
                        break;
                    case "2":
                        for(int i=0; i<liste.Count;i++)
                        {
                            Console.WriteLine("{0}. elemanın değeri:{1}", i+1, liste[i]);
                        }
                        Console.WriteLine("Devam etmek için bir tuşa basın");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Write("Aramak istediğiniz değeri girin:");
                        ara =Console.ReadLine();
                        if (liste.Contains(ara))
                        {
                            int istenenIndex = liste.IndexOf(ara);
                            string bulunanDeger = liste[istenenIndex].ToString();
                            Console.WriteLine("İstediğiniz nesne {0}. indekste ve değeri : {1}", istenenIndex,bulunanDeger);
                        }
                        else
                        {
                            Console.WriteLine("Böyle bir nesne yok!!");
                        }

                        break;
                    case "4":
                        Console.WriteLine("Güncellemek istediğiniz değeri girin:");
                        string degisecekDeger =Console.ReadLine();
                        Console.WriteLine("Hangi değer ile güncellemek istiyorsunuz:");
                        string yeniDeger=Console.ReadLine();

                        if (liste.Contains(degisecekDeger))
                        {
                            int degisenIndex=liste.IndexOf(degisecekDeger);
                            liste[degisenIndex] = yeniDeger;
                            Console.WriteLine("Değeriniz güncellendi");

                        }
                        else
                        {
                            Console.WriteLine("Böyle bir değer bulunmamaktadır.");
                        }

                        break;
                    case "5":
                        Console.WriteLine("Tüm listeyi mi silmek istiyorsunuz E/H ? ");
                        string kullaniciCevap=Console.ReadLine();
                        if(kullaniciCevap.ToUpper()=="E")
                        {
                            liste.Clear();
                            Console.WriteLine("Tüm liste silinmiştir.");
                        }
                        else if (kullaniciCevap.ToUpper() == "H")
                        {
                            Console.Write("Silmek istediğiniz değeri girin :");
                            string silDeger=Console.ReadLine();
                            if (liste.Contains(silDeger))
                            {
                                liste.Remove(silDeger);
                                Console.WriteLine("Değer silinmiştir.");
                            }
                            else
                            {
                                Console.WriteLine("Böyle bir değer bulunamamıştır");
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("Yanlış harf girişi yaptınız");
                        }
                        break;
                  
                    default:
                        Console.WriteLine("Hatalı değer girişi yaptınız");
                        Console.ReadLine();
                        break;

                }
            } while (islem != "6");*/

            //----------------------------------------------------------------------------------------------

            /* - HASHTABLE -
             Amacı bir datayı bir nesneyi anahtar kelimeye bağlamak.
             *

            Hashtable tbl = new Hashtable();

            tbl.Add("Car", "Araba");//Car anahtar kelimesine araba nesnesini atadık.
            tbl.Add("House", "Ev");

            //aynı nesneleri farklı key'e atayabiliriz ama anı key'e iki farklı nesne atarsak hata alırız.

            tbl.Contains("Car");//içerisine key değeri alır eğer key değeri varsa true döner yoksa false döner.
            tbl.ContainsValue("Araba");//değere bakarak varlığı kontrol edilir.


            tbl.Remove("Car");//içine key değer alır,key'i de değeri de siler.
            tbl["House"] = "Villa";//köşeli parantez içine key değeri veririz atama işlemi ile o keyin değerini güncelleyebiliriz
            
            */

            //----------------------------------------------------------------------------------------------


            /* - SORTEDLIST -
             * hashtable gibi key değeri ve value değeri olur ancak hashtabledan farkı key değerlerine A-Z göre sıralar.
             * aynı tipten olmaları gerekir.

            SortedList sirali= new SortedList();
            sirali.Add(100, "yüz");
            sirali.Add(90, "doksan");
            sirali.Add(75, "yetmişbeş");
            sirali.Add(9000, "dokuzbin");
            sirali.Add(1, "bir");//1-75-90-100-9000 şeklinde sıraladı
            */

            //----------------------------------------------------------------------------------------------

            /* - STACK -
             * içerisine almış olduğu verileri almış olduğu bir komutla sıralı şekilde kendi listesinden çıkartır.
             * yüklü veri girişlerinde doğrulama yaptıktan sonra listeyi boşaltma gibi durumlarda kullanılır.
             * Son giren ilk önce çıkar mantığı vardır.
            *

            Stack s1= new Stack();
            s1.Push("bir");
            s1.Push("iki");
            s1.Push("üç");
            s1.Push("dört");

            object o1 = s1.Pop();//datayı o1'e gönderdi ve listeden çıkardı.
            object o2= s1.Peek();//datayı o2'e gönderdi ama veriyi listeden silmedi.
            */


            //----------------------------------------------------------------------------------------------


            /* - QUEUE -
             * aynı stack gibidir.
             * İlk giren ilk çıkar.
             

            Queue s2= new Queue();
            s2.Enqueue("pırt");//veri ekleme
            s2.Enqueue("zort");
            s2.Enqueue("bırd");
            s2.Enqueue("çırt");

            object c1 = s2.Peek();//veriyi atadı ama silmedi.
            object c2=s2.Dequeue();//veriyi atadı ve sildi.
            */

        }

        }

}
