using System;

namespace se_cs
{
    /// <summary>
    /// Sito Eratostenesa - poszukiwanie liczb pierwszych
    /// </summary>
    class Sito_Eratostenesa
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            int i, j, zakres, dokad;
            int[] tablica = new int[10000];

            Console.WriteLine("Podaj gorny zakres, do ktorego chcesz odnalezc liczby pierwsze");
            zakres = int.Parse(Console.ReadLine());
            dokad = (int)Math.Floor(Math.Sqrt(zakres));

            //inicjuj tablice
            for (i = 1; i <= zakres; i++) tablica[i] = i;

            //algorytm - sito eratostenesa
            for (i = 2; i <= dokad; i++)
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

            //wypisz wynik
            Console.WriteLine("Liczby pierwsze z zakresu od 1 do " + zakres);
            for (i = 2; i <= zakres; i++)
                if (tablica[i] != 0)
                    Console.WriteLine(i + ", ");
            Console.ReadLine();
        }
    }
}