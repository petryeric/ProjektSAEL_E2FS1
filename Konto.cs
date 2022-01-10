using System;

// Erstelle die Klasse Konto
public abstract class Konto
{

    
	private int Saldo;
	private String Kontoinhaber;
	private String IBAN;

    // Objekte der Klasse Konto erstellt
    public Konto(int Saldo, string Kontoinhaber, string IBAN)
    {
        this.Saldo = Saldo;
        this.Kontoinhaber = Kontoinhaber;
        this.IBAN = IBAN;
    }

    // Klasse Konto mit Inhalt füllen
    public int saldo{ get => Saldo; set => Saldo = value; }
    public string kontoinhaber { get => Kontoinhaber; set => Kontoinhaber = value; }
    public string IBAN1 { get => IBAN; set => IBAN = value; }
}

// Erstelle die Klasse Girokonto
public class Girokonto: Konto

{   // Objekte der Klasse Konto erstellt
    public Girokonto(int Saldo, string Kontoinhaber, string IBAN)
    {
        base.saldo = Saldo;
        base.kontoinhaber = Kontoinhaber;
        base.IBAN1 = IBAN;
    }
    static void Main(string[] args)
    {

    }

    //Rückgabe des Saldo Attributs
	public String Kontostand()
    {
        return "Der aktuelle Kontostand beträgt " + saldo;
    
    }

    public int Abheben(int Summe)
    {
        saldo -= Summe;

        return saldo;


    }

    public int Einzahlen(int Summe)
    {
        saldo += Summe;

        return saldo;
    }

    // Erstelle die Methode Überweisung (Betrag wird vom Kontoinhaber abgezogen)
    public int Überweisung(int Betrag, string IBAN, ref String Kontoinhaber)
    {
        Console.WriteLine("Es werden " + Betrag + " € an den Empfänger " + IBAN + "überwiesen");

        saldo -= Betrag;

        return saldo;
    }
    // Erstelle die Methode Überweisung (Betrag wird auf Empfänger sein Konto dazugerechnet)
    public int Überweisung(int Betrag, String Empfänger, ref String Kontoinhaber, char Indikator)
    {
        Console.WriteLine("Es werden " + Betrag + " € vom Empfänger " + Name + "empfangen");
        saldo += Betrag;

        return saldo;
    }



}

// Erstelle die Methode Sparkonto
public class Sparkonto: Konto
{
    // Objekte der Klasse Konto erstellt
    public Sparkonto(int Saldo, string Kontoinhaber, string IBAN)
    {
        base.saldo = Saldo;
        base.kontoinhaber = Kontoinhaber;
        base.IBAN1 = IBAN;
    }
    static void Main(string[] args)
    {

    }

    // Erstelle die Klasse Zinssatz
    private double Zinssatz;

    public double zinssatz { get => Zinssatz; set => Zinssatz = value; }

    public double Sparen(double Zinssatz, int Dauer)
    {
        double i = Zinssatz / 100;
        double q = 1 + i;
        saldo = saldo * Math.Pow(q, Dauer);

        return saldo;
    }


}


