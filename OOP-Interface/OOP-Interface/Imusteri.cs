using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface
{
    public interface Imusteri//bir standart olarak interface classlarının başında büyük ı olur.
    {
        //abstract ile interface'in farkı interface'in tamamen şablon olmasıdır yani yapıcı metot dahi tanımlanamaz.

        //public Imusteri()--->hata alırız.
        //{
       //}
        //field tanımı,
        //metot tanımı,
        //delegate(göreceğiz)vb..
        //interface içinde yapılabilir.
         int id { get; set; }//interface olduğu için public olarak işaretlenmesine gerek yok
        string isim {  get; set; }
        string soyisim { get; set; }
        int yenikayit(string isim,string soyisim);//bodysi olmaz
        int kayitduzenle(int id, string isim, string soyisim);
        int kayitsil(int id);

    }
}
