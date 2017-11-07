using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liczby_pierwsze_podane_przez_użytkownika
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, zakres, max;
            int[] tablica = new int[10000];

            Console.WriteLine("Podaj do jakiej liczby chcesz odnaleźć liczby pierwsze");
            zakres = int.Parse(Console.ReadLine());
            max = (int)Math.Floor(Math.Sqrt(zakres));

            for (i = 1; i <= zakres; i++) tablica[i] = i;

            //algorytm - sito eratostenesa
            for (i = 2; i <= max; i++)
            {
                if (tablica[i] != 0)
                {
                    j = i + i;
                    while (j <= zakres)
                    {
                        tablica[j] = 0;
                        j += i;
                    }
                }
            }

            Console.WriteLine("Liczby pierwsze z zakresu od 1 do " + zakres);
            for (i = 2; i <= zakres; i++)
                if (tablica[i] != 0)

                    Console.Write(i + ", ");
            Console.ReadLine();
        }
        
    }
}
