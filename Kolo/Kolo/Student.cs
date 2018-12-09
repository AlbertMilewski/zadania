using System;
namespace Kolo
{
    public class Student
    {
		 string Imie { get; set; }
         string Nazwisko { get; set; }
		public Student( string _imie, string _nazwisko)
        {
			this.Imie = _imie;
			this.Nazwisko = _nazwisko;
			
        }
		public void Info()
		{
			Console.WriteLine("Imie: "+ Imie);
			Console.WriteLine("Nazwisko: "+Nazwisko);
		}
    }
}
