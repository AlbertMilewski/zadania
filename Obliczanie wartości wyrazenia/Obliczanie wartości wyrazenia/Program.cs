using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obliczanie_wartości_wyrazenia
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Podaj liczbę a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę b");
            b = int.Parse(Console.ReadLine());
            if ((a+b)==0)
                {
                Console.WriteLine("Próba dzielenia przez 0");
            }
            else
            {
                Console.WriteLine((a * b) / (a + b));
            }
            Console.ReadLine();



        }
    }
}
