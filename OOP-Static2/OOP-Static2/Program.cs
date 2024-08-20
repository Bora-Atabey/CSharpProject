using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Static2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * STATIC KAVRAMI GERÇEK HAYATTA NERELERDE KULLANILIR?
             * 
             * 1-Helper.cs-->kontroller(kimlik doğrulama vb.)
             * 
             * 2-Oluşturmuş olduğumuz nesnemizin-->bağımlılığı farklı classlara
             * olduğu için(proje içerisinde özel olduğu için)nesne içerisinde
             * static metot tanımları yapılır.
             * 
             * 3-Class içerisinde static bir field tanımı yapar ilgili field içerisine
             * bir değer ataması yaparız.Daha sonra uygulama içerisinde N farklı yerde
             * oluşturmuş olduğumuz static field'ımıza ulaşır değerimizi okuruz.
             * 
             */

            //--------------------------------------------------------------------------------------
            /*static field kullanımı -->domain adresi öbür classta
            Personel p1 = new Personel();
            p1.isim = "Bora";
            p1.soyisim = "Atabey";
            p1.EMailAdres = "BORA.ATAbeY";
            p1.cinsiyet = 717770001;//erkek. 02'lisi de kadın */

            //---------------------------------------------------------------------------------------
            //Helper.emailGonder("ik@laxus.com","yeni personel hakkinda","işe alım");//static metot kullanma


            
        }
    }
}
