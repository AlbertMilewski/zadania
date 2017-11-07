using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Największy_wspólny_dzielnik
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Program obliczający największy wspólny dzielnik");
            Console.Write("Podaj liczbę a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Podaj liczbę b: ");
            b = int.Parse(Console.ReadLine());

           
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }

            Console.WriteLine("Największy wspólny dzielnik (NWD) to: " + a);
            Console.ReadKey();
        }
    }
}
