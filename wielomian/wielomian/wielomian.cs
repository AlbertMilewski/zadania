using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Horner_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    int n, x;
                    Console.WriteLine("Podaj stopień wielomioanu: ");
                    n = int.Parse(Console.ReadLine());

                    int[] a = new int[n];
                    int[] b = new int[n];
                    double[] c = new double[n];
                    int o = n;
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("Podaj współczynnik przy x^" + (o));
                        a[i] = int.Parse(Console.ReadLine());
                        o--;
                    }


                    Console.WriteLine("Podaj x:");
                    x = int.Parse(Console.ReadLine());
                    int w;
                    Console.WriteLine("Podaj wyraz wolny: ");
                    w = int.Parse(Console.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        //potęgowanie wyrazu z tablicy przez x
                        b[i] = (a[i] * x);
                    }
                    int m = n;
                    for (int i = 0; i < n; i++)
                    {
                        c[i] = (Math.Pow(b[i], m));
                        m--;
                    }


                    double wynik = 0;
                    for (int i = 0; i < n; i++)
                    {
                        wynik += c[i];
                    }


                    Console.WriteLine("Wynik to: " + (wynik + w));
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
    
