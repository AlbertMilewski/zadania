using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace kooool
{
	public class Pracownik
    {
        string imie;
		private string nazwisko;


		public Pracownik(string new_nazwa, string new_nazwisko)
        {
			this.imie = new_nazwa;
			this.nazwisko = new_nazwisko;

        }
        public virtual void Info()
        {
			Console.WriteLine("Imie: " + imie+"Nazwisko: "+nazwisko);
          
        }
       
    }
}