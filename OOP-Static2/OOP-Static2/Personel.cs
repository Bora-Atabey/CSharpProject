using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Static2
{
    public class Personel
    {
        public static string domainadresi = "laxus.com";//static tanımladığımız field Personel.domainadresi; şeklinde ulaşabilir heryerde
        public string isim {  get; set; }
        public string soyisim { get; set; }

        private string _emailadres;
        public string EMailAdres
        {
            get
            {
                return this._emailadres;
            }
            set
            {
                this._emailadres = value.ToLower() + "@" + Personel.domainadresi;//isim soyismi .'lı aldık ve static fielddan domain adresini yanına yazdık.
            }

        }
        public int cinsiyet {  get; set; }
        


    }
}
