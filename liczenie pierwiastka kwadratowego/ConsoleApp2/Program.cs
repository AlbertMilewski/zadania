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
            Console.WriteLine("obliczanie wyrażena y = ax2 + bx + c");
            Console.WriteLine("podaj wartość a");
            string aa = Console.ReadLine();
            double a = double.Parse(aa);
            Console.WriteLine("podaj wartość b");
            string bb = Console.ReadLine();
            double b = double.Parse(bb);
            Console.WriteLine("podaj wartość c");
            string cc = Console.ReadLine();
            double c = double.Parse(cc);
            Console.WriteLine("podaj wartość x");
            string xx = Console.ReadLine();
            double x = double.Parse(xx);
            double y = (a * x * x) + (b * x) + c;

            Console.WriteLine("wartość wyrażenia wynosi" y);
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}


