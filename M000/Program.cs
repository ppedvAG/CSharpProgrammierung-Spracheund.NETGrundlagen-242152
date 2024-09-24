int jahr = 2000;
bool istSchaltjahr = false;
if (jahr % 4 == 0)
	istSchaltjahr = true;
if (jahr % 100 == 0)
	istSchaltjahr = false;
if (jahr % 400 == 0)
	istSchaltjahr = true;
Console.WriteLine($"{jahr} ist {(istSchaltjahr ? "ein" : "kein")} Schaltjahr");

string eingabe = "12";
int[] gewinnzahlen = [22, 19, 57, 39, 52];
int zahl = int.Parse(eingabe);
if (zahl > 0 && zahl < 100)
    Console.WriteLine(gewinnzahlen.Contains(zahl) ? "Glückwunsch" : "Kein Gewinn");
else
    Console.WriteLine("Zahl außerhalb des gültigen Bereiches");