#region Arrays
int[] zahlen = new int[5];
zahlen[2] = 10;
Console.WriteLine(zahlen[2]);

//Direkte Initialisierung
zahlen = new int[5] { 0, 0, 10, 0, 0 };
zahlen = new[] { 0, 0, 10, 0, 0 };
int[] z2 = { 0, 0, 10, 0, 0 };
int[] z3 = [0, 0, 10, 0, 0]; //Ab .NET 8/C# 12

//Ist ein gegebenes Element in der Liste enthalten?
Console.WriteLine(zahlen.Contains(5)); //false
Console.WriteLine(zahlen.Contains(10)); //true

Console.WriteLine(zahlen.Length); //5

//Mehrdimensionales Array
//Mit Komma in der Arrayklammer definiert
int[,] matrix = new int[3, 3];
matrix[0, 0] = 10;
#endregion

#region Bedingungen

int zahl1 = 12;
int zahl2 = 7;

if (zahl1 < zahl2) //Einzeilige Ifs können ohne Klammern definiert werden
    Console.WriteLine("Zahl1 kleiner als Zahl2");
else
    Console.WriteLine("Zahl1 ist nicht kleiner als Zahl2");

//Ternary-Operator (?-Operator): Mehrzeilige if/else Blöcke einzeilig machen
Console.WriteLine(zahl1 < zahl2 ? "Zahl1 kleiner als Zahl2" : "Zahl1 ist nicht kleiner als Zahl2");

//Der Ternary-Operator muss immer ein Ergebnis zurückgeben (nicht void)
//zahl1 < zahl2 ? Console.WriteLine("Zahl1 kleiner als Zahl2") : Console.WriteLine("Zahl1 ist nicht kleiner als Zahl2");

string ausgabe = zahl1 < zahl2 ? "Zahl1 kleiner als Zahl2" : "Zahl1 ist nicht kleiner als Zahl2";
Console.WriteLine(ausgabe);
#endregion