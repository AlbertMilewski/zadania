using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablica_z_gwiazdek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wprowadź liczbę wierszy : ");
            int row = int.Parse(Console.ReadLine());
            int[][] array = new int[row][];
            for (int i = 0; i < row; i++)
            {
                Console.Write("Wprowadź długość wiersza  " + (i + 1) + " : ");
                array[i] = new int[int.Parse(Console.ReadLine())];
            }
      

            Console.WriteLine("Twoja tablica");

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
