using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liczby_w_odwrotnej_kolejności
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            for (int n = 1; n <= 5; n++)
            {
                Console.WriteLine("Podaj liczbę " + n);
                array[n-1] = int.Parse(Console.ReadLine());
                Console.Clear();
                
            }
            Console.WriteLine("Twoje liczby w odwrotnej kolejności: ");
            for (int z = 4; z >= 0; z--)
            {
                Console.WriteLine(array[z]);
                
            }
            Console.ReadLine();
        }
    }
}
