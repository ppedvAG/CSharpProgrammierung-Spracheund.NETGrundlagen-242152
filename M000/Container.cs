namespace M000;

public class Container : IBeladbar
{
	public Fahrzeug GeladenesFahrzeug { get; set; }

	public void Belade(Fahrzeug fzg)
	{
		if (GeladenesFahrzeug != null)
		{
			GeladenesFahrzeug = fzg;
		}
		else
		{
            Console.WriteLine($"Container ist bereits beladen mit {GeladenesFahrzeug}");
        }
	}

	public Fahrzeug Entlade()
	{
		if (GeladenesFahrzeug == null)
            Console.WriteLine("Es ist kein Fahrzeug geladen");

        Fahrzeug f = GeladenesFahrzeug;
		GeladenesFahrzeug = null;
		return f;
	}
}