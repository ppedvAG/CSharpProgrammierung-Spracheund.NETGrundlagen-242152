﻿while (true)
{
	double z1 = ZahlEingabe("Gib eine Zahl ein: ");
	double z2 = ZahlEingabe("Gib eine weitere Zahl ein: ");
	Rechenoperation op = RechenoperationEingabe();

	double ergebnis = Berechne(z1, z2, op);
    Console.WriteLine($"Ergebnis: {ergebnis}");

	Console.WriteLine("Enter drücken um zu wiederholen");
    if (Console.ReadKey().Key != ConsoleKey.Enter)
		break;
	Console.Clear();
}


double Berechne(double x, double y, Rechenoperation op)
{
	switch (op)
	{
		case Rechenoperation.Add:
			return x + y;
		case Rechenoperation.Sub:
			return x - y;
		case Rechenoperation.Mult:
			return x * y;
		case Rechenoperation.Div:
			return x / y;
		default:
			return double.NaN;
	}
}

int ZahlEingabe(string text)
{
	while (true)
	{
		Console.Write(text);
		string eingabe = Console.ReadLine();
		int zahl;
		bool b = int.TryParse(eingabe, out zahl);
		if (b)
			return zahl;
	}
}

Rechenoperation RechenoperationEingabe()
{
	while (true)
	{
		int eingabe = ZahlEingabe("Gib eine Rechenoperation ein:\n1: Addition\n2: Subtraktion\n3: Multiplikation\n4: Division\n");
		//if (eingabe >= 1 && eingabe <= 4)
		//{
		//	return (Rechenoperation) eingabe;
		//}
		Rechenoperation op = (Rechenoperation) eingabe;
		if (Enum.IsDefined(op))
			return op;
	}
}

enum Rechenoperation
{
	Add = 1, Sub, Mult, Div
}