namespace M000;

public class PKW : Fahrzeug
{
	public string Treibstoff { get; set; }

	public PKW(string name, int maxV, double preis, string treibstoff) : base(name, maxV, preis)
	{
		Treibstoff = treibstoff;
	}

	public override string Info()
	{
		string str = base.Info();
		str += $"Es fährt mit {Treibstoff}.";
		return str;
	}

	public override void Hupen()
	{
		throw new NotImplementedException();
	}
}