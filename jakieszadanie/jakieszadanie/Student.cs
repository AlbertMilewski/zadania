using System;
namespace jakieszadanie
{
	public class Student:Osoba
    {
		
		public int NrIndeksu { get; set; }
		public Student(string _imie, string _nazwisko, int _numerIndeksu):base(_imie,_nazwisko)
        {
			
			this.NrIndeksu = _numerIndeksu;
				
        }
		public Student(string _imie, string _nazwisko) : base(_imie, _nazwisko)
		{
		}
		public Student()
		{
			
		}
		public override string ToString()
        {
			return base.ToString()+" "+this.NrIndeksu;
        }
    }
}
