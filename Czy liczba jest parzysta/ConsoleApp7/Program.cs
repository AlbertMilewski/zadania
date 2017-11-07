using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Podaj liczbę a do sprawdzenia czy jest liczbą parzystą");
            a = int.Parse(Console.ReadLine());
            b = 2;
            if ((a%b) == 1)
            {
                Console.WriteLine(a + " nie jest liczbą parzystą");
            }
            else
            {
                Console.WriteLine(a + " jest liczbą parzystą");
                    }

            Console.ReadLine();
        }
    }
}
