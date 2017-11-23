using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /*ej1();
            ej2();
            ej3();
            ej4();
             ej5();  
            ej6();  */
            ej11();
        }

        static void ej1()
        {
            int x = 2, y = 3;
            int z = x + y;
            Console.WriteLine($"La suma de los dos numeros es: {z}");
            Console.ReadLine();
        }

        static void ej2()
        {
            Console.WriteLine(" Ingresa tu nombre.");
            string nombre = Console.ReadLine();
            Console.WriteLine(" Ingresa tu ciudad.");
            string ciudad = Console.ReadLine();

            Console.WriteLine($"Hola {nombre} bienvenid@ a {ciudad}");
            Console.ReadLine();
        }

        static void ej3()
        {
            Console.WriteLine(" Ingresa tu nombre.");
            string nombre = Console.ReadLine();
            Console.WriteLine(" Ingresa tu edad.");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine($"Te llamas {nombre} y tienes {edad}");
            Console.ReadLine();

        }

        static void ej4()
        {
            Console.WriteLine("Ingrese dos numeros.");
            int x, y;
            int.TryParse(Console.ReadLine(), out x);
            int.TryParse(Console.ReadLine(), out y);
            if (x == y)
            {
                Console.WriteLine($"{y} es igual que {x}");
                Console.ReadLine();
            }else if (x < y)
            {
                Console.WriteLine($"{y} es mayor que {x}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"{x} es mayor que {y}");
                Console.ReadLine();
            }
        }

        static void ej5()
        {
            Console.WriteLine("Ingrese un dia de la semana.");
            string dia = Console.ReadLine();

            switch (dia.ToLower())
            {
                case "lunes":
                case "martes":
                case "miercoles":
                case "jueves":
                case "viernes":
                    Console.WriteLine("El dia no es del fin de semana.");
                    Console.ReadLine();
                    break;

                case "sabado":
                case "domingo":
                    Console.WriteLine("El dia es del fin de semana.");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("******ERROR********");
                    Console.ReadLine();
                    break;
                

            }
        }

        static void ej6()
        {
            Console.WriteLine("Ingrese el precio del producto.");
            float precio = float.Parse(Console.ReadLine());
            if (precio > 0)
            {
                Console.WriteLine("Ingrese la forma de pago. tarjeta / efectivo");
                string pago = Console.ReadLine();
                switch (pago.ToLower())
                {
                    case "efectivo":
                        Console.WriteLine("Gracias por su compra!");
                        Console.WriteLine($"Monto a pagar: {precio} en efectivo.");
                        Console.ReadLine();
                        break;
                    case "tarjeta":
                        Console.WriteLine("Ingrese el numero de su tarjeta");
                        string numero = Console.ReadLine();
                        Console.WriteLine("Gracias por su compra!");
                        Console.WriteLine($"Monto a pagar: {precio} en tarjeta nro. {numero}");
                        Console.ReadLine();

                        break;
                    default:
                        Console.WriteLine("El metodo ingresado no es el correcto.");
                        Console.ReadLine();
                        break;


                }
            }
        }

        static int chekeo()
        {
            int x = 0;
            string s;

            do
            {
                Console.WriteLine("Cuanto?");
                s = Console.ReadLine();

            }
            while(!(int.TryParse(s, out x)));
            return x;
        }

        static void ej11()
             {
            item item1 = new item();
            Console.WriteLine("Ingrese su comida.");
            item1.comida = (Console.ReadLine());
            item1.cantidadc = chekeo();
           
            Console.WriteLine("Ingrese su bebida.");
            item1.bebida = (Console.ReadLine());
            item1.cantidadb = chekeo();

            Console.WriteLine($"Usted va a comer {item1.cantidadc} {item1.comida}/s con {item1.cantidadb} {item1.bebida}/s");
            Console.ReadLine();
          
        }
    }

   
}
