using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kalıtım_Odev
{
    public class Urun:BaseClass
    {
        public decimal alisFiyat { 
            get 
            { return alisFiyat; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Alış fiyatı 0'dan küçük olamaz");
                }
                else
                {
                    this.alisFiyat = value;
                }
            }
            }//0dan küçük olamaz.
        public decimal satisFiyat { 
            get
            { 
                return satisFiyat;
            }
            set
            {
                if (value < alisFiyat)
                {
                    Console.WriteLine("Alış fiyatı Satış fiyatından büyük olamaz");
                }
                else
                {
                    this.satisFiyat= value;
                }
            }

            }//alışfiyatından küçük olamaz
        public decimal kampanyaFiyat
        {
            get
            {
                return this.kampanyaFiyat;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("kampanya fiyatı 0dan küçük olamaz");
                }
                else
                {
                    this.kampanyaFiyat = value;
                }
            }
        }
            //0dan küçük olamaz.
        public string marka { get; set; }//liste içinde marka kontrolü,belirtmiş olduğumz markalar içerisinde ürün eklenebilsin.
        public string model { get; set; }


    }
}
