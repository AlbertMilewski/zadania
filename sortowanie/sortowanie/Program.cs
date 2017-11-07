using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortowanie
{
    class Program
    {
        static void sort(int[] tablica)
        {
            int n = tablica.Length;
            do
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (tablica[i] > tablica[i + 1])
                    {
                        int tmp = tablica[i];
                        tablica[i] = tablica[i + 1];
                        tablica[i + 1] = tmp;
                    }
                }
                n--;
            }
            while (n > 1);
        }

        static void Main(string[] args)
        {
           
            Console.WriteLine("Wprowadź długość ciągu");
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                int[] arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Wprowadz liczbę [" + (i + 1) + "]");
                    arr[i] = int.Parse(Console.ReadLine());

                }
                Console.WriteLine("Twoje liczby: ");
                for (int i = 0; i < n; i++)
                {
                   
                        Console.Write(arr[i] + " ");
 
                }
                sort(arr);
                Console.WriteLine();
                Console.WriteLine("\n\nPo sortowaniu : \n");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + ", ");
                }

                Console.ReadLine();
            }
        }
    }
}
