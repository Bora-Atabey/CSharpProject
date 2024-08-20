using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Sanal_Metot
{
    public class BaseClass
    {
        public virtual void ekranayaz(string data)//virtual ekleyerek override yapmaya açılır metot.
        {
            Console.WriteLine(data);
        }
    }
}
