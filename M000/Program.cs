using M000;

Fahrzeug[] fzg = new Fahrzeug[10];
for (int i = 0; i < 10; i++)
{
	fzg[i] = Fahrzeug.GeneriereFahrzeug($"{i}");
	Console.WriteLine(fzg[i].ToString());
}
//fzg[2].Hupen();

int pkw = 0, schiff = 0, flugzeug = 0;
foreach (Fahrzeug f in fzg)
{
	if (f is PKW)
		pkw++;
	if (f is Schiff)
		schiff++;
	if (f is Flugzeug)
		flugzeug++;
}
Console.WriteLine($"PKWs: {pkw}, Schiffe: {schiff}, Flugzeuge: {flugzeug}");

void TesteBelade(object o1, object o2)
{
	if (o1 is IBeladbar && o2 is Fahrzeug)
	{
		IBeladbar b = (IBeladbar) o1;
		b.Belade((Fahrzeug) o2);
	}
	else if (o2 is IBeladbar && o1 is Fahrzeug)
	{
		IBeladbar b = (IBeladbar) o2;
		b.Belade((Fahrzeug) o1);
	}
	else
	{
        Console.WriteLine("Keines der gegebenen Objekte kann das andere aufladen");
    }
}

//while (true)
//{
//	double z1 = ZahlEingabe("Gib eine Zahl ein: ");
//	double z2 = ZahlEingabe("Gib eine weitere Zahl ein: ");
//	Rechenoperation op = RechenoperationEingabe();

//	double ergebnis = Berechne(z1, z2, op);
//    Console.WriteLine($"Ergebnis: {ergebnis}");

//	Console.WriteLine("Enter drücken um zu wiederholen");
//    if (Console.ReadKey().Key != ConsoleKey.Enter)
//		break;
//	Console.Clear();
//}


//double Berechne(double x, double y, Rechenoperation op)
//{
//	switch (op)
//	{
//		case Rechenoperation.Add:
//			return x + y;
//		case Rechenoperation.Sub:
//			return x - y;
//		case Rechenoperation.Mult:
//			return x * y;
//		case Rechenoperation.Div:
//			return x / y;
//		default:
//			return double.NaN;
//	}
//}

//int ZahlEingabe(string text)
//{
//	while (true)
//	{
//		Console.Write(text);
//		string eingabe = Console.ReadLine();
//		int zahl;
//		bool b = int.TryParse(eingabe, out zahl);
//		if (b)
//			return zahl;
//	}
//}

//Rechenoperation RechenoperationEingabe()
//{
//	while (true)
//	{
//		int eingabe = ZahlEingabe("Gib eine Rechenoperation ein:\n1: Addition\n2: Subtraktion\n3: Multiplikation\n4: Division\n");
//		//if (eingabe >= 1 && eingabe <= 4)
//		//{
//		//	return (Rechenoperation) eingabe;
//		//}
//		Rechenoperation op = (Rechenoperation) eingabe;
//		if (Enum.IsDefined(op))
//			return op;
//	}
//}

//enum Rechenoperation
//{
//	Add = 1, Sub, Mult, Div
//}