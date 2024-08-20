using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kapsülleme
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Müşteri m1=new Müşteri();
           // m1.id = 23;----->atayamıyoruz.
            m1.isim = "Bora";
            m1.soyisim = "Atabey";
            
            /*-Kapsülleme kullanımı-
             * 
             *Field'a değer ataması yapılamasın ancak değer okunabilsin.
             *
             *Field'a değer ataması yapılsın ancak değer okunamasın.
             * 
             * Field'a değer ataması ve okunma yapılsın ancak bu iki işlem bizim belirlediğimiz süreçlerden geçsin
             * ve veri daha sonra gösterilsin.
             * 
             */

            /*m1.emailadres = "boraatabey.03@hotmail.com";//bu field olduğu için hata veriyor

            //
            m1.EMailAdres = "boraatabey.03@hotmail.com";
            Console.Write(m1.EMailAdres);----->genel olarak kapsüllemeye giriş yaptık
            Console.ReadLine();*/

            //------------------------------------------------------------------------------------------------
            //1.Field'a değer ataması yapılamasın ancak değer okunabilsin.
            /*Bunu yapmak için geti önceki yaptığımız gibi olacak ancak set için yani değer ataması için bir yapıcı metot oluştururuz.
             * sonrasında bir diğer classta oluşturduğumuz private metotta oluşturma işlemi yapıp yapıcı metotta çağırırız.
             * bu şekilde başka bir yerde değer ataması olmaz sadece müşteri classında değer atma işlemi yapılır.

            Console.WriteLine("Müşterinin id'si : "+m1.ID.ToString());
            */

            //2. Field'a değer ataması yapılsın ancak değer okunamasın.      
            /*
             *  
             *
            m1.TcKimlikNo = "12345678975";//set edebiliyoruz.
            string tc = m1.TcKimlikNo;//get edemiyoruz
            */



        }
    }
}
