using System;
namespace Kolo
{
	public class Uczelnia
    {
		private int nr_albumu;
		private Student student;

		public Uczelnia(Student nowyStudent, int _nr_albumu)
        {
			nr_albumu = _nr_albumu;
			student = nowyStudent;
        }
		public Uczelnia(string _Imie, string _Nazwisko, int _numer_albumu):this(new Student(_Imie, _Nazwisko), _numer_albumu)
		{
			
		}
		public void Poka()
		{
			Console.WriteLine("Numer albumu: "+nr_albumu);
			student.Info();
		}
    }
}
