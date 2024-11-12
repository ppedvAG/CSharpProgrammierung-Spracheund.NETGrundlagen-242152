namespace M008;

internal class Program
{
	static void Main(string[] args)
	{
		//Vererbung
		//Generelle Basisklassen erzeugen, welche ihre Inhalte an Unterklassen weitergeben
		//Beispiel: Stream -> FileStream, MemoryStream, NetworkStream, ...

		Mensch m = new Mensch(20, "Max");
		m.Alter = 20;
		m.Bewegen(10);
		m.Vorname = "Max";
		m.Bewegen2(10); //Hier wird die Basisimplementation ausgeführt (in Lebewesen)
		m.Bewegen2(1000); //Hier wird die eigene Implementation ausgeführt (in Mensch)

		Lebewesen l = new Lebewesen(20);
		//l.Vorname hier nicht möglich

		AccessModifier am = new();
		am.Vorname = "";
	}
}

public class Lebewesen
{
	public int Alter { get; set; }

	public void Bewegen(int distanz)
	{
        Console.WriteLine($"Lebewesen bewegt sich um {distanz}m");
    }

	/// <summary>
	/// Wenn hier ein Konstruktor erstellt wird, muss dieser in den Unterklassen verkettet werden
	/// </summary>
	/// <param name="alter"></param>
	public Lebewesen(int alter)
	{
		Alter = alter;
	}

	/// <summary>
	/// virtual: Überschreibung ermöglichen
	/// Wenn die Methode nicht überschrieben wird, wird die Basisimplementation ausgeführt
	/// </summary>
	public virtual void Bewegen2(int distanz)
	{
		Console.WriteLine($"Lebewesen bewegt sich um {distanz}m");
	}
}

/// <summary>
/// Mit : <Klassenname> eine Vererbung herstellen
/// "Mensch ist ein Lebewesen"
/// 
/// Mensch erbt von Lebewesen alle Felder, Properties und Funktionen
/// </summary>
public class Mensch : Lebewesen
{
	public string Vorname { get; set; }

	/// <summary>
	/// Dieser Konstruktor kann jetzt noch erweitert werden (z.B. Vorname)
	/// 
	/// Einfach bei den Parametern die extra Parameter hinzufügen
	/// </summary>
	public Mensch(int alter, string vorname) : base(alter)
	{
		Vorname = vorname;
	}

	/// <summary>
	/// override eintippen -> Abstand -> Vorschläge
	/// </summary>
	public override void Bewegen2(int distanz)
	{
		base.Bewegen2(distanz); //base: Greife in die Oberklasse
		Console.WriteLine($"{Vorname} bewegt sich um {distanz}m");
	}
}