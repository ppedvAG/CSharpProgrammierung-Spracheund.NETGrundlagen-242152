#region Variablen
int x = 10;

//Einzeiliger Kommentar

/*
	Mehrzeiliger
	Kommentar
*/

Console.WriteLine(x);

char c = 'A';
#endregion

#region Strings
//String-Interpolation ($-String): Code in einen String einbauen
string s = "Die Zahl ist: " + x;
Console.WriteLine(s);

string interpolation = $"Die Zahl ist: {x}";
Console.WriteLine(interpolation);

int z1 = 3;
int z2 = 7;
int z3 = 12;
string kombi = "Die Zahl1 ist: " + z1 + ", die Zahl2 ist: " + z2 + ", die Zahl3 ist: " + z3;
Console.WriteLine(kombi);

string inter = $"Die Zahl1 ist: {z1}, die Zahl2 ist: {z2}, die Zahl3 ist: {z3}";
Console.WriteLine(inter);

//Verbatim-String (@-String): String, welcher Escape-Sequenzen ignoriert
string v = "Umbruch\nUmbruch";
Console.WriteLine(v);

string pfad = @"C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.1\System.Linq.dll";
#endregion

#region Eingabe
//string eingabe = Console.ReadLine();
//Console.WriteLine(eingabe);

//ConsoleKeyInfo info = Console.ReadKey();
//Console.WriteLine(info.Key);
//Console.WriteLine(info.KeyChar);
//Console.WriteLine(info.Modifiers);
#endregion

#region Konvertierungen
string str = "123";
//Console.WriteLine(str * 2);

int zahl = int.Parse(str);
Console.WriteLine(zahl * 2);

//Casting
double d = zahl; //Implizit
int i = (int) d; //Explizit, Konvertierung erzwingen
#endregion

#region Arithmetik
int zahl1 = 7;
int zahl2 = 4;

int summe = zahl1 + zahl2; //Bildet eine Summe
Console.WriteLine(summe); //zahl1 wurde nicht verändert

zahl1 += zahl2; //Addiere zahl2 auf zahl1
Console.WriteLine(zahl1); //zahl1 wurde verändert

//Modulo: Rest einer Division
Console.WriteLine(zahl1 % zahl2); //3

Math.Round(4.3); //4
Math.Round(4.7); //5
Math.Round(4.5); //4
Math.Round(5.5); //6
Math.Round(4.23523, 2); //Auf X Kommastellen runden

Console.WriteLine(3 / 2); //1, bei zwei ganzen Zahlen wird auch eine ganze Zahl herauskommen
Console.WriteLine(3 / 2.0); //Eine der beiden Seiten muss eine Kommazahl sein
Console.WriteLine(3 / 2d);
Console.WriteLine(3f / 2);
Console.WriteLine((double) zahl1 / zahl2);
#endregion