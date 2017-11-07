using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wielkość macierzy ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Wielkość macierzy to " + n);
            if (n > 0)
            {
                int[,] macierz = new int[n, n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.WriteLine("Wprowadz element [" + (i + 1) + "]" + "[" + (j + 1) + "]: ");
                        macierz[i, j] = int.Parse(Console.ReadLine());

                    }
                }

                Console.WriteLine("Twoja macierz: ");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(macierz[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                if ((n == 3) && ((macierz[0, 1] + macierz[0, 2] + macierz[1, 2]) > (macierz[1, 0] + macierz[2, 0] + macierz[2, 1])))
                {
                    Console.WriteLine("Suma elementów powyżej głównej przekątnej jest większa od sumy elementów poniżej głównej przekątnej");
                }
                else if ((n == 2) && ((macierz[0, 1]> (macierz[1, 0]))))
                {
                    Console.WriteLine("Suma elementów powyżej głównej przekątnej jest większa od sumy elementów poniżej głównej przekątnej");
                }
                else
                { 
                    Console.WriteLine("Suma elementów powyżej głównej przekątnej nie jest większa od sumy elementów poniżej głównej przekątnej");
                }
            }Console.ReadLine();
        }
    }
}

  