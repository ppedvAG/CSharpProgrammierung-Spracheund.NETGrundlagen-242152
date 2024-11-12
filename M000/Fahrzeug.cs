namespace M000;

public abstract class Fahrzeug
{
	public string Name { get; set; }

	public int MaxV { get; set; }

	public int AktV { get; set; }

	public double Preis { get; set; }

	public bool MotorAn { get; set; }

	public virtual string Info()
	{
		return $"Das Fahrzeug {Name} kann maximal {MaxV}km/h fahren und kostet {Preis} Euro. {
			(MotorAn ? $"Es fährt gerade {AktV}km/h." : "")}";
	}

	public Fahrzeug(string name, int maxV, double preis)
	{
		Name = name;
		MaxV = maxV;
		Preis = preis;
	}

	public abstract void Hupen();

	public static Fahrzeug GeneriereFahrzeug(string name)
	{
		Random r = new Random();
		int x = r.Next(0, 3);
		switch (x)
		{
			case 0: return new PKW(name, 200, 20000, "Benzin");
			case 1: return new Schiff(name, 50, 200_000_000, 20);
			default: return new Flugzeug(name, 1200, 50_000_000, 10000);
			//default: return null;
		}
	}

	public override string ToString()
	{
		return $"{GetType().Name}, {Name}";
	}
}