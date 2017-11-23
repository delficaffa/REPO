using ConsoleApp1.Foo;
using System;
using Demo;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, rest;
            string op, op2;

            System.Console.WriteLine("Ingrese dos numeros: ");
            int.TryParse(Console.ReadLine(), out x);
            int.TryParse(Console.ReadLine(), out y);


            System.Console.WriteLine("Ingrese la operacion S - R - M - D");
            op = System.Console.ReadLine();

            rest = Calcu(x, y, op);
            System.Console.WriteLine($"El resultado es: {rest}");

            System.Console.WriteLine("Ingrese otro numero: ");
            int.TryParse(Console.ReadLine(), out z);
            System.Console.WriteLine("Ingrese otra operacion: ");
            op2 = System.Console.ReadLine();

            rest = Calcu(rest, z, op2);
            System.Console.WriteLine($"El nuevo resultado es: {rest}");
            System.Console.ReadLine();
        }

        private static int Calcu(int x, int y, string ope)
        {
            int r = 0;
            switch (ope.ToLower())
            {
                case "s":
                    Console.WriteLine();
                    r = Suma(x, y);
                    break;

                case "r":
                    Console.WriteLine();
                    r = Resta(x, y);
                    break;

                case "m":
                    Console.WriteLine();
                    r = Multi(x, y);
                    break;

                case "d":

                    if (y == 0 || x == 0)
                    {
                        System.Console.WriteLine("****ERROR****");
                        System.Console.WriteLine("no puedes dividir por cero");
                        r = -1;
                        System.Console.ReadLine();


                    }
                    else
                        Console.WriteLine();
                    r = Div(x, y);
                    break;

                default:
                    System.Console.WriteLine("caracter no valido.");
                    break;
            }
            return r;

        }
        private static int Suma(int x, int y)
        {
            return x + y;
        }

        private static int Resta(int x, int y)
        {
            return x - y;
        }

        private static int Multi(int x, int y)
        {
            return x * y;
        }

        private static int Div(int x, int y)
        {
            return x / y;
        }

    }
}
