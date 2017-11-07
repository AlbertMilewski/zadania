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
                        int tab = tablica[i];
                        tablica[i] = tablica[i + 1];
                        tablica[i + 1] = tab;
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
            while (true)
            {
                try
                {
                    if (n > 0)
                    {
                        int[] arr = new int[n];
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("Wprowadz liczbę [" + (i + 1) + "]");
                            int l = int.Parse(Console.ReadLine());


                            {
                                if ((l > 10) | (l < 1))
                                {
                                    

                                    goto Błąd; 
                                }
                                else
                                {
                                    arr[i] = l;



                                }
                            }
                        }
                        Console.WriteLine("Twoje liczby: ");
                        for (int z = 0; z < n; z++)
                        {

                            Console.Write(arr[z] + " ");

                        }
                        sort(arr);
                        Console.WriteLine();
                        Console.WriteLine("\n\nPo sortowaniu : \n");
                        for (int z = 0; z < arr.Length; z++)
                        {
                            Console.Write(arr[z] + ", ");
                        }
                        Console.ReadLine();
                        Błąd:
                        Console.WriteLine("Zła liczba");
                    }
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
