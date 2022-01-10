         using System;

public abstract class Bank
{

	private int anzahlMitarbeiter;
	private int anzahlFilialen;
	private string aktuelleFiliale;
	private int gesamtVermögen;
	private bool isHauptfiliale;

	// Erstelle Methode Bank mit den Objekt Anzahl der Mitarbeiter, Anzahl der Filialen, akuelle Filialen, vermögen und ob es die Hauptfiliale ist oder eine andere
    public Bank(int anzahlMitarbeiter, int anzahlFilialen,string aktuelleFiliale, int gesamtVermögen, bool isHauptFiliale )
    {
		this.AnzahlMitarbeiter = anzahlMitarbeiter;
		this.AnzahlFilialen = anzahlFilialen;
		this.AktuelleFiliale = aktuelleFiliale;
		this.GesamtVermögen = gesamtVermögen;
		this.IsHauptfiliale = isHauptFiliale;
    }
	// Objekte für Methode Bank mit Inhlt füllen
    public int AnzahlMitarbeiter { get => anzahlMitarbeiter; set => anzahlMitarbeiter = value; }
    public int AnzahlFilialen { get => anzahlFilialen; set => anzahlFilialen = value; }
    public string AktuelleFiliale { get => aktuelleFiliale; set => aktuelleFiliale = value; }
    public int GesamtVermögen { get => gesamtVermögen; set => gesamtVermögen = value; }
    public bool IsHauptfiliale { get => isHauptfiliale; set => isHauptfiliale = value; }

    
	

}
