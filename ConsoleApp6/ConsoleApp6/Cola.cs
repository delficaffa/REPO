using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Cola <T>
    {

        private LinkedList<T> listaGenerica = new LinkedList<T>();
        public int cantidad => listaGenerica.Count; 

        public void Agregar(T x)
        {
           listaGenerica.AddLast(x);
           
        }

        public T Tomar()
        {
            var item = listaGenerica.Last();
            return item;
        }

        public void Mostrar()
        {
            foreach (var a in listaGenerica) {
                Console.WriteLine(a);
            }
        }

        


    }
}
