using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=0, y=0, z=0;
            Console.WriteLine("Ingrese un valor para x y otro para y. ");
            x=int.Parse(Console.ReadLine());
            y=int.Parse(Console.ReadLine());

            z = x;
            x = y;
            y = z;

            Console.WriteLine($"los nuevos valores son x: {x} e y: {y}");
            Console.ReadLine();
        }
    }
}
