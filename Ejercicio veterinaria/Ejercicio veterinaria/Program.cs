using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_veterinaria
{
    class Program
    {/*
        ⦁	En una veterinaria hay un perro, un gato y un pájaro. Cada animal tiene un nombre. 
            Todos saben saludar de una manera diferente.
            Resultado esperado:
            ⦁	Tomy dice miau
            ⦁	Beethoven dice guau guau
            ⦁	Pepe dice pio pio

         */
        static void Main(string[] args)
        {
            var animales = new List<Animal>
            {
                new Perro(){ nombre = "Tomy"},
                new Gato(){ nombre = "Bethoven"},
                new Pajaro(){ nombre = "Pepe"}
            };

            foreach(var animal in animales)
            {
                animal.Saludar();
            }
            Console.ReadLine();
        }
    }
}
