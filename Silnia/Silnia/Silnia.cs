using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silnia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("program obliczający silnie z przedziału <1;10>");
            int a;
            int b = 1;
            int i;
            a = int.Parse(Console.ReadLine());
            if ((a < 0) | (a > 10))
            {
                Console.WriteLine("podałeś za dużą liczbę");
            }
            else
            {
                
                for (i = 2; i <= a; i++)             
                  Console.WriteLine(b *= i);                              
                Console.WriteLine(a + "! = " + b);    
            }

            Console.ReadLine();
        }
    }
}
