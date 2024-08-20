using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_sınıflar
{
    public class Musteri
    {

        //yapıcı metot( ctor )
        //default değerleri atamak için yapılır.
        public Musteri()//ctor yazınca oluşuyor
        {
            tcKimlikNo = "1234567890";

        }







        /* TC kimlik no
         * İsim
         * Soyisim
         * Cinsiyet
         */


        public string isim;//public tanımlayarak diğer classlarda .'lı kullanıma açmak gerekir.
        public string soyisim;
        public string tcKimlikNo;
        public int cinsiyet;// 717770001:erkek 717770002:kadın
         

    }
}
