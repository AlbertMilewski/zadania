using System;

namespace kooool
{
    class Program
    {
        static void Main(string[] args)
        {
			Szpital szpital = new Szpital("Nowy");
			Pracownik jeden = new Pracownik("Tomek", "Kowalski");
			Pracownik dwa = new Pracownik("Jan", "Wielogurka");
			Lekarz jedenlekarz = new Lekarz("kradiolog", "stefan", "werc");
			Lekarz dwalekarz = new Lekarz("okulista", "marian", "kaczmarek");

			szpital.DodajPracownika(jeden);
			szpital.DodajPracownika(dwa);
			szpital.DodajPracownika(jedenlekarz);
			szpital.DodajPracownika(dwalekarz);
			szpital.WyświetlInfo();


        }
    }
}
