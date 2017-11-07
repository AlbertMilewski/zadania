using System;
using System.Collections.Generic;
using System.Text;

namespace PascalTriangle
{

    class PascalTriangle
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Trójkąt Pascala");
            Console.Write("Wprowadź wysokość trójkąta ");
            int a;
            a = int.Parse(Console.ReadLine());


            for (int y = 0; y < a; y++)
            {
                int c = 1;
                for (int q = 0; q < a - y; q++)
                {
                    Console.Write("   ");
                }

                for (int x = 0; x <= y; x++)
                {
                    Console.Write("   {0:D} ", c);
                    c = c * (y - x) / (x + 1);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}