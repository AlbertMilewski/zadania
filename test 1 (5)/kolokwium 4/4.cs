using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwium_4
{
    class Program
    {
        static double odleglosc(int[] x, int[] y,double [] wyniki, int n, ref double sum)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj współrzędne punktu x " + (i + 1));
                x[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj współrzędne punktu y " + (i + 1));
                y[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Punkt " + x[i] + "," + y[i]);

                Console.WriteLine("Odległość punku " + x[i] + "," + y[i] + " to " + Math.Sqrt(((x[i]) * (x[i])) + ((y[i])) * (y[i])));
                wyniki[i] = Math.Sqrt(((x[i]) * (x[i])) + ((y[i])) * (y[i]));
                sum = wyniki.Sum();
                
            }
            return sum;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ile punktów chcesz sprawdzić?");
            int n = int.Parse(Console.ReadLine());
            int [] x = new int[n];
            int[] y = new int[n];
            double sum = 0;
            double[] wyniki = new double[n];
                odleglosc(x, y, wyniki, n, ref sum);
            Console.WriteLine("Suma odległości równa się: "+sum);
                

            
            Console.ReadLine();
        }
    }

}