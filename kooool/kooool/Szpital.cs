using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace kooool
{
    class Szpital
    {
		private string nazwa;
		public List<Pracownik> lista_pracowników = new List<Pracownik>();


		public Szpital(string new_nazwa)
        {
			this.nazwa = new_nazwa;
        }
		public void DodajPracownika(Pracownik p)
		{
			lista_pracowników.Add(p);
		}
		public void WyświetlInfo()
		{
			Console.WriteLine("Witaj w szpitalu"+this.nazwa+"Pracują tutaj: ");
			foreach (Pracownik p in lista_pracowników)
			{
				p.Info();
			}
		}
    }
}
