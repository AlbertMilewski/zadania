using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace zadanie02v2
{
    class Silnik
    {
        private const double Mila = 1.609344;
        private const double Galon = 3.785411784;
        private readonly double PojemnośćSilnika;
        private readonly double PojemnośćBaku;
        private double IlośćPaliwa;
        private readonly double DomyślnaPojemnośćBaku = 50;

        public Silnik(double nowaPojemnośćSilnika, double nowaIlośćPaliwa)
        {
            this.PojemnośćSilnika = nowaPojemnośćSilnika;
            this.IlośćPaliwa = nowaIlośćPaliwa;
            this.PojemnośćBaku = DomyślnaPojemnośćBaku;
        }
        public Silnik(double nowaPojemnośćSilnika, double nowaIlośćPaliwa, double nowaPojemnośćBaku)
            : this(nowaPojemnośćSilnika, nowaIlośćPaliwa)
        {
            this.PojemnośćBaku = nowaPojemnośćBaku;
        }

		public static void MPG2Lp100km(double MPG)
        {
			Console.WriteLine((100 * Galon) / (Mila * MPG));
        }
		public static void Lp100Km2MPG(double Lp100Km)
        {
			Console.WriteLine((100 * Galon) / (Mila * Lp100Km));
        }
        public void Działaj()
        {
			if (this.IlośćPaliwa <= 0)
			{
				Console.WriteLine("Koniec Paliwa");
				throw new InvalidOperationException("Koniec paliwa!");
			}
            this.IlośćPaliwa -= (4 * this.PojemnośćSilnika) / 100;
        }
        public void Tankuj(double litryPaliwa)
        {
			if (this.IlośćPaliwa + litryPaliwa > this.PojemnośćBaku)
			{
				Console.WriteLine("Osiągnięto maksymalny poziom paliwa");
				throw new ArgumentException("Osiągnięto maksymalny poziom paliwa");
			}
            else this.IlośćPaliwa += litryPaliwa;
			Console.WriteLine("aktualny poziom paliwa: "+Math.Round(IlośćPaliwa,2));
        }
		public void Zuzycie()
		{
			Console.Write("ilosc paliwa: {0,4}", Math.Round(IlośćPaliwa,2));
		}
		public void Stan()
        {
			Console.Write("pojemnosc silnika: "+PojemnośćSilnika+"\nilosc paliwa: " + Math.Round(IlośćPaliwa, 2) +"\npojemność zbiornika: "+PojemnośćBaku);
        }
    }
}