namespace M007;

internal class Program
{
	static void Main(string[] args)
	{
		//int[] x = Enumerable.Range(0, 1_000_000_000).ToArray(); //1 Mrd. * 4B = 4GB
		//Hier wird x aufgeräumt

		Person p = new Person();
		p = new Person();

		//GC erzwingen
		GC.Collect();
		GC.WaitForPendingFinalizers();

		///////////////////////////////////////////////

		//class
		//Referenztyp
		//Wenn ein Objekt von einem Referenztypen erstellt wird, wird eine Referenz erzeugt
		//Wenn zwei Objekte von Referenztypen verglichen werden, werden die Speicheradressen verglichen
		Person person = new Person(); //Objekt erzeugen und Zeiger darauf legen
		Person p2 = person; //Zeiger auf das Objekt unter person legen
		person.Alter = 100; //Beide Variablen werden verändert

        Console.WriteLine(person == p2); //Hier werden die HashCodes verglichen
        Console.WriteLine(person.GetHashCode() == p2.GetHashCode());

		//struct
		//Wertetyp
		//Wenn ein Objekt von einem Wertetypen erstellt wird, wird der Wert direkt gespeichert
		//Wenn zwei Objekte von Wertetypen verglichen werden, werden die Inhalte verglichen
		int x = 10;
		int y = x; //Hier wird eine Kopie vom Wert hinter x erzeugt
		x = 20; //Die beiden Werte sind unabhängig (x bleibt gleich)

		//ref
		//Keyword, welches structs referenzierbar macht
		int r = 10;
		ref int z = ref r; //Hier wird eine Referenz auf r gelegt
		r = 20;

		///////////////////////////////////////////

		//Null
		//Standardwert, wenn eine Variable keinen Wert hat
		//Nur bei Klassen allgemeingültig
		Person p3;

		//Structs können nicht null sein
		//int n = null;
		int? n = null; //? am Ende eines Typens: Nullable
		bool? b = null;

		if (n == null)
		{

		}

		///////////////////////////////////////////

		//Datumswerte
		//DateTime, TimeSpan
		//DateTime: Zeitpunkt
		//TimeSpan: Zeitspanne
		DateTime heute = DateTime.Now;

        //Welches Datum haben wir in 7 Tagen?
        Console.WriteLine(heute + TimeSpan.FromDays(7));

		DateTime gestern = new DateTime(2024, 11, 11);
		TimeSpan ts = new TimeSpan(1, 30, 0);
    }
}
