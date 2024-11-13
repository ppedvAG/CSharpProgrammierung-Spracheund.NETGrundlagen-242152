using M011;

namespace M011_Tests;

/// <summary>
/// Dependencies -> Rechtsklick -> Add Project Reference -> Projekt auswählen
/// 
/// Regelmäßig (täglich, wöchentlich) alle Tests ausführen
/// Wenn ein Test fehlschlägt, prüfen, was sich am Code geändert hat
/// </summary>
[TestClass]
public class RechnerTests
{
	Rechner r;

	/// <summary>
	/// Wird vor allen Tests ausgeführt
	/// </summary>
	[TestInitialize]
	public void Start()
	{
		r = new Rechner();
	}

	/// <summary>
	/// Wird nach allen Tests ausgeführt
	/// </summary>
	[TestCleanup]
	public void Cleanup()
	{
		r = null;
	}

	[TestMethod]
	[TestCategory("Addiere")]
	public void TesteAddiere()
	{
		double ergebnis = r.Addieren(3, 4);
		//Die Assert Klasse
		//Auswerten von einem Test
		Assert.AreEqual(7, ergebnis);
	}

	[TestMethod]
	[TestCategory("Subtrahiere")]
	public void TesteSubtrahiere()
	{
		double ergebnis = r.Subtrahieren(8, 4);
		//Die Assert Klasse
		//Auswerten von einem Test
		Assert.AreEqual(4, ergebnis);
	}
}