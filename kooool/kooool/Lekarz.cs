using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace kooool
{
	class Lekarz : Pracownik
    {
        string specjalizacja;
		public Lekarz(string new_specjalizacja, string new_nazwa, string new_nazwisko)
			: base(new_nazwa, new_nazwisko)
        {

			this.specjalizacja = new_specjalizacja;
				
        }

        public override void Info()
        {
			Console.WriteLine("Lekarz");
			base.Info();
			Console.WriteLine("Specjalizacja:"+specjalizacja);
        }
       

    }
}