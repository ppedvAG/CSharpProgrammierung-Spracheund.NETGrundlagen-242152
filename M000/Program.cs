int meter;
string eingabe = Console.ReadLine();
meter = int.Parse(eingabe);

int stunde;
eingabe = Console.ReadLine();
stunde = int.Parse(eingabe);

int minute;
eingabe = Console.ReadLine();
minute = int.Parse(eingabe);

int sekunde;
eingabe = Console.ReadLine();
sekunde = int.Parse(eingabe);

double gesamt = stunde * 3600 + minute * 60 + sekunde;

Console.WriteLine($"Meter/Sekunde:\t\t{Math.Round(meter / gesamt, 2)}");
Console.WriteLine($"Kilometer/Stunde:\t{Math.Round((meter / 1000.0) / (gesamt / 3600), 2)}");
Console.WriteLine($"Meilen/Stunde:\t\t{Math.Round(((meter / 1000.0) / (gesamt / 3600)) * 0.616, 2)}");