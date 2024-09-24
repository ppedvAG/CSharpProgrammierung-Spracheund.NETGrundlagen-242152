using M006.Data;

namespace M006;

internal class Program
{
	static void Main(string[] args)
	{
		//Person Objekt erstellen
		Person p = new Person();
		p.SetVorname("Max"); //Konkreten Wert setzen

		//Hier ist direkter Zugriff auf das Feld ohne Funktionen möglich
		p.Nachname = "Mustermann";
        Console.WriteLine(p.Nachname);

		//Person kann jetzt sprechen
		p.Sprechen("Hallo");

		Person p2 = new Person("Max", "Muster");
		p2.Sprechen("Hallo");

		Person p3 = new Person("Max", "Max", 33);
		p3.Sprechen("Hallo");

		////////////////////////////////////////////////////////////
		
		//Namespaces
		//Organisation von Typen in Pakete
		//Mithilfe von namespace <Name> kann eine Datei in ein Paket gelegt werden
		//z.B. namespace M006;
		//Wenn ein Typ aus einem Paket verwendet werden möchte, muss ein using verwendet werden
		
		//Beispiele
		//Dateimanagement: System.IO
		//Netzwerke: System.Net
		//XML: System.XML
		//UI: Drawing/Windows
    }
}