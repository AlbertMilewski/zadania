using System;

namespace euklides
{
    /// <summary>
    /// Algorytm Euklidesa.
    /// </summary>
    class Euklides
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Podaj a.");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b.");
            b = int.Parse(Console.ReadLine());

            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }

            Console.WriteLine("Największy wspólny dzielnik (NWD) to: " + a);
            Console.ReadLine();
        }
    }
}