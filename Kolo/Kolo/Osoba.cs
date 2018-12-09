using System;
namespace Kolo
{
    public class Osoba
    {
		public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Ulica { get; set; }
        public string NrDomu { get; set; }
        public string NrMieszkania { get; set; }
        public string KodPocztowy { get; set; }
        public string Miasto { get; set; }
        public string Panstwo { get; set; }

        public void AddOsoba()
        {


            Console.Write("Podaj imie: ");
            this.Imie = Console.ReadLine();

            Console.Write("Podaj nazwisko: ");
            this.Nazwisko = Console.ReadLine();

            Console.Write("Podaj ulice: ");
            this.Ulica = Console.ReadLine();

            Console.Write("Podaj numer domu ");
            this.NrDomu = Console.ReadLine();

            Console.Write("Podaj numer mieszkania: ");
            this.NrMieszkania = Console.ReadLine();

            Console.Write("Podaj Kod pocztowy: ");
            this.KodPocztowy = Console.ReadLine();

            Console.Write("Podaj Miasto: ");
            this.Miasto = Console.ReadLine();

            Console.Write("Podaj Państwo: ");
            this.Panstwo = Console.ReadLine();

        }
    }
    }
