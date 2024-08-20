using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kalıtım_Odev
{
    public static class SanalDataBase
    {
        private static ArrayList db=new ArrayList();
        
        public static void YeniUrunEkle(BaseClass data)//ürün ekleyeceğimiz static metot
        {
            if(data!=null && !string.IsNullOrEmpty(data.barkod))
            {
                db.Add(data);
            }
        }

        public static bool dbBarkodKontrol(string barkod)
        {
            bool kontrol = false;

            if(db!=null && db.Count > 0)
            {
                for(int i = 0; i < db.Count; i++)
                {
                    BaseClass bc = (BaseClass)db[i];
                    if (bc.barkod == barkod)
                    {
                        kontrol = true;
                        return kontrol;
                    }

                }
            }
            return kontrol;
        }
    }
}
