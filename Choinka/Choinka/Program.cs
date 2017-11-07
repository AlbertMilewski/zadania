using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choinka
{
    class Program
    {
        static void Main(string[] args)
        {
            int d, e, f, g, h, i;
            string a, b,c;
            Console.WriteLine("Podaj wysokosc choinki: ");
            g = int.Parse(Console.ReadLine());
            a = "*";
            b = " ";
            c = "|";
            d = g;
            for (e = 1; e <= g; e++)
            {
                for (f = 1; f < d; f++)
                {
                    Console.Write(b);
                }
                for (h = 1; h <= e; h++)
                {
                    Console.Write(a);
                }
                for (i = 1; i <= e - 1; i++)
                {
                    Console.Write(a);
                }
                d--;
                Console.WriteLine();
            }
            for (e = 1; e <= g-1 ; e++)
            {
                Console.Write(b);
            
            }
            Console.Write(c);

            Console.WriteLine();
            for (e = 1; e <= g - 1; e++)
            {
                Console.Write(b);

            }
            Console.Write(c);


            Console.ReadKey();
        }
    }
}
