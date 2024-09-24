namespace M006.Data;

/// <summary>
/// Klasse
/// 
/// Bauplan für Objekte, wird für komplexe Daten verwendet
/// 
/// int: Ganze Zahl
/// double: Kommazahl
/// string: Text
/// Person: ?
/// 
/// Innerhalb einer Klasse werden Felder/Eigenschaften, ... definiert
/// WICHTIG: Keine konkreten Werte
/// 
//////////////////////////////////////////////
///
/// Objekt
/// Wird aus einer Klasse erzeugt
/// Enthält konkrete Werte
/// 
/// Beispiel: Person
/// Felder: Vorname, Nachname, Alter, ...
/// Funktionen: Sprechen, Bewegen, ...
/// 
/// Person-Objekt: ["Max", "Mustermann", 22, ...]
/// </summary>
public class Person
{
    #region Feld
    private string vorname;

    /// <summary>
    /// Get-Methode
    /// Gibt einen Wert zurück
    /// Gibt generell nur den Wert aus dem Feld dahinter zurück
    /// </summary>
    public string GetVorname()
    {
        return vorname;
    }

    /// <summary>
    /// Set-Methode
    /// Setzt einen neuen Wert
    /// Gibt generell void zurück und hat einen Parameter (den neuen Wert)
    /// </summary>
    public void SetVorname(string vorname)
    {
        if (vorname.All(char.IsLetter) && vorname.Length >= 3 && vorname.Length <= 15)
        {
            //this: Variablen innerhalb der Funktion und außerhalb der Funktion unterscheiden
            //"Nach oben greifen"
            this.vorname = vorname;
        }
        else
        {
            Console.WriteLine("Vorname muss zw. 3 und 15 Buchstaben haben");
        }
    }
    #endregion

    #region Property
    private string nachname;

    /// <summary>
    /// Property
    /// Vereinfachung vom klassischen Get-/Setmethoden Aufbau
    /// </summary>
    public string Nachname
    {
        get
        {
            return nachname;
        }
        set
        {
            //value: Parameter des Set-Accessors
            //Wie bei einer Set-Methode der Parameter
            if (value.All(char.IsLetter) && value.Length >= 3 && value.Length <= 15)
            {
                nachname = value;
            }
            else
            {
                Console.WriteLine("Nachname muss zw. 3 und 15 Buchstaben haben");
            }
        }
    }

    //Drei Arten von Properties
    //Full Property: private Feld + public Property (siehe oben)
    //Auto Property: Kein Unterschied zu einer einfachen Variable, wird in manchen Szenarien benötigt (JSON, WPF, Datenklassen)
    //Get-Only Property: Property, welches nicht gesetzt werden darf (kein Setter)

    //Auto-Property
    public int Alter { get; set; }

    public int Alter2 { get; private set; } //Kann von außen gelesen, aber nicht beschrieben werden

    //Get-Only Property
    //Voller Name ergibt sich aus Vor-/Nachname => kann nicht gesetzt werden
    public string VollerName
    {
        get
        {
            return vorname + " " + nachname;
        }
    }

    //Vereinfachung
    public string VollerName2
    {
        get => vorname + " " + nachname;
    }

    //Vereinfachung
    public string VollerName3 => vorname + " " + nachname;
    #endregion

    #region Funktion
    /// <summary>
    /// Funktion innerhalb einer Klasse
    /// 
    /// Jedes Objekt der Klasse wird diese Funktion haben und kann diese verwenden
    /// WICHTIG: Nicht static benutzen
    /// </summary>
    public void Sprechen(string text)
    {
        Console.WriteLine($"{VollerName} sagt: {text}");
    }
    #endregion

    #region Konstruktor
    /// <summary>
    /// Konstruktor
    /// 
    /// Wird bei Erstellung des Objekts ausgeführt
    /// 
    /// Jede Klasse hat einen Standardkonstruktor
    /// </summary>
    public Person()
    {
        Console.WriteLine("Person wurde erstellt");
    }

    /// <summary>
    /// Hier werden Standardwerte für ein neues Objekt verlangt
    /// </summary>
    public Person(string vorname, string nachname) : this()
    {
        this.vorname = vorname;
        this.nachname = nachname;
    }

    /// <summary>
    /// Konstruktoren verketten
    /// 
    /// Wenn dieser Konstruktor ausgeführt wird, wird der Konstruktor in der Kette darüber auch ausgeführt
    /// 
    /// Vorteile: Copy-Paste verringern, Änderungen automatisch übernehmen
    /// </summary>
    public Person(string vorname, string nachname, int alter) : this(vorname, nachname)
    {
        Alter = alter;
    }
    #endregion
}