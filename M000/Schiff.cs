namespace M000;

public class Schiff : Fahrzeug, IBeladbar
{
	public int Tiefgang { get; set; }

	public Fahrzeug GeladenesFahrzeug { get; set; }

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

	public void Belade(Fahrzeug fzg)
	{
		if (GeladenesFahrzeug != null)
		{
			GeladenesFahrzeug = fzg;
		}
		else
		{
			Console.WriteLine($"Schiff ist bereits beladen mit {GeladenesFahrzeug}");
		}
	}

	public Fahrzeug Entlade()
	{
		if (GeladenesFahrzeug == null)
			Console.WriteLine("Es ist kein Fahrzeug geladen");

		Fahrzeug f = GeladenesFahrzeug;
		GeladenesFahrzeug = null;
		return f;
	}
}