using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
       static int silnia(int n,int b)
        {
            
            for (int i = 1; i < n; i++)
            {
                b += n * i;
             }
            return b;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Program obliczania silni z danej liczby");
            Console.WriteLine("Podaj liczbe");
            int n = int.Parse(Console.ReadLine());
            int b = 0;
               b = silnia(n, b);
         
            Console.WriteLine("!"+n+" równa się "+ b);
            Console.ReadLine();
        }
    }
}
