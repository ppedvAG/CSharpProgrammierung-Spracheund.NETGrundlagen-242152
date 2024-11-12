namespace M010;

internal class Program
{
	static void Main(string[] args)
	{
		//Interfaces
		//Eigene Typen (wie Klasse, Enum), welcher nur zur Vererbung dient
		//Funktioniert wie eine abstrakte Klasse (nur Definitionen, keine Implementationen)
		//Kann nicht instanziert werden, wird ausschließlich vererbt

		//Idee: Polymorphismus/Klassen zusammengruppieren, welche keinen Zusammenhang haben

		//Beispiel: bool, double
		//Beide dieser Typen haben das IConvertible und IComparable Interface
		IComparable c = true;
		IComparable d = 2.5;

		Console.OutputEncoding = System.Text.Encoding.UTF8;

		IAufladbar[] auf = new IAufladbar[2];
		auf[0] = new Smartphone();
		auf[1] = new Wertkarte();
		foreach (IAufladbar a in auf)
		{
			a.Aufladen(20);
			a.PrintLadezustand();
		}
	}
}

public interface IAufladbar
{
	int Ladezustand { get; set; }

	int Maximum {  get; set; }

	/// <summary>
	/// Fügt l zum Ladezustand hinzu, darf das Maximum nicht überschreiten und 0 nicht unterschreiten
	/// </summary>
	/// <param name="l"></param>
	public void Aufladen(int l);

	public void PrintLadezustand();

	public double MaxProzent();
}

public class Smartphone : IAufladbar
{
	public int Ladezustand { get; set; }

	public int Maximum { get; set; } = 100;

	public void Aufladen(int l)
	{
		if (Ladezustand + l > Maximum)
            Console.WriteLine("Kann nicht über das Maximum aufladen");

		if (Ladezustand + l < 0)
            Console.WriteLine("Kann nicht unter 0 entladen");

		Ladezustand += l;
    }

	public double MaxProzent()
	{
		return Maximum / Ladezustand;
	}

	public void PrintLadezustand()
	{
        Console.WriteLine($"Das Smartphone ist momentan {Ladezustand}%/{Maximum}% geladen.");
    }
}

public class Wertkarte : IAufladbar
{
	public int Ladezustand { get; set; }

	public int Maximum { get; set; } = 500;

	public void Aufladen(int l)
	{
		if (Ladezustand + l > Maximum)
			Console.WriteLine("Kann nicht über das Maximum aufladen");

		if (Ladezustand + l < 0)
			Console.WriteLine("Kann nicht unter 0 entladen");

		Ladezustand += l;
	}

	public double MaxProzent()
	{
		return Maximum / Ladezustand;
	}

	public void PrintLadezustand()
	{
		Console.WriteLine($"Die Wertkarte ist momentan {Ladezustand}€/{Maximum}€ geladen.");
	}
}