using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static int Pytanie(ref int n)
        {
            n = int.Parse(Console.ReadLine());
            return n;

        }
        static void obliczenia(ref int a,ref int n)
        {
            for (int b = 0; b < n; b++)
            {
                Console.WriteLine();
                for (int i = 0; i < a - 1; i++)
                {
                    Console.Write("o");
                }



                Console.Write("x");
                a--;
                for (int i = 0; i < b; i++)
                {
                    Console.Write("o");
                }
            }
        }
        static void Main(string[] args)
        {
            
            int n,a,b;
            Console.WriteLine("Podaj rozmiar kwadratu");
            n = 0;
            Pytanie(ref n);
           
            a = n;
            obliczenia(ref a,ref n);
            Console.ReadLine();
        }
    }
}
