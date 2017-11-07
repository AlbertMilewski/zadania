using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprawdzenie_czy_jest_liczbą_pierwszą
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Podaj liczbę pierwszą");
            a = int.Parse(Console.ReadLine());
            if ((a%2 == 1)||(a / 1 == 1))
            {
                Console.WriteLine(a + " Jest liczbą pierwszą");
            }
            else
            {
                Console.WriteLine(a + " Nie jest liczbą pierwszą");
            }
            Console.ReadLine();

        }
    }
}
