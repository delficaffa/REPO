using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            do
            {
                Console.WriteLine("Ingrese la opcion correspondiente");
                Console.WriteLine("A - Agregar || E - Eliminar || M - Modificar || S - Salir");
                opcion = Console.ReadLine();
                switch (opcion.ToLower())
                {
                    case "a":
                        //AgregarCliente();
                        break;
                    case "e":
                        break;
                    case "m":
                         break;
                    case "s":
                        opcion = "s";
                        break;
                }
            } while (opcion != "s");
        }
    }
}
