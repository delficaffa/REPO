using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
   public class Perro : IAnimalesEj30
    {
        public Perro() { }

        public string Nombre { get => "Fido"; }

        public void Saludar()
        {
            Console.WriteLine($"{ this.Nombre} dice guau guau");
        }
    }

    public class Gato : IAnimalesEj30
    {
        public string Nombre { get => "Bethoven"; }

        public void Saludar()
        {
            Console.WriteLine($"{this.Nombre} dice miau");
        }
    }

    public class Pajaro : IAnimalesEj30
    {
        public string Nombre { get => "Pepe"; }

        public void Saludar()
        {
            Console.WriteLine($"{this.Nombre} dice pio pio");
        }
    }

}
