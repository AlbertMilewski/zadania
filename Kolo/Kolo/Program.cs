using System;
using System.Collections.Generic;

namespace Kolo
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Uczelnia> lista_studentow = new List<Uczelnia>();
			string a = "";

			while (a != "koniec")
			{
				Console.WriteLine("Wpisz: ");
				Console.WriteLine("dodaj - jesli chcesz dodać studentów do uczelni");
				Console.WriteLine("szczegóły - jesli chcesz wyswietlić szczegółowe dane studentów");
				Console.WriteLine("lista - aby wyświetlić listę studentów");
				Console.WriteLine("koniec - aby zakończyć działanie programu");
				a = Console.ReadLine();

				switch (a)
				{
					case "dodaj":
						Console.WriteLine("Jak wielu studentów chcesz dodać?");
						while (true)
						{
							try
							{
								int ile = int.Parse(Console.ReadLine());
								for (int n = 0; n < ile; n++)
								{
									Console.Clear();
									Console.WriteLine("Podaj dane studenta numer " + (n + 1));
									Console.WriteLine("Podaj Imię");
									string imie = Console.ReadLine();
									Console.WriteLine("Podaj Nazwisko");
									string nazwisko = Console.ReadLine();
									Student student = new Student(imie, nazwisko);
									Console.WriteLine("Podaj numer albumu");
									int numer = int.Parse(Console.ReadLine());
									Uczelnia uczelnia = new Uczelnia(student, numer);
									lista_studentow.Add(uczelnia);

								}
								Console.Clear();
								Console.WriteLine("Twoja uczelnia wygląda tak: ");
								Console.WriteLine();
								for (var i = 0; i < lista_studentow.Count; i++)
								{
									lista_studentow[i].Poka();
									Console.WriteLine("*********************************");
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
								lista_studentow[numer - 1].Poka();
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
						Console.WriteLine("Twoja uczelnia wygląda tak: ");
						Console.WriteLine();

						for (var i = 0; i < lista_studentow.Count; i++)
						{
							
							lista_studentow[i].Poka();
							Console.WriteLine("*********************************");

						}
						Console.WriteLine();
						break;
				}


			}
		}
	}
}