using Servicios;
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
                        MenuAgregarCliente();
                        break;
                    case "e":
                        MenuEliminarCliente();
                        break;
                    case "m":
                        MenuModificarCliente();
                         break;
                    case "s":
                        opcion = "s";
                        break;
                }
            } while (opcion != "s");
        }

        public static void MenuAgregarCliente()
        {
            var nuevoCliente = new ClienteDTO();
            Console.WriteLine("Ingrese el nombre de la compañia");
            nuevoCliente.CompanyName = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del contacto");
            nuevoCliente.ContactName = Console.ReadLine();
            Console.WriteLine("Ingrese el titulo de dicho contacto");
            nuevoCliente.ContactTitle = Console.ReadLine();
            Console.WriteLine("Ingrese el Id");
            nuevoCliente.CustomerID = Console.ReadLine();
            Console.WriteLine("Ingrese la ciudad");
            nuevoCliente.City = Console.ReadLine();

            Consultas.Agregar(nuevoCliente);
        }

        public static void MenuEliminarCliente()
        {
            Console.WriteLine("Ingrese el Id del cliente a eliminar");
            var id = Console.ReadLine();
            Consultas.Eliminar(id);
    

        }

        public static void MenuModificarCliente()
        {
            Console.WriteLine("Ingrese el id del cliente a modificar");
            var idModif = Console.ReadLine();
            
            var editCliente = new ClienteDTO();
            Console.WriteLine("Ingrese el nombre de la compañia");
            editCliente.CompanyName = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del contacto");
            editCliente.ContactName = Console.ReadLine();
            Console.WriteLine("Ingrese el titulo de dicho contacto");
            editCliente.ContactTitle = Console.ReadLine();
            Console.WriteLine("Ingrese el Id");
            editCliente.CustomerID = Console.ReadLine();
            Console.WriteLine("Ingrese la ciudad");
            editCliente.City = Console.ReadLine();

        }
    }
}
