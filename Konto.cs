using System;

public abstract class Konto
{
	private int Saldo;
	private String Kontoinhaber;
	private String IBAN;



    public int saldo{ get => Saldo; set => Saldo = value; }
    public string kontoinhaber { get => Kontoinhaber; set => Kontoinhaber = value; }
    public string IBAN1 { get => IBAN; set => IBAN = value; }
}

public class Girokonto: Konto
{
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


    public int Überweisung(int Betrag, string IBAN, ref String Kontoinhaber)
    {
        Console.WriteLine("Es werden " + Betrag + " € an den Empfänger " + IBAN + "überwiesen");

        saldo -= Betrag;

        return saldo;
    }

    public int Überweisung(int Betrag, String Empfänger, ref String Kontoinhaber, char Indikator)
    {
        Console.WriteLine("Es werden " + Betrag + " € vom Empfänger " + Name + "empfangen");
        saldo += Betrag;

        return saldo;
    }



}

public class Sparkonto: Konto
{
    static void Main(string[] args)
    {

    }

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


