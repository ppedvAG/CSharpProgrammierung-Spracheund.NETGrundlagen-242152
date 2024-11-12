namespace M009;

internal class Program
{
	static void Main(string[] args)
	{
		//Polymorphismus
		//-> Typkompatibilität
		//Welche Typen sind mit welchen anderen Typen kompatibel?

		//Jeder Typ ist immer mit seinen Oberklassen kompatibel
		Mensch m = new Mensch(0, "");

		Lebewesen l = new Mensch(0, ""); //l ist mit Mensch oder anderen Unterklassen kompatibel

		object o = new Mensch(0, ""); //o ist mit allen Klassen kompatibel

		//Polymorphismus gilt an allen Stellen in der Sprache (Parameter, Rückgabewerte, ...)
		Test(m);
		Test(l);
		Test(new Hund(10));

		///////////////////////////////////////////////////

		//Typ
		//Jedes Objekt hat einen Typen, dieser korrespondiert mit seiner Klasse

		//GetType()
		//Gibt den Typen hinter einer Variable zurück (= den Typen des Objekts hinter der Variable)
		Type t = o.GetType();
        Console.WriteLine(t.Name);

		//typeof(...)
		//Gibt den Typen über einen Klassennamen zurück
		Type t2 = typeof(Mensch);
        Console.WriteLine(t2.Name);

		//Typvergleiche
		//Zur Laufzeit herausfinden, um welchen Typen es sich bei einem Objekt handelt

		//1. Genauer Typvergleich
		if (m.GetType() == typeof(Mensch))
		{
			//true
		}

		if (m.GetType() == typeof(Lebewesen))
		{
			//false (weil m nicht genau ein Lebewesen ist)
		}

		//2. Typvergleich mit Vererbungshierarchie
		if (m is Mensch)
		{
			//true
		}

		if (m is Lebewesen)
		{
			//true (weil m eine Unterklasse von Lebewesen ist)
		}

		///////////////////////////////////////////////////

		//abstract
		//Klasse definieren, welche nur und ausschließlich eine Struktur darstellt
		//Von einer abstrakten Klasse darf kein Objekt mehr erstellt werden
		//Abstrakte Member müssen in den Unterklassen überschrieben werden
		Lebewesen l2 = new Mensch(10, "Max");
		l2.Bewegen(30);

		//Beispiel: Lebewesen[]
		Lebewesen[] zuhause = new Lebewesen[3];
		zuhause[0] = new Mensch(30, "Max");
		zuhause[1] = new Hund(5);
		zuhause[2] = new Mensch(25, "Max");

		foreach (Lebewesen lw in zuhause)
		{
			lw.Bewegen(10); //Durch abstract wissen wir, das jedes Element Bewegen kann

            Console.WriteLine($"Das jetztige Element ist ein: {lw.GetType().Name}");
        }
	}

	static void Test(Lebewesen l) { }

	static Lebewesen GetLebewesen()
	{
		return new Mensch(0, "");
		//return new Lebewesen(0);
		return new Hund(10);
	}
}


public abstract class Lebewesen
{
	public int Alter { get; set; }

	public Lebewesen(int alter)
	{
		Alter = alter;
	}

	/// <summary>
	/// Abstrakte Member haben keinen Body
	/// </summary>
	public abstract void Bewegen(int distanz);
}

public class Mensch : Lebewesen
{
	public string Vorname { get; set; }

	public Mensch(int alter, string vorname) : base(alter)
	{
		Vorname = vorname;
	}

	/// <summary>
	/// Hier muss eine Überschreibung gemacht werden, nachdem Bewegen abstract ist
	/// </summary>
	public override void Bewegen(int distanz)
	{
        Console.WriteLine($"{Vorname} bewegt sich um {distanz}m.");
    }
}

public class Hund : Lebewesen
{
	public Hund(int alter) : base(alter) { }

	public override void Bewegen(int distanz)
	{
        Console.WriteLine($"Der Hund bewegt sich um {distanz}m.");
    }
}