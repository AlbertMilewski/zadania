using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorządekRosnący
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Podaj trzy liczby");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            if ((a > b) & (b > c))
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
            }
            else if ((a > c) & (c > b))
            {
                Console.WriteLine(a);
                Console.WriteLine(c);
                Console.WriteLine(b);
            }
         
            else if ((b > a) & (a > c))
            {
                Console.WriteLine(b);
                Console.WriteLine(a);
                Console.WriteLine(c);
            }
            else if ((b > c) & (c > a))
            {
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine(a);
            }
           
            else if ((c > a) & (a > b))
            {
                Console.WriteLine(c);
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            else if ((c > b) & (b > a))
            {
                Console.WriteLine(c);
                Console.WriteLine(b);
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
