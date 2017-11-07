using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nieregularna_tablica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wprowadź liczbę wierszy : ");
            int row = int.Parse(Console.ReadLine());
            int[][] array = new int[row][];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Wprowadź długość wiersza  " + (i + 1) + " : ");
                array[i] = new int[int.Parse(Console.ReadLine())];
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write("Enter Wartość wiersza " + (i + 1) + ", wyraz " + (j + 1) + " : ");
                    array[i][j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            Console.WriteLine("Reading values..\n");

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j].ToString() + "\t\t");

                }
                Console.WriteLine();
            }

            Console.ReadLine();



        }
    }
}
