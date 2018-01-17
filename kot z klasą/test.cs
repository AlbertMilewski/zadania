using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        public struct czlowiek //deklaracja typu strukturalnego
        {
            public string nazwisko;
            public string imie;
            public string zawod;
        }
        static void Main(string[] args)
        {
            try
            {
                string nazwa;
                int liczba;
                while(true)//ile osób wprowadzić
                {
                    Console.Write("Podaj ile osób chcesz wprowadzić(max 5): ");
                    liczba = int.Parse(Console.ReadLine());
                    if (liczba > 0 && liczba <= 5) break;//przedział ilości osób
                    Console.WriteLine("Podałeś złą liczbę osób");
                }
                  
                Console.Write("Podaj nazwę pliku: ");
                nazwa = Console.ReadLine();
                StreamWriter zapis = new StreamWriter(nazwa);//utworzenie pliku o nazwie ze zmiennej nazwa
                czlowiek[] tablica = new czlowiek[5]; //tablica struktury

                for (int i = 0; i < liczba; i++)
                {
                    Console.WriteLine("Podaj dane osoby nr. " + (i + 1));
                    Console.Write("Podaj nazwisko: ");
                    tablica[i].nazwisko = Console.ReadLine();//wpisanie z klawiatury do zmiennej nazwisko
                    Console.Write("Podaj imę: ");
                    tablica[i].imie = Console.ReadLine();
                    Console.Write("Podaj zawód: ");
                    tablica[i].zawod = Console.ReadLine();
                    zapis.WriteLine(tablica[i].nazwisko + ", " + tablica[i].zawod + ", " + tablica[i].imie); //zapis do pliku lini z danymi
                }
                zapis.Close();
                Console.ReadKey();
            }
            catch(System.FormatException) //błąd
            {
                Console.WriteLine("To nie jest liczba1");
                Console.ReadKey();

            }
        }
        
    }
}
