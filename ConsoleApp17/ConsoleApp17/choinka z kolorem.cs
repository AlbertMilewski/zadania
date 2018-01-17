using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Choinka
{
    class Program
    {
        static void Main(string[] args)
        {
            int h, g, ls;
            string znaki, linia, nazwa;
            Console.Write("Podaj wysokoœæ choinki:");
            h = int.Parse(Console.ReadLine());
            g = 1;
            ls = h - 1; //liczba spacji przed gwiazdkami w kolejnych wierszach
            Console.WriteLine("WprowadŸ nazwê pliku:");
            nazwa = Console.ReadLine();
            StreamWriter sw = new StreamWriter(nazwa); //deklaracja obiektu sw typu StreamWriter i utworzenie pliku na dysku
            Console.WriteLine("Wprowadzaj kolejne linijki, gdy koniec, to wpisz stop");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            for (int w = 1; w <= h; w++)  //kolejne wiersze
            {
                znaki = "";
                for (int k = 1; k <= ls; k++) //spacje w kolejnym wierszu
                {
                    Console.Write(" ");
                    sw.Write(" ");
                }
                ls--; // zmniejszenie lisczy spacji o jeden w nastepnym wierszu

                for (int k = 1; k <= g; k++) //gwiazdki w kolejnym wierszu
                {
                    if (k%2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        Console.Write("o");
                        sw.Write("o");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;

                        Console.Write("*");
                        sw.Write("*");
                    }
                }
                g = g + 2; // ustawienie liczy gwiazdek w nastepnym wierszu
                Console.WriteLine("");  //przejscie do owej linii
                sw.WriteLine("");
                //

            }
            //wyœwietlenie pnia choinki
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            for (int p = 1; p <= 2; p++)  //kolejne wiersze pnia
            {
                for (int k = 1; k <= h - 1; k++) //spacje w kolejnym wierszu pnia
                {
                    Console.Write(" ");
                    sw.Write(" ");
                }
                Console.WriteLine("|");  //pieñ po spacjach
                sw.WriteLine("|");
            }
            sw.Close();  // zamkniêcie obiektu sw i zapisanie pliku na dysku
            Console.ReadKey(); //zatzrmanie wykonywania programu do wciœniêcia dowolnego przycisku klawiatury
        }
    }
}