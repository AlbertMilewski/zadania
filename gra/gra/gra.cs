using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gra
{
    class Program
    {
        
       static int var(ref int x, int n)
        {
            if (n == 3)
            {
               
                x -=1;
                Console.WriteLine("Komputer zabiera " + 1 + " zapałkę ");
                Console.WriteLine("Liczba zapałek równa się: " + x);
                return x;
                
            }
            else if (n == 2)
            {

                x -= 2;
                Console.WriteLine("Komputer zabiera " + 2 + " zapałki ");
                Console.WriteLine("Liczba zapałek równa się: " + x);
                return x;

            }
            else if (n == 1)
            {

                x -= 3;
                Console.WriteLine("Komputer zabiera " + 3 + " zapałki ");
                Console.WriteLine("Liczba zapałek równa się: " + x);
                return x;

            }
            else
            {
                return n;
            }


        
           
        }
       static int licz(ref int x,int n)
        {
            if (n > 0)
            {

                x = x - n;
                Console.WriteLine("Liczba zapałek równa się: " + x);
                return x;
            }
            else
            {
                return n;
            }
            
       
       

            
        }
        static void text(string a)
        {
           
            Console.WriteLine(a);
        }
        static void show(int x)
        {
            Console.WriteLine("Liczba zapałek równa się: " + x);
        }
        public static void Main(string[] args)
        {
            string a = "Podaj liczbę zapłalek jaką chcesz zabrać";
            Console.WriteLine("Gra w 21 zapałek");
            Console.WriteLine("Graj tak abyś to Ty wizął ostatnią zapałkę");
            int x = 21;
            show(x);
            Random rnd = new Random();
            int kolejność = rnd.Next(0, 2);
           
            if (kolejność == 1)
            {

                Console.WriteLine("Komputer zaczyna");
                Console.WriteLine("Komputer zabiera 1 zapałkę");
                x = 20;
                show(x);
                int n;
                while (x > 0)
                {


                    text(a);
                    n = int.Parse(Console.ReadLine());
                    licz(ref x, n);

                    var(ref x, n);


                }
                Console.WriteLine("Przegrana");
                Console.WriteLine("Wygrana");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ty zaczynasz");
                int n;
                while (x > 0)
                {


                    text(a);
                    n = int.Parse(Console.ReadLine());
                    licz(ref x, n);

                    var(ref x, n);


                }
                Console.WriteLine("Przegrana");
                Console.WriteLine("Wygrana");
                Console.ReadLine();
                Console.ReadLine();

            }

        }

    }
}
