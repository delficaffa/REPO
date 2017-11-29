using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CreandoUnaBaseDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            do
            {
                Console.WriteLine("Ingrese la opcion correspondiente");
                Console.WriteLine("C - Ciudad || E - Empleado || L - Listar por ciudad || S - Salir");
                opcion = Console.ReadLine();
                switch (opcion.ToLower())
                {
                    case "c":
                        MenuCrearCiudad();
                        break;
                    case "e":
                        MenuCrearEmpleado();
                        break;
                    case "l":
                        ListarPorCiudad();
                        break;
                    case "s":
                        opcion = "s";
                        break;
                }
            } while (opcion != "s");
        }
        public static void MenuCrearCiudad()
        {
            using (var context = new Context())
            {
                var nuevaCiudad = new City();
                Console.WriteLine("Ingrese el nombre de la ciudad");
                nuevaCiudad.Name = Console.ReadLine();
                context.Cities.Add(nuevaCiudad);
                context.SaveChanges();
            }

        }

        public static void MenuCrearEmpleado()
        {
            using (var context = new Context())
            {
                var nuevoEmpleado = new Employee();
                Console.WriteLine("Ingrese el nombre del empleado");
                nuevoEmpleado.Name = Console.ReadLine();
                Console.WriteLine("El apellido");
                nuevoEmpleado.Surname = Console.ReadLine();
                Console.WriteLine("La edad");
                var age = nuevoEmpleado.Age;
                int.TryParse(Console.ReadLine(), out (age));
                Console.WriteLine("La posicion");
                nuevoEmpleado.Position = Console.ReadLine();
                Console.WriteLine("La ciudad");
                var cityToSerch = Console.ReadLine();

                var city = context.Cities.FirstOrDefault(c => c.Name == cityToSerch);
                nuevoEmpleado.City = city;
                context.Employees.Add(nuevoEmpleado);
                context.SaveChanges();
            }

        }

        public static void ListarPorCiudad()
        {
            using (var context = new Context())
            {
                Console.WriteLine("Ingrese el Nombre de la ciudad a listar");
                var cityId = Console.ReadLine();
                var employeer = context.Cities.Include(c => c.Employees).AsNoTracking().FirstOrDefault(c => c.Name == cityId);
                Console.WriteLine(employeer.Name);
            }

        }


    }
}
