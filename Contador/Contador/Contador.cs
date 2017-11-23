using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador
{
   public  class Contador
    {
       
        public Contador()
        {
            
        }
        public int valor { get; set; }


        public static void Incrementar(int x)
        {
            x++;
        }
        public static void Disminuir(int x)
        {
            x--;
        }
    }
}
