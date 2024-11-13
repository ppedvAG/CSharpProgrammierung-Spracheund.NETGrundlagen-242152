using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
//using System.Text.Json;

namespace M014;

internal class Program
{
	static void Main(string[] args)
	{
		//Dateien und Verzeichnisse
		//Path, Directory, File

		//Relative Pfade
		//C:\Users\lk3\source\repos\CSharp_Grundkurs_2024_09_24\M014\bin\Debug\net8.0\<Datei>
		string folderPath = "Test"; //C:\Users\lk3\source\repos\CSharp_Grundkurs_2024_09_24\M014\bin\Debug\net8.0\Test
		if (!Directory.Exists(folderPath))
		{
			Directory.CreateDirectory(folderPath);
		}

		string filePath = Path.Combine(folderPath, "Test.txt"); //C:\Users\lk3\source\repos\CSharp_Grundkurs_2024_09_24\M014\bin\Debug\net8.0\Test\Test.txt
		//File.Create(filePath); //Zu Testzwecken

		//Stream
		//Verbindung zw. A und B, welche Daten hin- und herbewegen kann
		//Streams sind unidirektional


		StreamWriter sw = new StreamWriter(filePath); //Stream wird zu einem File geöffnet
		sw.WriteLine("Test1");
		sw.WriteLine("Test2");
		sw.WriteLine("Test3");
		//Jeder Stream hat einen Buffer, in diesen Buffer werden die Inhalte geschrieben
		//Wenn die Inhalte nicht in das File geschrieben werden, werden sie einfach verworfen
		sw.Flush();
		sw.Close();


		using (StreamReader sr = new StreamReader(filePath))
		{
			List<string> lines = new();
			while (!sr.EndOfStream)
			{
				lines.Add(sr.ReadLine());
			}
		} //automatisch .Close()

		//Schnelle Methoden
		File.WriteAllText(filePath, "Test10\nTest11\nTest12");

		string file = File.ReadAllText(filePath);

		//////////////////////////////////////////////////////////////////////////////

		//JSON, XML
		//Standardsprachen für Datenaustausch zw. verschiedenen Schnittstellen
		//Wird verwendet, um Objekte zwischen verschiedenen Programmen zu übertragen
		//Auch zw. verschiedenen Programmiersprachen (z.B. C# <-> JavaScript)

		List<Fahrzeug> fahrzeuge = new List<Fahrzeug>
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

		//System.Text.Json
		//string json = JsonSerializer.Serialize(fahrzeuge);
		//File.WriteAllText(filePath, json);

		//string readJson = File.ReadAllText(filePath);
		//ObservableCollection<Fahrzeug> fzg = JsonSerializer.Deserialize<ObservableCollection<Fahrzeug>>(readJson);

		//Newtonsoft.Json
		string json = JsonConvert.SerializeObject(fahrzeuge);
		File.WriteAllText(filePath, json);

		string readJson = File.ReadAllText(filePath);
		ObservableCollection<Fahrzeug> fzg = JsonConvert.DeserializeObject<ObservableCollection<Fahrzeug>>(readJson);

		//XML
		XmlSerializer xml = new XmlSerializer(fahrzeuge.GetType());
		StreamWriter xmlWriter = new StreamWriter(filePath);
		xml.Serialize(xmlWriter, fahrzeuge);
		xmlWriter.Close();

		StreamReader xmlReader = new StreamReader(filePath);
		List<Fahrzeug> readFzg = (List<Fahrzeug>) xml.Deserialize(xmlReader);
		xmlReader.Close();
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