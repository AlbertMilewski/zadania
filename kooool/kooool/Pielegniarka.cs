using System;
namespace kooool
{
	public class Pielegniarka :Pracownik
    {
		private int stażpracy;
		public Pielegniarka(int new_staż, string new_nazwa, string new_nazwisko)
            : base(new_nazwa, new_nazwisko)
        {
			this.stażpracy = new_staż;
        }
		public override void Info()
        {
            Console.WriteLine("Pielęgniarka");
            base.Info();
			Console.WriteLine("Staż pracy:" + stażpracy);
        }
    }
}
