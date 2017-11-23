using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1)  mostrar los numeros impares entre el 0 y el 100.
//2) mostrar los numeros pares entre el 0 y el 100.
//3) mostrar los multiplos de 3 del 0 al 100
//4) mostrar los multiplos de 3 y del 2 entre 0 y 100
//5) ingresar n numero y mostrar la suma de los numeros que lo anteceden
//6) mostrar los numeros del 1 hasta el numero ingresado
//7) contar los multiplos de 3 desde la unidad hasta un num que ingresamos
//8) Ingresar 10 numeros sumar los + y multiplicar los -
//9) ingresar dos numeros e intercambiarlos es decir mostrar los valores intercambiados 
//10) ingresar un numero y mostrar su cuadrado y cubo
//11) ingresar x cant de pesos y mostrar la cantidad de personas que pesan + de 80 y - de 80
/*12) ingresar 3 datos y decir que clase de triangulo es. para formar un triangulo hay que tener cuenta
que la suma de sus dos lados mas chicos tiene que ser mayor al lado mayor.*/

namespace ConsoleApp1
{
    class Program
    {
        private static List<int> lista = new List<int>();
        private static List<int> numeros = new List<int>();
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                lista.Add(i);
            }

            impares(lista);
            pares(lista);
            multi3(lista);
            multi3y2(lista);
            numantes(lista);
            mostrarantes(lista);
            contarmulti3(lista);

            int may = 0, min = 0, x=0;
            var cont = 0;
            while (cont < 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("ingrese un numero:");
                    int.TryParse((Console.ReadLine()), out x);

                }
            }
           
        }



        public static void impares(List<int> l)
        {

            for (int i = 0; i <= 100; i++)
            {
                if (l[i] % 2 != 0)
                {
                    System.Console.WriteLine($"{l[i]}");
                    System.Console.ReadLine();
                }

            }
        }
        public static void pares(List<int> l)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (l[i] % 2 == 0)
                {
                    System.Console.WriteLine($"{l[i]}");
                    System.Console.ReadLine();
                }

            }
        }
        public static void multi3(List<int> l)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (l[i] / 3 == 0)
                {
                    System.Console.WriteLine($"{l[i]}");
                    System.Console.ReadLine();
                }
            }
        }
        public static void multi3y2(List<int> l)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (l[i] / 3 == 0 && l[i] / 2 == 0)
                {
                    System.Console.WriteLine($"{l[i]}");
                    System.Console.ReadLine();
                }
            }
        }
        public static int numantes(List<int> l)
        {

            int x, suma = 0;
            Console.WriteLine("Ingrese un numero: ");
            int.TryParse((Console.ReadLine()), out x);

            for (int i = 0; i <= x; i++)
            {
                suma += i;
            }
            return suma;
        }
        public static void mostrarantes(List<int> l)
        {

            int x;
            Console.WriteLine("Ingrese un numero: ");
            int.TryParse((Console.ReadLine()), out x);

            for (int i = 0; i <= x; i++)
            {
                Console.WriteLine($"{i} -");
            }

        }
        public static void contarmulti3(List<int> l)
        {

            int x;
            Console.WriteLine("Ingrese un numero: ");
            int.TryParse((Console.ReadLine()), out x);

            for (int i = 0; i <= x; i++)
            {
                if (i / 3 == 0)
                {
                    Console.WriteLine($"{i} -");
                }

            }


        }

      
}

