using System;

namespace jakieszadanie
{
    class Program
    {
        static void Main(string[] args)
        {
		         
          
			Osoba osoba = new Osoba("Jan", "Kowalski");
			//Console.WriteLine(osoba.Imie+" "+osoba.Nazwisko);
			Student student = new Student("Jinan", "Kuuau", 461526671);
			Student student1 = new Student("Jadsadasn", "Koiii", 461526671);
			Student student2 = new Student("Jaaassssssssssan", "Kowalii", 461526671);
            
			Osoba osoba1 = new Student("Jan", "Boafsfa",41442);
            

			//Console.WriteLine(student.Imie + " " + student.Nazwisko+" "+student.NrIndeksu);
			string pomoc_studenta = student.ToString();
			//Console.WriteLine(pomoc_studenta);
			string pomoc_osoby = osoba.ToString();
            //Console.WriteLine(pomoc_osoby);
			Osoba[] osoby = new Osoba[5];
			for (int i = 1; i < 5;i++)
			{
				osoby[0] = new Osoba();
				osoby[0] = osoba;
				osoby[1] = student;
				osoby[2] = student1;
				osoby[3] = student2;


			}
			for (int j = 0; j < 3;j++)
			{
				pomoc_studenta = osoby[j].ToString();
				Console.WriteLine(pomoc_studenta);
			}

			Console.ReadLine();

		}
    }
}
