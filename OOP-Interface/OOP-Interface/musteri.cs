using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface
{
    public class musteri : Imusteri
    {
        public musteri()
        {
            id = 0;
            isim = "Bora";
            soyisim = "Atabey";
        }
        int _id;
        string _isim;
        string _soyisim;
        public int id { get { return this._id; } set { this._id = value; } }
        public string isim { get { return this._isim; } set { this._isim = value; } }
        public string soyisim { get { return this._soyisim; } set { this._soyisim = value; } }

        public int kayitduzenle(int id, string isim, string soyisim)
        {
            Console.WriteLine("kayıt düzenlendi");
            return 1;
        }
        public int kayitsil(int id)
        {
            Console.WriteLine("Kayıt silindi");
            return 1;
        }
        public int yenikayit(string isim, string soyisim)
        {
            Console.WriteLine("yeni kayıt açıldı");
            return 1;
        }
    }
}
