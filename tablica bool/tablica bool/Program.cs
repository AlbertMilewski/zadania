using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablica_bool
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {

                    int i, j, h, g;
                    int[] tablica = new int[1000];
                    bool[] arr = new bool[1];

                    Console.WriteLine("Podaj liczbę do sprawdzenia");
                    h = int.Parse(Console.ReadLine());

                    g = (int)Math.Floor(Math.Sqrt(h));

                    for (i = 1; i <= h; i++) tablica[i] = i;

                    for (i = 2; i <= g; i++)
                    {
                        if (tablica[i] != 0)
                        {
                            j = i + i;
                            while (j <= h)
                            {
                                tablica[j] = 0;
                                j += i;
                            }
                        }
                    }
                    if (tablica[h] == h)
                        arr[0] = true;
                    else
                        arr[0] = false;


                    if (arr[0] == true)
                        Console.WriteLine(h + " Jest liczbą pierwszą ");
                    else
                    {
                        Console.WriteLine(h + " Nie jest liczbą pierwszą");
                        Console.WriteLine(h + " Jest liczbą złożoną podzielną przez: ");
                        for (int a = 1; a <= h; a++)
                            if (h % a == 0)
                                Console.Write(a + ", ");


                    }
                    Console.ReadLine();
                }

                catch (FormatException)
                {
                    Console.WriteLine("Wprowadzono liczbę w złym formacie");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Wprowadzona liczba jest poza dopuszczalnym zakresem");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Napotkano koniec strumienia");
                }
                Console.WriteLine("Spróbuj jeszcze raz");
            }
        }
    }
}
