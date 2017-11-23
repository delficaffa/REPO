using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador
{
    class Program : Contador
    {
        static void Main(string[] args)
        {
            var x = new Contador();
            x.valor = 10;
            Incrementar(x.valor);
            Disminuir(x.valor);
            Disminuir(x.valor);
            Console.WriteLine($"El valor ahora es {x.valor}");
            Console.ReadLine();

        }
    }
}
