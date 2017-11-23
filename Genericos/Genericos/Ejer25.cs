using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    public class Ejer25<T>
    {
        public bool MetodoCompara(T item,T random)
        {
            return item.Equals(random);
        }
    }
}
