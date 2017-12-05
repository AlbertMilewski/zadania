using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace histogram
{
    class Program
    {
        static void gwaizdki(int n,int [] arr)
        {
            for (int j = 1; j <= 5; j++)
            {
                Console.Write(j + ": ");

                for (int i = 0; i < n; i++)
                    if (arr[i] == j)
                    {
                        Console.Write("*");
                    }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj długość ciągu");
            
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                int[] arr = new int[n];

                for (int i = 0; i < n; i++)
                {

                    while (true)
                    {
                        Console.WriteLine("podaj liczbę z zakresu 1-5. Liczba:  " + (i + 1));
                        int x = int.Parse(Console.ReadLine());
                        if ((x >= 1) & (x <= 5))
                        {


                            arr[i] = x;
                            break;
                        }

                        else if ((x <= 1) & (x >= 5))
                        {
                            Console.WriteLine("liczba nie z przedziału");
                        }
                        else
                        {
                            Console.WriteLine("To nie liczba");
                        }
                    }
                } 
                
               
                gwaizdki(n, arr);

            }
            Console.ReadLine();
            }
        }
    }

