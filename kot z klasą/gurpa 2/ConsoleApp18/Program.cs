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
                    Console.WriteLine("ile osób chcesz wprowadzić?");
                    int n = int.Parse(Console.ReadLine());
                    if (n > 0)
                     {
                    for (int i = 0; i < n; i++)
                    {
                        czlowiek osoba = new czlowiek();
                        Console.WriteLine("Podaj imie");
                        osoba.imie = Console.ReadLine();
                        Console.WriteLine("Podaj nazwisko");
                        osoba.nazwisko = Console.ReadLine();
                        Console.WriteLine("Podaj zawód");
                        osoba.zawod = Console.ReadLine();
                        Console.WriteLine("Imię: " + osoba.imie + " Nazwisko: " + osoba.nazwisko + " Zawód: " + osoba.zawod);
                        sw.WriteLine("Imię: " + osoba.imie + " Nazwisko: " + osoba.nazwisko + " Zawód: " + osoba.zawod);
                    }
                    Console.ReadLine();
                    sw.Close();
                    
                     }
                    else Console.WriteLine("Ujemna liczba osób");

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
        public struct czlowiek
        {
            public string imie;
            public string nazwisko;
            public string zawod;

        }
    }
}
