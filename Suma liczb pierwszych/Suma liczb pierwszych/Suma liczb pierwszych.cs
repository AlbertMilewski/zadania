using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    int a, b, n, i, j, x, y;
                    int[] tablica = new int[10000];

                    Console.WriteLine("Podaj gorny n, do ktorego chcesz odnalezc liczby pierwsze");
                    n = int.Parse(Console.ReadLine());
                    //n to zakres
                    x = (int)Math.Floor(Math.Sqrt(n));

                    for (i = 1; i <= n; i++) tablica[i] = i;

                    for (i = 2; i <= x; i++)
                    {
                        if (tablica[i] != 0)
                        {
                            j = i + i;
                            while (j <= n)
                            {
                                tablica[j] = 0;
                                j += i;
                            }
                        }
                    }

                    Console.WriteLine("Liczby pierwsze z przedziału domknietego od 1 do " + n + ":");
                    for (i = 2; i <= n; i++)
                        if (tablica[i] != 0)
                            Console.Write(i + ", ");
                    int[] arr = new int[n]; //tablica zawierająca liczby parzyste
                    Console.WriteLine();
                    b = 0;
                    Console.WriteLine("Liczby parzyste w przedziale domkniętym 0 do " + n + ":");
                    for (i = 0; i <= n; i += 2)
                    {
                        arr[b] = i;
                        Console.Write(i + ",");
                        b++;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Suma dwóch liczb pierwszych równającyhc się liczbą parzystym z przedziału 0 do " + n + ":");
                    for (i = 2; i <= n; i++)
                    {

                        for (j = 2; j <= n; j++)
                            if (((tablica[i] + tablica[j]) == arr[n / 2]) & (tablica[i] != 0) & (tablica[j] != 0))
                            {
                                Console.WriteLine();
                                Console.Write(tablica[i] + " + " + tablica[j] + " = " + arr[(n / 2)]);

                            }

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
                catch(IndexOutOfRangeException)
                {
                    Console.WriteLine("Zbyt duża liczba");
                }
                Console.WriteLine("Spróbuj jeszcze raz");
            } 
        }
    
    }


}