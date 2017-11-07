using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wspólna_wielokrotność
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Program obliczający najmniejszą wspólna wielokrotność dwóch liczb");
            Console.Write("Podaj liczbę a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Podaj liczbę b: ");
            b = int.Parse(Console.ReadLine());
            int c = a;
            int d = b;

            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }


            Console.Write("Największa wspólna wielokrotność liczb " + c);
            Console.Write(" oraz "+d);
            Console.Write (" to: " + ((c * d) / a));
            Console.ReadKey();
        }
    }
}
