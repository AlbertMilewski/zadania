using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Zadanie03
{
    public abstract class Song
    {
        string nazwaPiosenki;
        

        public Song(string new_nazwa)
        {
			this.nazwaPiosenki = new_nazwa;

        }
		public virtual void Play()
        {
            Console.WriteLine("Rozpoczynam odtwarzanie: " + nazwaPiosenki);
            Thread.Sleep(1000);
        }
        public override string ToString()
        {
			return "Nazwa piosenki: " + this.nazwaPiosenki;
        }
    }
}
