namespace M000;

public interface IBeladbar
{
	public Fahrzeug GeladenesFahrzeug {  get; set; }

	public void Belade(Fahrzeug fzg);

	public Fahrzeug Entlade();
}