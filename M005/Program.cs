//Aufbau
//<Modifier> <Rückgabewert> <Name>(<Param1>, <Param2>, ...)
//{ <Body> }

//Modifier
//Verschiedene Eigenschaften welche unterschiedlichste Effekte haben
//z.B. public/private/internal/..., static, async, ref, readonly, extern, ...

//Rückgabewert
//Funktionen können ein Ergebnis haben
//Dieses Ergebnis kann per return zurückgegeben werden, und im Anschluss in eine Variable geschrieben werden
//Eine Funktion kann einen beliebigen Typen als Rückgabetyp haben, oder void

//Parameter
//Eine Funktion kann Daten empfangen
//Diese Daten können innerhalb der Funktion verwendet + verarbeitet werden
//Aufbau: <Typ> <Name> (wie Variable)

///////////////////////////////////////////////////////////////

internal class Program
{
	private static void Main(string[] args)
	{
		int summe = Addiere(3, 8); //Returnwert in einer Variable auffangen

		PrintAddiere(4, 5); //Hier kann kein Wert empfangen werden

		//Überladung: Funktionen mit gleichem Namen definieren, welche allerdings unterschiedliche Parameter müssen
		Console.WriteLine(); //18 Overloads

		//Funktion auswählen über Parametertypen
		Addiere(4, 5); //int Addiere
		Addiere(4.0, 5); //double Addiere

		//params
		Summiere(1, 2, 3);
		Summiere(1, 2, 3, 4, 5);
		Summiere(1);
		Summiere();

		int[] zahlen = [1, 2, 3];
		Summiere(zahlen);

		//Optionaler Parameter
		AddiereOderSubtrahiere(3, 9);
		AddiereOderSubtrahiere(3, 9);
		AddiereOderSubtrahiere(3, 9);
		AddiereOderSubtrahiere(3, 9);
		AddiereOderSubtrahiere(3, 9, false);
		AddiereOderSubtrahiere(3, 9);
		AddiereOderSubtrahiere(3, 9);
		AddiereOderSubtrahiere(3, 9);

		//Funktion konfigurieren
		Person(vorname: "Max", adresse: "Zuhause"); //Nur die Parameter mitgeben, welche auch benötigt werden (anderen überspringen)

		//out
		int sub;
		int sum = AddiereUndSubtrahiere(3, 5, out sub); //Über out <Name> eine Verbindung herstellen

		//Praktisches Beispiel
		string eingabe = "123";
		int parsed;
		bool hatFunktioniert = int.TryParse(eingabe, out parsed);
		if (hatFunktioniert)
            Console.WriteLine(parsed);
		else
            Console.WriteLine("Parsen hat nicht funktioniert");
    }

	//Funktion mit Rückgabewert
	static int Addiere(int x, int y)
	{
		return x + y; //Per return die Funktion beenden und einen Wert herausgeben
	}

	//Funktion ohne Rückgabewert
	static void PrintAddiere(int x, int y)
	{
		Console.WriteLine($"{x} + {y} = {x + y}");
	}

	//Funktionen überladen
	static double Addiere(double x, double y)
	{
		return x + y;
	}

	/// <summary>
	/// Nimmt beliebig viele Zahlen, und addiert diese
	/// </summary>
	/// <param name="zahlen">Die Werte</param>
	/// <returns>Die Summe der Parameter</returns>
	static int Summiere(params int[] zahlen)
	{
		return zahlen.Sum();
	}

	static int AddiereOderSubtrahiere(int x, int y, bool add = true)
	{
		if (add)
			return x + y;
		else
			return x - y;
	}

	//Funktion konfigurieren
	static void Person(string vorname = "", string nachname = "", int alter = 0, string adresse = "")
	{

	}

	//out Parameter
	//Mehrere Rückgabewerte definieren
	static int AddiereUndSubtrahiere(int x, int y, out int sub)
	{
		sub = x - y;
		return x + y;
	}
}