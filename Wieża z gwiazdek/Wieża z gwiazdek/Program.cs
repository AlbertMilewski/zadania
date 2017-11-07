using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wieża_z_gwiazdek
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b;
            int h, d, e, f,x,i;
            a = "*";
            b = " ";
            x = 1;
            Console.WriteLine("Podaj wysokość");
            h = int.Parse(Console.ReadLine());

            for (i = 1; i <= h; i++)
            {
                for (e = 1; e <= h - i; e++)
                {
                    Console.Write(b);
                }
                    for (d = 1; d<= x; d++)
                    {

                        Console.Write("*");
                        
                    }
                Console.WriteLine("");
                x = x + 2;
                
            }
            
            Console.ReadLine();

        }
    }
}
