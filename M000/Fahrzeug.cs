namespace M000;

public class Fahrzeug
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
}