using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_veterinaria
{
    class Gato : Animal
    {
        public Gato()
        {

        }

        public override void Saludar()
        {
            Console.WriteLine($"{this.nombre} dice miau");
        }
    }
}
