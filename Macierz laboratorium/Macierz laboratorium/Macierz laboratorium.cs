using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macierz_laboratorium
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int n, SumaP, SumaN;
                SumaN = 0;
                SumaP = 0;
                Console.WriteLine("Podaj stopień macierzy");
                n = int.Parse(Console.ReadLine());
                int[,] tab = new int[n, n];
                string zakończenie = "Tak";
                string koniec;
                int z = 0;

                do
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write("Podaj element [" + (i + 1) + "," + (j + 1) + "]:");
                            tab[i, j] = int.Parse(Console.ReadLine());
                            if (j > i) SumaN = SumaN + tab[i, j];
                            else if (j < i) SumaP = SumaP + tab[i, j];

                        }
                    }
                    if (SumaN > SumaP)
                    {
                        Console.Write("Suma elementów powyżej głownej przekątnej równa się (=" + SumaN + ")");
                        Console.WriteLine("jest większa od sumy elementów poniżej głównej przekątnej");
                        Console.WriteLine("(=" + SumaP + ")");
                    }
                    else if (SumaN < SumaP)
                    {
                        Console.Write("Suma elementów powyżej głownej przekątnej równa się (=" + SumaN + ")");
                        Console.Write("jest mniejsza od sumy elementów poniżej głównej przekątnej");
                        Console.Write("(=" + SumaP + ")");
                    }
                    else
                    {
                        Console.Write("Suma elementów powyżej głownej przekątnej równa się (=" + SumaN + ")");
                        Console.Write("jest równa do sumy elementów poniżej głównej przekątnej");
                        Console.Write("(=" + SumaP + ")");
                    }
                    Console.Write("Jeśli chcesz zakończyć napisz ,,Tak'' ");
                    koniec = Console.ReadLine();
                    if (koniec == zakończenie)
                    {
                        Console.WriteLine("Do zobaczenia");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Liczymy jeszcze raz");
                        z++;
                    }
                } while (z <= 3);
                Console.ReadLine();
            }
        }
    }
