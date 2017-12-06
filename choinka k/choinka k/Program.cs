using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace próba
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    int A, B, N;
                    string C, D;
                    Console.WriteLine("Podaj wysokosc a=: ");
                    A = int.Parse(Console.ReadLine());

                    Console.WriteLine("Podaj szerokosc b=: ");
                    B = int.Parse(Console.ReadLine());

                    Console.WriteLine("Podaj pierwszy znak: ");
                    C = Console.ReadLine();

                    Console.WriteLine("Podaj drugi znak: ");
                    D = Console.ReadLine();


                    int wysokosc = A;
                    int szerokosc = B;
                    string znak1 = C;
                    string znak2 = D;

                    Console.WriteLine("");

                    if ((wysokosc > 0) & (szerokosc > 0) & (znak1.Length == 1) & (znak2.Length == 1))
                    {
                        for (int i = 0; i < A; i++)
                        {

                            for (int j = 0; j <= i*2+1; j++)
                            {
                                if (j % 2 == 0)
                                {
                                    Console.Write(znak1);

                                }
                                else if (j % 2 != 0)
                                {
                                    Console.Write(znak2);

                                }

                            }
                            Console.WriteLine();

                        }
                        Console.ReadLine();

                    }
                    else if ((wysokosc < 0) | (szerokosc < 0))
                    {
                        Console.WriteLine("liczba ujemna");
                        Console.ReadLine();

                    }
                    else if ((znak1.Length != 1) | (znak2.Length != 1))
                    {
                        Console.WriteLine("to nie znak");
                        Console.ReadLine();
                    }
                }

                catch (FormatException)
                {
                    Console.WriteLine("Wprowadzono liczbę w złym formacie");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Wprowadzona liczba jest poza dopuszczalnym zakresem");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Napotkano koniec strumienia");
                }
                Console.WriteLine("Spróbuj jeszcze raz");
            }
        }

    }

}

