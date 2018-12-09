using System;
namespace jakieszadanie
{
	public class Osoba
	{
		
		public string Imie { get; set; }
		public string Nazwisko { get; set; }


		public Osoba(string _imie, string _nazwisko)
		{
			this.Imie = _imie;
			this.Nazwisko = _nazwisko;
		}
		public Osoba()
		{

		}
		public override string ToString()
		{
			return this.Imie + " " +this.Nazwisko;
		}
	}
}