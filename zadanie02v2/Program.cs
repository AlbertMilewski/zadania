using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace zadanie02v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Silnik Ecoboost = new Silnik(1,50,300);
            Samochód Focus = new Samochód("Ford", "Focus", Ecoboost);
			Focus.Jedź(100);
			Focus.Tankuj(50);
			Console.ReadLine();
			     
        }
    }
}