using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lancuchy
{
    class Pliki2
    {
        static void Main(string[] args)
        {
            string znaki, linia, nazwa;
            int licznik = 0;
            //zapis do pliku
            Console.WriteLine("Wprowadź nazwę pliku:");
            nazwa = Console.ReadLine();
            StreamWriter sw = new StreamWriter(nazwa); //deklaracja obiektu sw typu StreamWriter i utworzenie pliku na dysku
            Console.WriteLine("Wprowadzaj kolejne linijki, gdy koniec, to wpisz stop");
            while (true)
            {
                znaki = Console.ReadLine();  //wczytanie ciągu znaków do zmiennej znaki typu string
                if (znaki == "stop") break; //jeśli wprowadzono ciąg "stop" to wyjscie z pętli
                else sw.WriteLine(znaki); //jesli różne od "stop" to zapisanie kolejnego wiersza do obietu sw
            }
            sw.Close();  // zamknięcie obiektu sw i zapisanie pliku na dysku

            //odczyt z pliku
            try  //obsługa wyjątków podczas odczytu pliku
            {
                StreamReader sr = new StreamReader(nazwa);
                while (!sr.EndOfStream)  //gdy nie napotkano końca pliku, czyli jest kolejna linia w pliku
                {
                    linia = sr.ReadLine(); //odczytanie kolejnej linii pliku i zapamiętanie w zmiennej linia
                    Console.ForegroundColor = ConsoleColor.Cyan; //usatwienie koloru czcionki na Cyan
                    Console.WriteLine(linia);
                    Console.ForegroundColor = ConsoleColor.White; //ustawienie koloru czcionki na biały
                    Console.WriteLine("liczba znaków w wierszu= " + linia.Length);  // wyźwietlenie informacji o długości linii
                    licznik = 0; //wyzerowanie licznika przed początkiem linii
                    Console.WriteLine("Podaj litere do sprawdzenia");
                    char a = char.Parse(Console.ReadLine());

                    foreach (char c in linia) //odczytanie kolejnych znaków w bieżącej linii - łańcuch znaków jest tablicą jednowymiarową
                    {
                        if (c == a) licznik++;  //jeśli kolejny znak jest zgodny z poszukiwanym to zwiększenie licznika wystąpień tego znaku w linii
                    }
                    if (licznik > 0)
                    {
                        Console.WriteLine("litera \"a\" wystapiła w wierszu " + licznik + " razy, a pierwsze wystąpienie jest na pozycji " + linia.IndexOf(a));
                    }
                    else Console.WriteLine("litera \"a\"" +
                        " nie wystapiła w wierszu");
                    try  //obługa wyjątku dla funkcji Substring
                    {
                        Console.WriteLine("pierwsze 10 znaków to: " + linia.Substring(0, 10));//wyswietlenie pierwszych 10 znaków
                    }
                    catch (System.ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("Linia jest krótsza niż oczekiwany podciag, dlatego nie można wykonać funkcji Substring");
                    }
                }
                sr.Close();
            }
            catch (FileNotFoundException)  //jeśli plik wskazany w inicjalizacji obiektu sr nie istenieje to wyświetlenie komunikatu
            {
                Console.WriteLine("Plik o nazwie " + nazwa + " nie istnieje!");
            }
            Console.ReadKey();
        }
    }
}




