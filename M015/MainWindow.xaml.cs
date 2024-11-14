using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics;
using System.Windows;

namespace M015;

public partial class MainWindow : Window, INotifyPropertyChanged
{
	public ObservableCollection<Fahrzeug> Fahrzeuge { get; set; } = new ObservableCollection<Fahrzeug>
	{
		new Fahrzeug(251, FahrzeugMarke.BMW),
		new Fahrzeug(274, FahrzeugMarke.BMW),
		new Fahrzeug(146, FahrzeugMarke.BMW),
		new Fahrzeug(208, FahrzeugMarke.Audi),
		new Fahrzeug(189, FahrzeugMarke.Audi),
		new Fahrzeug(133, FahrzeugMarke.VW),
		new Fahrzeug(253, FahrzeugMarke.VW),
		new Fahrzeug(304, FahrzeugMarke.BMW),
		new Fahrzeug(151, FahrzeugMarke.VW),
		new Fahrzeug(250, FahrzeugMarke.VW),
		new Fahrzeug(217, FahrzeugMarke.Audi),
		new Fahrzeug(125, FahrzeugMarke.Audi)
	};

	public MainWindow()
	{
		InitializeComponent();
		//this.DataContext = this;
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		Fahrzeuge.Add(new Fahrzeug());
	}

	private void Button_Click_1(object sender, RoutedEventArgs e)
	{
		Counter++;

		//Benachrichtigung senden
		//PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(Counter)));
	}

	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	/// <summary>
	/// Event, welches von der GUI automatisch angemeldet wird, und für die Benachrichtigungen verantwortlich ist
	/// </summary>
	public event PropertyChangedEventHandler? PropertyChanged;

	public void Notify(string propName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));

	private int counter = 5;

	public int Counter
	{
		get => counter;
		set
		{
			counter = value;
			Notify(nameof(Counter)); //Bei jeder Neuzuweisung der Variable eine Benachrichtigung schicken
		}
	}
}

[DebuggerDisplay("Marke: {Marke}, MaxV: {MaxV}")]
public class Fahrzeug
{
	public int MaxV { get; set; }

	public FahrzeugMarke Marke { get; set; }

	public Fahrzeug(int v, FahrzeugMarke fm)
	{
		MaxV = v;
		Marke = fm;
	}

	public Fahrzeug()
	{

	}
}

public enum FahrzeugMarke
{
	Audi, BMW, VW
}