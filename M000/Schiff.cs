namespace M000;

public class Schiff : Fahrzeug
{
	public int Tiefgang { get; set; }

	public Schiff(string name, int maxV, double preis, int tiefgang) : base(name, maxV, preis)
	{
		Tiefgang = tiefgang;
	}

	public override string Info()
	{
		string str = base.Info();
		str += $"Es kann bis auf {Tiefgang}m sinken.";
		return str;
	}

	public override void Hupen()
	{
		throw new NotImplementedException();
	}
}