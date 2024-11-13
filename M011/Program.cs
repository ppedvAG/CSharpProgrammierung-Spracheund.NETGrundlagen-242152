namespace M011;

internal class Program
{
	static void Main(string[] args)
	{
		//Debugging
		//Wichtige Fenster
		//- Locals: Variablen anzeigen
		//- Immediate: Schnelles ausführen von C# Code, ohne das Programm neustarten zu müssen
		//- Watch: Variable "anpinnen" (Rechtsklick auf Variable -> Add Watch)

		Test();

		Console.WriteLine("Hello, World!");

		//try-catch
		//Fehleranfälligen Code ausführen (try), Fehlerbehandlungscode ausführen (catch)
		//Wenn ein Fehler auftritt, können wir als Entwickler komplett frei entscheiden, was passieren soll

		//Beispiel: Fehlermeldung
		//Problem: Wenn per Console.WriteLine eine Fehlermeldung ausgegeben wird, kann diese in WPF/ASP/MAUI nicht gesehen werden
		//Lösung: Exceptions werfen und diese mit try-catch behandeln

		try
		{
			//Maus über Funktion -> Exceptions
			string eingabe = Console.ReadLine(); //3 Exceptions: IOException, OutOfMemoryException, ArgumentOutOfRangeException
			int x = int.Parse(eingabe); //3 Exceptions: ArgumentNullException, FormatException, OverflowException
		}
		catch (FormatException ex)
		{
			//Plattformspezifischer Code für die Fehlerbehandlung
			Console.WriteLine(ex.Message); //C#-interne Fehlermeldung
			Console.WriteLine(ex.StackTrace); //Rückverfolgung, wo der Fehler aufgetreten ist
		}
		catch (OverflowException ex)
		{
			Console.WriteLine(ex.Message);
			Console.WriteLine(ex.StackTrace);
		}
		catch (Exception e) //Alle anderen Fehler
		{
            Console.WriteLine(e.Message);
        }
		finally //Wird immer am Ende von try oder catch ausgeführt
		{
            Console.WriteLine("Parsen fertig");
        }

		//throw: Eigene Fehler verursachen
		//In der Klammer kann eine Fehlermeldung weitergegeben werden
		//Durch try-catch kann diese Fehlermeldung aus der Exception entnommen werden
		throw new Exception("Eine TestException");
	}

	static void Test()
	{

	}
}
