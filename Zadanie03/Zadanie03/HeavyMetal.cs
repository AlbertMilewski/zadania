using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Zadanie03
{
    class HeavyMetal : Rock
    {
        string brzmienie = "HeavyMetal";
        string gatunek;
        string wykonawca;

		public HeavyMetal(string wykonawca, string new_nazwa, string gatunek)
			:base(wykonawca, new_nazwa, gatunek)
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
            return base.ToString();
        }
    }
}
