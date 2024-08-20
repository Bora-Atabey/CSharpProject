using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Sınıflar_Odev
{
    public class Araç
    {
        public string marka, model;
        public int modelYil, yakitTipi, vitesTipi;
        public decimal alisFiyat, satisFiyat, km,maxIndirimTutari,fiyat;
        
        public Araç()
        {

        }
        
        public Araç(string _marka,string _model)
        {
            marka = _marka;
            model = _model;
        }
        public Araç(string _marka,string _model,int _modelYil)
        {
            marka= _marka;
            model = _model;
            modelYil = _modelYil;

        }
        public Araç(string _marka, string _model, int _modelYil,int _km)
        {
            marka = _marka;
            model = _model;
            modelYil = _modelYil;
            km = _km;
        }
        public void bilgileriGoster()
        {
            Console.WriteLine("Aracın markası : "+marka);
            Console.WriteLine("Aracın modeli : " + model);
            Console.WriteLine("Aracın model yılı : "+modelYil);
            Console.WriteLine("Aracın km'si : "+km);
            Console.WriteLine("Aracın yakıt tipi : "+yakitTipi);
            Console.WriteLine("Aracın vites tipi : "+vitesTipi);

        }
        public void FiyatAta(decimal _fiyat)
        {
            decimal fiyatHesap = satisFiyat - maxIndirimTutari;
            if(_fiyat<fiyatHesap)
            {
                Console.WriteLine("Geçersiz fiyat girişi!");
            }
            else
            {
                fiyat = _fiyat;
                Console.WriteLine("Fiyat güncellendi");
                Console.WriteLine("Yeni fiyat: "+fiyat);

            }
        }


    }
    
}
