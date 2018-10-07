
using System;
using System.Collections.Generic;
using System.Linq;
namespace adress_v2
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Osoba> lista_osob = new List<Osoba>();

            string a = "";

            while (a != "koniec")
            {
                Console.WriteLine("Wpisz: ");
                Console.WriteLine("dodaj - jesli chcesz dodać osoby do książki");
                Console.WriteLine("szczegóły - jesli chcesz wyswietlić szczegółowe dane osobowe z książki");
                Console.WriteLine("lista - aby wyświetlić listę kontaktów");
                Console.WriteLine("koniec - aby zakończyć działanie programu");
                a = Console.ReadLine();

                switch (a)
                {
                    case "dodaj":
                        Console.WriteLine("Jak wiele osób chcesz dodać?");
                        while (true)
                        {
                            try
                            {
                                int ile = int.Parse(Console.ReadLine());
                                for (int n = 0; n < ile; n++)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Podaj dane osoby numer " + (n + 1));
                                    Osoba osoba = new Osoba();
                                    osoba.AddOsoba();
                                    lista_osob.Add(osoba);

                                }
                                Console.Clear();
                                Console.WriteLine("Twoja książka adresowa: ");
                                for (var i = 0; i < lista_osob.Count; i++)
                                {
                                    Console.WriteLine(i + 1 + " " +lista_osob[i].Imie+" "+ lista_osob[i].Nazwisko);
                                }
                                Console.WriteLine();
                                break;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Wprowadzono liczbę w złym formacie");
                                Console.WriteLine("Podaj liczbę jeszcze raz");
                            }
                            catch (OverflowException)
                            {
                                Console.WriteLine("Wprowadzona liczba jest poza dopuszczalnym zakresem");
                                Console.WriteLine("Podaj liczbę jeszcze raz");

                            }

                        }
                        break;

                    case "szczegóły":
                        Console.Clear();
                        Console.WriteLine("Wpisz numer osoby której chcesz wyświetlić szczegółowe dane");
                        while (true)
                        { 
                            try
                            {
                                int numer = int.Parse(Console.ReadLine());
                              Console.Clear();
                              Console.WriteLine("Sczególowe dane osoby:");
                              Console.WriteLine(lista_osob[numer-1].Imie+" "+lista_osob[numer-1].Nazwisko);
                              Console.WriteLine("Ul."+lista_osob[numer-1].Ulica+" "+lista_osob[numer-1].NrDomu+"/"+lista_osob[numer-1].NrMieszkania);
                              Console.WriteLine(lista_osob[numer-1].KodPocztowy+" "+lista_osob[numer-1].Miasto);
                              Console.WriteLine(lista_osob[numer-1].Panstwo);
                              Console.ReadLine();
                                break;
                            }
                            
                            catch (FormatException)
                            {
                                Console.WriteLine("Wprowadzono liczbę w złym formacie");
                                Console.WriteLine("Podaj liczbę jeszcze raz");
                            }
                            catch (OverflowException)
                            {
                                Console.WriteLine("Wprowadzona liczba jest poza dopuszczalnym zakresem");
                                Console.WriteLine("Podaj liczbę jeszcze raz");

                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Nie ma takiej osoby");
                                Console.WriteLine("Podaj liczbę jeszcze raz");


                            }

                        }
                        break;
                    case "lista":
                        Console.Clear();
                        Console.WriteLine("Twoja książka adresowa: ");
                        for (var i = 0; i < lista_osob.Count; i++)
                        {
                            Console.WriteLine(i + 1 + " " + lista_osob[i].Imie + " " + lista_osob[i].Nazwisko);
                        }
                        Console.WriteLine();
                        break;
                }
            }


        }
    }
}