namespace M000;

public class Flugzeug : Fahrzeug
{
	public int Flughoehe { get; set; }
	
	public Flugzeug(string name, int maxV, double preis, int flughoehe) : base(name, maxV, preis)
	{
		Flughoehe = flughoehe;
	}

	public override string Info()
	{
		string str = base.Info();
		str += $"Es kann bis auf {Flughoehe}m aufsteigen.";
		return str;
	}
}