using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj długość ciągu");
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[n,n];
            for (int i = 0; i<n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Wprowadź liczbę " + (i + 1)+"  "+(j+1));
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            

            }
            //wyswietlanie
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <n; j++)
                {
                    Console.Write(array[i,j] + "\t");

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
