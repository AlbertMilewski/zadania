using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace zadanie02v2
{
    class Samochód
    {
        private string marka;
        private string model;
        private Silnik silnik;
        public Samochód(string nowaMarka, string nowyModel, Silnik nowySilnik)
        {
            this.marka = nowaMarka;
            this.model = nowyModel;
            this.silnik = nowySilnik;
        }
		public Samochód(string nowaMarka, string nowyModel, int nowaPojemnośćSilnika, int nowaIlośćPaliwa)
            : this(nowaMarka, nowyModel, new Silnik(nowaPojemnośćSilnika, nowaIlośćPaliwa))
        {

        }
		public Samochód(string nowaMarka, string nowyModel, int nowaPojemnośćSilnika, int nowaIlośćPaliwa, double nowaPojemnośćBaku)
            : this(nowaMarka, nowyModel, new Silnik(nowaPojemnośćSilnika, nowaIlośćPaliwa, nowaPojemnośćBaku))
        {

        }
        public void Jedź(double dystans)
        {
			Console.WriteLine("Jedziesz samochodem\nmarka: "+marka+"\nmodel: "+model);
			this.silnik.Stan();
			Console.WriteLine("\nJadę "+dystans+" km");
            while (dystans >= 0)
            {
				Console.SetCursorPosition(0, Console.CursorTop);
				Console.Write("Dystans do przejechania:{0,4}\t", dystans);
				this.silnik.Działaj();
				this.silnik.Zuzycie();
                Thread.Sleep(100);
                dystans--;
            }
            Console.WriteLine("\nJestem");

        }
		public void Tankuj(int litry)
        {
			Console.WriteLine("Tankuje "+litry+"l paliwa");
            this.silnik.Tankuj(litry);

        }
    }
}