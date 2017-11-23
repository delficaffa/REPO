using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    class Ejer27
    {
        public T Ejercicio27<T>(IEnumerable<T> a, IEnumerable<T> b)
        
        {
            return a.Intersect(b).FirstOrDefault();
        }
    }
}
