#region Schleifen
//while-Schleife
//Führt die Schleife aus, solange die Bedingung true ist
using System.Net;

int a = 0;
int b = 10;
while (a < b)
{
    Console.WriteLine($"while: {a}");
	a++;
}

int c = 0;
int d = 10;
do
{
    Console.WriteLine($"do-while: {c}");
	c++;
}
while (c < d);

//Endlosschleife
while (true)
{
	break;
}

int e = 0;
int f = 10;
while (true)
{
    Console.WriteLine(e);
	e++;

	if (e >= f)
		break;
}

//Snippets
for (int i = 0; i < 10; i++)
{
    
}

for (int i = 9; i >= 0; i--)
{
		
}
#endregion

#region Enum
//Enum
//Liste von Konstanten
//Zusätzlich ein eigener Typ
//WICHTIG: Eigene Enums am Ende der Datei anlegen

//String: Unsicher, Fehleranfällig
string tag = "Di";
if (tag == "DI")
{

}

//Enum: Sicher
Wochentag x = Wochentag.Di;
if (x == Wochentag.Di)
{

}

//Weitere Enum-Funktionen

//Parse: Konvertiert Strings und Zahlen innerhalb von Strings zu dem gegebenen Enumtypen
//WICHTIG: Typ in der spitzen Klammer angeben
Wochentag parsed = Enum.Parse<Wochentag>(tag);
Console.WriteLine(parsed);

//GetValues: Alle Werte aus einem Enum in ein Array entnehmen
Wochentag[] tage = Enum.GetValues<Wochentag>();
foreach (Wochentag w in tage)
{
    Console.WriteLine(w);
}

//IsDefined: Prüft, ob ein gegebener Enumwert, in dem entsprechenden Enum existiert
Wochentag wt = (Wochentag) 10;
if (Enum.IsDefined<Wochentag>(wt)) //Ist in der Variable ein valider Wert enthalten?
	Console.WriteLine(wt);
#endregion

#region Switch
switch(wt)
{
	case >= Wochentag.Mo and <= Wochentag.Fr:
        Console.WriteLine("Wochentag");
		break;
	case Wochentag.Sa or Wochentag.So:
        Console.WriteLine("Wochenende");
		break;
}
#endregion

enum Wochentag
{
	Mo = 1, Di, Mi, Do, Fr, Sa, So
}