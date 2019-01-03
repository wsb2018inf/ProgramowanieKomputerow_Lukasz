using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            Console.WriteLine("Podaj dlugosc ciagu");
            n = Convert.ToInt32(Console.ReadLine());
            int[] ciag = new int[n];

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("podaj wartosc elementu");
                ciag[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Parzyste to :");
            foreach (var item in ciag)
            {
                if (item % 2 == 0)
                    Console.WriteLine("{0}", item);
            }
        }
    }
}
