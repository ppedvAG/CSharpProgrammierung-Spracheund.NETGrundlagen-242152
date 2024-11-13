using M011;

namespace M011_Tests;

/// <summary>
/// Dependencies -> Rechtsklick -> Add Project Reference -> Projekt ausw�hlen
/// 
/// Regelm��ig (t�glich, w�chentlich) alle Tests ausf�hren
/// Wenn ein Test fehlschl�gt, pr�fen, was sich am Code ge�ndert hat
/// </summary>
[TestClass]
public class RechnerTests
{
	Rechner r;

	/// <summary>
	/// Wird vor allen Tests ausgef�hrt
	/// </summary>
	[TestInitialize]
	public void Start()
	{
		r = new Rechner();
	}

	/// <summary>
	/// Wird nach allen Tests ausgef�hrt
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