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
            int n;
            Console.WriteLine("Podaj stopień wielomioanu: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];
            int[] b = new int[n];
            double[] c = new double[n];
            int o = n;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj współczynnik przy x^" + (o));
                a[i] = Convert.ToInt32(Console.ReadLine());
                o--;
            }

            int x;

            Console.WriteLine("Podaj x:");
            x = Convert.ToInt32(Console.ReadLine());
            int w;
            Console.WriteLine("Podaj wyraz wolny: ");
            w = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                //mnożenie wyrazu przy x przez x
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
    }
}