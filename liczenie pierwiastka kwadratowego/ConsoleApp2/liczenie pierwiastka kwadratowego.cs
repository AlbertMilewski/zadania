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
            Console.WriteLine("obliczanie wyrażena");
            Console.WriteLine("podaj wartość a");
            string aa = Console.ReadLine();
            double a = double.Parse(aa);
            Console.WriteLine("podaj wartość b");
            string bb = Console.ReadLine();
            double b = double.Parse(bb);
            Console.WriteLine("podaj wartość c");
            string cc = Console.ReadLine();
            double c = double.Parse(cc);
            if (c > 0)
                Console.WriteLine(a * a + b);
            if (c < 0)
                Console.WriteLine(a - b * b);

            if (c == 0) ;

            if (a - b != 0) Console.WriteLine("Wartość wyrażenia wynosi " + (1 / (a - b)));
            else Console.WriteLine("Próba dzielenia przez zero");







            Console.ReadLine();
        }
    }
}


