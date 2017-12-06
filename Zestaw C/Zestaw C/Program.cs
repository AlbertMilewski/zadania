using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw_C
{
    class Program
    {
        static void drukuj(int i, int [] arr)
        {
            
            for (int a = 0; a< arr[i]; a++)
            {
                Console.Write("*");
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Podaj długość tablicy");
                    int n = int.Parse(Console.ReadLine());
                    if (n > 0)
                    {
                        int[] arr = new int[n];

                        for (int i = 0; i < n; i++)
                        {

                            while (true)
                            {
                                Console.WriteLine("podaj liczbę dodatnią. Liczba:  " + (i + 1));
                                int x = int.Parse(Console.ReadLine());
                                if (x > 0)
                                {


                                    arr[i] = x;
                                    break;
                                }

                                else if (x < 0)
                                {
                                    Console.WriteLine("liczba nie z przedziału");
                                }
                                else
                                {
                                    Console.WriteLine("To nie liczba");
                                }
                            }
                        }
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write(arr[i]);
                            drukuj(i,arr);
                            i++;
                        }
                        Console.ReadLine();
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