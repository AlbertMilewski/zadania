using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź nazwę pliku:");
            string nazwa = Console.ReadLine();
            StreamWriter sw = new StreamWriter(nazwa);

            while (true)
            {
                try
                {                    
                            auto auto = new auto();
                            Console.WriteLine("Podaj marka");
                            auto.marka = Console.ReadLine();
                            Console.WriteLine("Podaj model");
                            auto.model = Console.ReadLine();
                            Console.WriteLine("Podaj rok produkcji");
                    int rok_produkcji = int.Parse(Console.ReadLine());
                    if (rok_produkcji > 0)
                    {
                        auto.rok_produkcji = rok_produkcji;
                        Console.WriteLine("Marka " + auto.marka + " Model: " + auto.model + " Rok produkcji: " + auto.rok_produkcji);
                        sw.WriteLine("Marka: " + auto.marka + " Model: " + auto.model + " Rok produkcji: " + auto.rok_produkcji);

                        Console.WriteLine("Chcesz dodać następne auto? Jeśli nie wpisz stop");
                        string koniec = Console.ReadLine();
                        if (koniec == "stop")
                        {
                            Console.WriteLine("Dane zostały zapisane");
                            sw.Close();
                            Console.ReadLine();
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("ujemna liczba");

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
            }
        }
        public struct auto
        {
            public string marka;
            public string model;
            public int rok_produkcji;

        }
    }
}
