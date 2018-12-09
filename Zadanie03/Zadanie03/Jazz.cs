using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Zadanie03
{
    class Jazz : Song
    {
        string brzmienie = "Jazz";
        string gatunek;
        string wykonawca;
        public Jazz(string wykonawca, string new_nazwa, string gatunek)
			: base(new_nazwa)
        {
            this.wykonawca = wykonawca;
            this.gatunek = gatunek;
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine(brzmienie);
            Thread.Sleep(1000);
        }
        public override string ToString()
        {
			return base.ToString() + " Wykonawca: " + this.wykonawca + " Gatunek: " + this.gatunek;
        }
    }
}
