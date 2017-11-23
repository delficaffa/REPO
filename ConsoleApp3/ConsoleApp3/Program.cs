using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 13) dados tres numeros donde el primero y el ultimo son los limites de un intervalo, indicar si el tercero pertenece 
 a dicho intervalo.
 14) realizar la tabla de multiplicar de un numero ingresado entre 0 y 10
 de forma que se visualize de la siguiente forma:
 4x1=4,
 15) ingresar 2 numeros, imprima los numeros naturales que hay entre ambos, empezando por el mas pequeño
 contar cuantos numeros hay y cuantos de ellos son pares.
 */
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //al2al3();
            //pesos();
            //triangulo();
            // intervalo();
            tablamulti();
        }

        static void al2al3()
        {

            Console.WriteLine("Ingrese un numero: ");
            int x = int.Parse(Console.ReadLine());
            int x2 = (int)Math.Pow(x, 2);
            int x3 = (int)Math.Pow(x, 3);
            Console.WriteLine($"el cuadrado de {x} es: {x2} y el cubo es: {x3}");
            Console.ReadLine();

        }
        static void pesos()
        {
            int mas80 = 0, menos80 = 0;
            Console.WriteLine("Ingrese cantidad de personas.");
            int cant = int.Parse(Console.ReadLine());
            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("Ingrese el peso: ");
                int pesos = int.Parse(Console.ReadLine());
                if (pesos > 80)
                {
                    mas80++;
                }
            }
            menos80 = cant - mas80;
            Console.WriteLine($"De las {cant} personas, {mas80} pesan mas de 80kg y {menos80} pesan menos de 80.");
            Console.ReadLine();
        }
        static void triangulo()
        {
            List<int> numeros = new List<int>();
            int min1 = 0, min2 = 0, suma = 0;
            Console.WriteLine("Ingrese los tres lados del triangulo.");
            numeros.Add(int.Parse(Console.ReadLine()));
            numeros.Add(int.Parse(Console.ReadLine()));
            numeros.Add(int.Parse(Console.ReadLine()));

            min1 = numeros.Min();
            numeros.Remove(min1);
            min2 = numeros.Min();
            suma = min1 + min2;

            if (suma < numeros.Max())
            {
                Console.WriteLine("Felicidades es un triangulo.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Señor, esto no es un triangulo.");
                Console.ReadLine();
            }


        }
        static void intervalo()
        {
            Console.WriteLine("ingrese tres numeros.");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());


            if (y >= x && y <= z)
            {
                Console.WriteLine("PERTENECE!!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("NO PERTENECE!!");
                Console.ReadLine();
            }

        }
        static void tablamulti()
        {
            Console.WriteLine("ingrese un numero del 0 a 10.");
            int x = int.Parse(Console.ReadLine());
            if (x<=10 && x >= 0)
            {
                for(int i = 0; i<=10; i++)
                {
                    Console.WriteLine($"{x} X {i}= {x * i}");
                    Console.ReadLine();
                }

            }
        }

    }
}
