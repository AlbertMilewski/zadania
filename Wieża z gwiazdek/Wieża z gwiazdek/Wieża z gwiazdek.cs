using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wieża_z_gwiazdek
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int h, d, e,x,i;
            s = " "; //space
            x = 1; //zmienna do zwiększania liczby gwiazdek
            Console.WriteLine("Podaj wysokość");
            h = int.Parse(Console.ReadLine()); //wysokość

            for (i = 1; i <= h; i++) //ogólna ilość powtórzeń pętli
            {
                for (e = 1; e <= h - i; e++) //liczba powtórzeń spacji
                {
                    Console.Write(s);  //space
                }
                    for (d = 1; d<= x; d++) //liczba powtórzeń gwiazdek
                    {

                        Console.Write("*");
                        
                    }
                Console.WriteLine("");
                x = x + 2; //zwiększenie ilości gwiazdek
                
            }
            
            Console.ReadLine();

        }
    }
}
