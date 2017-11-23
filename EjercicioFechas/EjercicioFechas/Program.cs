using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFechas
{
    class Program
    {

        static void Main(string[] args)
        {
            var dates = new List<DateTime>
            {
                new DateTime(2017, 1, 21),
                new DateTime(2014, 2, 17),
                new DateTime(2013, 3, 20),
                new DateTime(2012, 4, 2),
                new DateTime(2010, 10, 7),
                new DateTime(2018, 6, 8),
                new DateTime(2025, 7, 9),
                new DateTime(2022, 8, 11),
                new DateTime(1980, 9, 12),
                new DateTime(1970, 10, 13),
                new DateTime(2099, 11, 18),
                new DateTime(1945, 12, 15),

            };
            //FechasMayores(dates);
            //FechasOctubre(dates);
            FechasMenores2000(dates);
        }

        public static void FechasMayores(List<DateTime> dates)
        {
            var hoy = DateTime.Now;
            foreach (var d in dates)
            {
                if (d < hoy)
                {
                    continue;
                }
                Console.WriteLine($"{d.ToShortDateString()}");
            }
            Console.ReadLine();
        }

        public static void FechasOctubre(List<DateTime> dates)
        {
            
            foreach (var d in dates)
            {
                if (d.Month != 10)
                {
                    continue;
                }
                Console.WriteLine($"{d.ToShortDateString()}");
            }
            Console.ReadLine();

        }

        public static void FechasMenores2000(List<DateTime> dates)
        {
            foreach (var d in dates)
            {
                if (d.Year < 2000)
                {
                    continue;
                }
                Console.WriteLine($"{d.ToShortDateString()}");
            }
            Console.ReadLine();
        }
    }
}
