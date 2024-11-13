using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace M012;

internal class Program
{
	static void Main(string[] args)
	{
		//Generischer Datentyp
		//Wird in der spitzen Klammer < >, und überall innerhalb der Klasse/Methode, wo der Platzhalter verwendet wird, wird der Typ eingesetzt
		//Der Platzhalter wird als T bezeichnet

		List<int> zahlen = new List<int>(); //-> int Liste
		zahlen.Add(12); //Überall wo in der Klasse T verwendet wird, wird int eingesetzt
		zahlen.Add(2);
		zahlen.Add(5);
		zahlen.Add(11);
		zahlen.Add(9);
		zahlen.Add(1);

		//List funktioniert wie ein Array, ist aber ein besseres Array
		Console.WriteLine(zahlen[2]);

        Console.WriteLine(zahlen.Count);

		foreach (int i in zahlen)
		{
            Console.WriteLine(i);
        }

		List<string> texte = new List<string>();
		texte.Add("hello");

		/////////////////////////////////////////////////////////////////

		//Dictionary
		//Liste von Schlüssel-Wert Paaren
		//Beim Dictionary werden zwei generische Typargumente benötigt

		Dictionary<string, int> einwohnerzahlen = new(); //Target-Typed New: Nimmt den Typen von der linken Seite
		einwohnerzahlen.Add("Wien", 2_000_000);
		einwohnerzahlen.Add("Berlin", 3_650_000);
		einwohnerzahlen.Add("Paris", 2_160_000);
		//einwohnerzahlen.Add("Paris", 2_160_000); //Derselbe Schlüssel kann nur einmal hinzugefügt werden

		Console.WriteLine(einwohnerzahlen["Wien"]); //Werte aus dem Dictionary entnehmen

		//Prüfen, ob der Schlüssel enthalten ist
		if (einwohnerzahlen.ContainsKey("Wien"))
		{
			Console.WriteLine(einwohnerzahlen["Wien"]);
		}

		//var: Lässt den Compiler automatisch den Typen einsetzen
		foreach (var kv in einwohnerzahlen)
		{
			Console.WriteLine($"Die Stadt {kv.Key} hat {kv.Value} Einwohner.");
		}

		//Strg + .: Use explicit type
		foreach (KeyValuePair<string, int> kv in einwohnerzahlen)
		{
            Console.WriteLine($"Die Stadt {kv.Key} hat {kv.Value} Einwohner.");
        }

		/////////////////////////////////////////////////////////////////
	
		//ObservableCollection
		//Funktioniert wie die List, enthält aber einen Benachrichtigungsmechanismus
		ObservableCollection<int> ints = new ObservableCollection<int>();
		ints.CollectionChanged += Ints_CollectionChanged;

		ints.Add(1);
		ints.Add(2);
		ints.Add(3);
		ints.Remove(3);
	}

	private static void Ints_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
	{
		switch (e.Action)
		{
			case NotifyCollectionChangedAction.Add:
                Console.WriteLine($"Element hinzugefügt: {e.NewItems[0]}");
                break;
			case NotifyCollectionChangedAction.Remove:
				Console.WriteLine($"Element entfernt: {e.OldItems[0]}");
				break;
		}
	}
}
