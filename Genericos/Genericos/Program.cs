using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    public class Program : IAnimalesEj30
    {
        public string Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public static void Main(string[] args)
        {

            /*EJERCICIO 23
            var a = new Ejer23<int>();
            int b = 7857;
            Console.WriteLine(a.MetodoGenerico(b));
            Console.ReadLine();
            */
            /* EJERCICIO 24
            var a = new Ejer24<string>();
            string frase = "HOLA";
            a.MetodoGConsola(frase);
            Console.ReadLine();
            */
            /* EJERCICIO 25
            var i = new Ejer25<int>();
            var c = new Ejer25<char>();
            int a = 123;
            int d = 123;
            char c1 = 'd';
            char c2 = 'c';
            Console.WriteLine(i.MetodoCompara(a, d));
            Console.WriteLine(c.MetodoCompara(c1, c2));
            Console.ReadLine();
            */
            /*
            // EJERCICIO 26 
            void Ejercicio26<T>(T item) where T : IConvertible
            {
            }
            */
            /*
            //EJERCICIO 27
            var u = new Ejer27();
            var x = new List<int> { 1, 2, 3, 4, 5};
            var y = new List<int> { 9, 8, 7, 4, 5};
            Console.WriteLine(u.Ejercicio27<int>(x, y));
            Console.ReadLine();
            */
            /*
            // EJERCICIO 28 
            void Ejercicio28<T>(T item) where T : IConvertible,IComparable
            {
            }
            */

        }



        /*
        //EJERCICIO 29
        public void Agregar()
        {
          throw new NotImplementedException();
        }

        public void EstaRepetido()
        {
           throw new NotImplementedException();
        }

        public void Quitar()
        {
           throw new NotImplementedException();
        }
        */


        // EJERCICIO 30

        

        public void Saludar()
        {
            throw new NotImplementedException();
        }

    }
}
