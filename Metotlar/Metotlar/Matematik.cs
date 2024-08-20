using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class Matematik
    {
        public decimal topla(decimal x, decimal y)
        {
            decimal sonuc = x + y;
            return sonuc;//geri döndürme işlemi
        }
        public decimal cikart(decimal x, decimal y)
        {
            decimal sonuc = x - y;
            return sonuc;

        }
        public decimal bol(decimal x, decimal y)
        {
            decimal sonuc = x / y;
            return sonuc;
        }
        public decimal carp(decimal x, decimal y) {

            decimal sonuc = x * y;
            return sonuc;
        }
        public void menu(){
            Console.Clear();
            Console.WriteLine("*****MENÜ*****");
            Console.WriteLine("1-toplama");
            Console.WriteLine("2-çıkarma");
            Console.WriteLine("3-çarpma");
            Console.WriteLine("4-bölme");

            Console.Write("lütfen yapmak istediğinz işlemi girin: ");

        }



    }
}
