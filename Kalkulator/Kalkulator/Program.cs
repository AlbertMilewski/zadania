using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("program kalkulator");
            double a, b;
            Console.WriteLine("liczba a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("liczba b");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("a-b równa się " + (a - b));
            Console.WriteLine("a+b równa się " + (a + b));
            Console.WriteLine("a*b równa się " + (a * b));
            if (b > 0)
            {
                Console.WriteLine("a/b równa się " + (a / b));
            }

            else
            {
                Console.WriteLine("Próba dzielnia przez 0");
            }
            Console.ReadLine();



        }
    }
}
