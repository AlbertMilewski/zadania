using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void PrintArray(int[] array, int n)
        {
            for(int i=0; i<n; i++)
            {
                Console.WriteLine("Podaj liczbę: "+(i+1));
                array[i] = int.Parse(Console.ReadLine());

            }
        }
        static void odwracanie(int [] array, int b)
        {
            for (int i=0; i<b; b--)
            {
                Console.WriteLine(array[b-1]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ile liczb chcesz wprowadzić?");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            PrintArray(array, n);
            int b = n;
            Console.WriteLine();
            odwracanie(array, b);
            Array.Reverse(array);
            foreach(int a in array)
            {
                Console.WriteLine(a);
            }

            Console.ReadLine();
        }
    }
}
