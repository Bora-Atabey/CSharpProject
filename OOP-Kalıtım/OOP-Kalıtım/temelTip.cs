using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kalıtım
{
    public class temelTip//oluşturduğumuz classların ortak fieldlarını temel tip classına tanımlarız.
    {
        public int id { get; set; }
        public string referansKod { get; set; }
        public string tcKimlikNo { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public int cinsiyet { get; set; }
        public DateTime kayitTarih { get; set; }
        public DateTime guncellemeTarih { get; set; }
        public  bool silindi { get; set; }
        public temelTip()
        {
            Console.WriteLine("temeltip yapıcı metodu çalıştı.");
            idAtama();
        }

        private void idAtama()
        {
            Random rnd= new Random();
            this.id=rnd.Next(1000,9000);
        }
        public void TemelTipTestMetot()
        {
            Console.WriteLine("temel tip test metodu");
        }
        protected void TemelTipTestMetot2()//protected kelimesi başka yerde çalışmaz ancak kalıtılan classlarda çalışır.
        {
            Console.WriteLine("protected metot");
        }

    }
}
