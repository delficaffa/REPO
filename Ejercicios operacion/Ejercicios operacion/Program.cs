using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_operacion
{
    class Program
    {
        static void Main(string[] args)
        {
            var operaciones = new List<Operacion>
            {
                new Suma{ valor1 = 10, valor2 = 5},
                new Resta { valor1 = 10, valor2 = 5},
                new Multiplicacion{ valor1 = 10, valor2 = 5},
                new Division { valor1 = 10, valor2 = 5}
            };
            foreach (var operacion in operaciones)
            {
                var resultado = operacion.Operar();
                Console.WriteLine($"El resultado de la operacion es {resultado}");
            }
            Console.ReadLine();

        }
    }
}
