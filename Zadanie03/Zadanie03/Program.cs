using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { 
            string[] gatunki = { "Rock", "HeavyMetal", "Jazz", "Country", "Blues" };
            int wybor, wybor2;
            string nazwaPiosenki;
            string nazwaWykonawcy;
            Player p = new Player();

                {

                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Dodawanie piosenki");
                        Console.WriteLine("Podaj gatunek piosenki");
                        for (int i = 0; i < gatunki.Length; i++)
                        {
                            Console.WriteLine(i + "  " + gatunki[i]);
                        }
                        Console.Write("Nr: ");
                        while (true)
                        {
                            wybor = int.Parse(Console.ReadLine());
                            if (wybor < 0 || wybor > 4)
                            {
                                Console.WriteLine("Błędna liczba");
                            }
                            else { break; }
                        }

                        Console.WriteLine("Podaj wykonawcę: ");
                        nazwaWykonawcy = Console.ReadLine();

                        Console.WriteLine("Podaj nazwę piosenki: ");
                        nazwaPiosenki = Console.ReadLine();
                        
                        switch (wybor)
                        {
                            case 0:
                                Song rock = new Rock(nazwaWykonawcy, nazwaPiosenki, gatunki[0]);
                                p.Add(rock);
                                Console.WriteLine();
                                break;
                            case 1:
                                Song hm = new HeavyMetal(nazwaWykonawcy, nazwaPiosenki, gatunki[1]);
                                p.Add(hm);
                                Console.WriteLine();
                                break;
                            case 2:
                                Song jazz = new Jazz(nazwaWykonawcy, nazwaPiosenki, gatunki[2]);
                                p.Add(jazz);
                                Console.WriteLine();
                                break;
                            case 3:
                                Song country = new Country(nazwaWykonawcy, nazwaPiosenki, gatunki[3]);
                                p.Add(country);
                                Console.WriteLine();
                                break;
                            case 4:
                                Song blues = new Blues(nazwaWykonawcy, nazwaPiosenki, gatunki[4]);
                                p.Add(blues);
                                Console.WriteLine();
                                break;
                            default:
                                break;
                        }

                        Console.WriteLine("Dodać następną piosenkę? 1 - Tak, 2 - Nie");
                        wybor2 = int.Parse(Console.ReadLine());
                        if (wybor2 == 1)
                        {
                            Console.WriteLine();
                        }
                        else if (wybor2 == 2)
                        {
                            break;
                        }
                    }

                    while (true)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Menu");
                        Console.WriteLine("0. Usuwanie piosenki z listy");
                        Console.WriteLine("1. Wyślwietl listę piosenek");
                        Console.WriteLine("2. Odtwórz piosenkę z listy");
                        Console.WriteLine("3. Odtwórz wszystkie piosenki");
                        Console.WriteLine("4. Zakończ program");
                        wybor = int.Parse(Console.ReadLine());


                        switch (wybor)
                        {
                            case 0:
                                Console.Clear();
                                Console.Write("Podaj numer piosenki do usunięcia: ");
                                p.Remove(int.Parse(Console.ReadLine()));
                                break;
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Lista Piosenek");
                                p.Show();
                                break;
                            case 2:
                                Console.Clear();
                                Console.Write("Podaj numer piosenki do odtworzenia: ");
                                p.PlayOne(int.Parse(Console.ReadLine()));
                                break;
                            case 3:
                                Console.Clear();
                                p.PlayAll();
                                break;
                            case 4:
                                Environment.Exit(1);
                                break;

                        }


                    }


                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Błędna wartość!");
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Za duża wartość!");
            }
        }
    }
}
