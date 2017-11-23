using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zzzz
{

    class Program
    {
        static void Main(string[] args)
        {

            Cuenta cuenta1 = new Cuenta("delfina", 100);
            cuenta1.ingresar(50);
            //cuenta1.retirar(200);
            Console.WriteLine($" {cuenta1.mostrar(cuenta1)}");
            

        }
    }
}
