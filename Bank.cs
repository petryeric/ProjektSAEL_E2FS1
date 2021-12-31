         using System;

public abstract class Bank
{

	private int anzahlMitarbeiter;
	private int anzahlFilialen;
	private string aktuelleFiliale;
	private int gesamtVermögen;
	private bool isHauptfiliale;


    public Bank(int anzahlMitarbeiter, int anzahlFilialen,string aktuelleFiliale, int gesamtVermögen, bool isHauptFiliale )
    {
		this.AnzahlMitarbeiter = anzahlMitarbeiter;
		this.AnzahlFilialen = anzahlFilialen;
		this.AktuelleFiliale = aktuelleFiliale;
		this.GesamtVermögen = gesamtVermögen;
		this.IsHauptfiliale = isHauptFiliale;
    }

    public int AnzahlMitarbeiter { get => anzahlMitarbeiter; set => anzahlMitarbeiter = value; }
    public int AnzahlFilialen { get => anzahlFilialen; set => anzahlFilialen = value; }
    public string AktuelleFiliale { get => aktuelleFiliale; set => aktuelleFiliale = value; }
    public int GesamtVermögen { get => gesamtVermögen; set => gesamtVermögen = value; }
    public bool IsHauptfiliale { get => isHauptfiliale; set => isHauptfiliale = value; }

    
	

}
