using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{

    class Program
    {
        public struct osoby //deklracja typu strukturalnego
        {
            public string nazwisko;
            public string imie;
            public string mail;
            public string telefon;
        }
        static void Main(string[] args)
        {
            osoby Osoba1; //deklaracja zmiennej typu osoba

            //wczytanie danych do zmiennej Osoba1 typu osoby
            Console.Write("Podaj nazwisko: ");
            Osoba1.nazwisko = Console.ReadLine();
            Console.Write("Podaj imię: ");
            Osoba1.imie = Console.ReadLine();
            Console.Write("Podaj e-mail: ");
            Osoba1.mail = Console.ReadLine();
            Console.Write("Podaj nr telefonu: ");
            Osoba1.telefon = Console.ReadLine();
            wypisz_osobe(Osoba1); //użycie funkcji wyświetlającej dane zapisane w zmiennej Osoba1 typu osoby
            Console.ReadKey();
        }
        static void wypisz_osobe(osoby kto)  //definicja funkcji wyświetlającej dane zapisane w zmiennej typu osoby
        {
            Console.WriteLine("Nazwisko=" + kto.nazwisko);
            Console.WriteLine("Imię=" + kto.imie);
            Console.WriteLine("e-mail=" + kto.mail);
            Console.WriteLine("ne telefonu =" + kto.telefon);
        }
    }
}