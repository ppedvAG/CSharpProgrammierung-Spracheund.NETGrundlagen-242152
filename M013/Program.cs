using System.Diagnostics;

namespace M013;

internal class Program
{
	static void Main(string[] args)
	{
		//Einfaches Linq
		List<int> list = Enumerable.Range(1, 20).ToList();

		//Aufgabe: Alle geraden Zahlen filtern
		List<int> ergebnis = [];
		foreach (int i in list)
		{
			if (i % 2 == 0)
			{
				ergebnis.Add(i);
			}
		}

		//Kompakter mit Where
		//WICHTIG: Jeder Linq-Ausdruck fängt mit e => an
		List<int> ergebnisLinq = list.Where(e => e % 2 == 0).ToList();

		//Besser:
		//IEnumerable<int> ergebnisLinq = list.Where(e => e % 2 == 0);

		//IEnumerable
		//Basis von allen Listen
		//Nur eine Anleitung zum Erstellen der fertigen Liste
		Enumerable.Range(0, 1_000_000_000); //Erzeugt hier noch keine Daten, mit ToArray/ToList/foreach-Schleife können die Daten erzeugt werden

		//Einfache Linq-Funktionen
		Console.WriteLine(list.Average());
		Console.WriteLine(list.Min());
		Console.WriteLine(list.Max());
		Console.WriteLine(list.Sum());

		Console.WriteLine(list.First()); //Das erste Element der Liste, Exception wenn kein Element gefunden wurde
		Console.WriteLine(list.Last()); //Das letzte Element der Liste, Exception wenn kein Element gefunden wurde

		//Console.WriteLine(list.First(e => e % 50 == 0)); //Finde das erste Element, welches durch 50 teilbar ist (Exception)
		Console.WriteLine(list.FirstOrDefault(e => e % 50 == 0)); //Finde das erste Element, welches durch 50 teilbar ist (0)

		///////////////////////////////////////////////////////////////////////////////////////////////////////

		//Linq mit Objektliste

		List<Fahrzeug> fahrzeuge = new List<Fahrzeug>
		{
			new Fahrzeug(251, FahrzeugMarke.BMW),
			new Fahrzeug(274, FahrzeugMarke.BMW),
			new Fahrzeug(146, FahrzeugMarke.BMW),
			new Fahrzeug(208, FahrzeugMarke.Audi),
			new Fahrzeug(189, FahrzeugMarke.Audi),
			new Fahrzeug(133, FahrzeugMarke.VW),
			new Fahrzeug(253, FahrzeugMarke.VW),
			new Fahrzeug(304, FahrzeugMarke.BMW),
			new Fahrzeug(151, FahrzeugMarke.VW),
			new Fahrzeug(250, FahrzeugMarke.VW),
			new Fahrzeug(217, FahrzeugMarke.Audi),
			new Fahrzeug(125, FahrzeugMarke.Audi)
		};

		//Beispiel 1: Alle VWs finden
		fahrzeuge.Where(e => e.Marke == FahrzeugMarke.VW);

		//foreach-Äquivalent
		//foreach (Fahrzeug e in fahrzeuge)
		//	if (e.Marke == FahrzeugMarke.VW)
		//      Console.WriteLine(e);

		//Beispiel 2: Alle Fahrzeuge, mit mind. 250km/h Höchstgeschwindigkeit
		fahrzeuge.Where(e => e.MaxV >= 250);

		//Beispiel 3: Fahrzeuge nach Marke sortieren
		fahrzeuge.OrderBy(e => e.Marke);

		//Beispiel 4: Fahrzeuge nach Marke sortieren und subsequent nach Geschwindigkeit
		fahrzeuge
			.OrderBy(e => e.Marke)
			.ThenBy(e => e.MaxV);

		//Absteigend sortieren
		fahrzeuge
			.OrderByDescending(e => e.Marke)
			.ThenByDescending(e => e.MaxV);

		//Beispiel 5: Fahren alle VWs über 200km/h?
		fahrzeuge
			.Where(e => e.Marke == FahrzeugMarke.VW)
			.All(e => e.MaxV >= 200); //Prüft, ob alle Fahrzeuge eine Bedingung erfüllen

		//Beispiel 6: Haben wir einen VW der über 300km/h fährt?
		fahrzeuge
			.Where(e => e.Marke == FahrzeugMarke.VW)
			.Any(e => e.MaxV >= 300); //Prüft, ob mind. ein Element die Bedingung erfüllt

		fahrzeuge.Any(); //Enthält die Liste Elemente?

		//Beispiel 7: Wieviele BMWs haben wir?
		fahrzeuge.Count(e => e.Marke == FahrzeugMarke.BMW); //Rückgabewert int (= 4)
		fahrzeuge.Where(e => e.Marke == FahrzeugMarke.BMW).Count(); //Zuerst Filterung, dann Zählung (langsamer)

		//Beispiel 8: Wie schnell fahren unsere Fahrzeuge im Durchschnitt?
		fahrzeuge.Average(e => e.MaxV); //Rückgabewert double (208.41666666)

		//Beispiel 9: Was ist die kleinste/größte Geschwindigkeit?
		fahrzeuge.Min(e => e.MaxV); //int (133)
		fahrzeuge.Max(e => e.MaxV); //int (304)

		fahrzeuge.MinBy(e => e.MaxV); //Fahrzeug mit MaxV 133
		fahrzeuge.MaxBy(e => e.MaxV); //Fahrzeug mit MaxV 304

		//Beispiel 10: Was sind die 3 schnellsten Fahrzeuge?
		fahrzeuge.OrderByDescending(e => e.MaxV).Take(3);

		//Beispiel 11: Webshop
		int page = 0;
		fahrzeuge.Skip(page * 10).Take(10);
		//Page 0: 0-10, Page 1: 11-20, Page 2: 21-30, ...

		///////////////////////////////////////////////////////////////////////////////////////////////////////

		//Erweiterungsmethoden
		//An beliebige Typen eine Methode anhängen
		int zahl = 12;
        Console.WriteLine(zahl.Quersumme());
    }
}

[DebuggerDisplay("Marke: {Marke}, MaxV: {MaxV}")]
public class Fahrzeug
{
	public int MaxV;

	public FahrzeugMarke Marke;

	public Fahrzeug(int v, FahrzeugMarke fm)
	{
		MaxV = v;
		Marke = fm;
	}
}

public enum FahrzeugMarke
{
	Audi, BMW, VW
}

public static class ExtensionMethods
{
	public static int Quersumme(this int x)
	{
		return (int) x.ToString().Sum(char.GetNumericValue);
	}
}