using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prostokąt_z_gwiazdek
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            int c, d,e, f ; 
            a = "*";
           
            Console.WriteLine("Podaj liczbę wierszy");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę gwiazdek");
            d = int.Parse(Console.ReadLine());

            for(e=1; e<=c; e++)
            {
                Console.WriteLine();

                for(f=1; f<=d; f++)
                {

                    Console.Write(a);

                }

            }
            Console.ReadLine();


        }
    }
}
