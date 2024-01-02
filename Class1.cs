using System;

public class Bil
{
	public string Merke { get; set; }
	public int Årsmodell { get; set; }
	public int Registreringsnummer { get; set; }
	public int Kilometerstand { get; set; }
	public int Pris {  get; set; }

	public Bil (string merke, int årsmodell, int registreringsnummer, int kilometerstand, int pris) 
	{
		Merke = merke;
		Årsmodell = årsmodell;
		Registreringsnummer = registreringsnummer;
		Kilometerstand = kilometerstand;
		Pris = pris;
		
	}
	public void PrintBil()
	{
		Console.WriteLine($"{Merke}, {Årsmodell}, {Registreringsnummer}, {Kilometerstand}, {Pris}");
	}
}
