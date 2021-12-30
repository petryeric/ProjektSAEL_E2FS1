using System;

public abstract class Mitarbeiter
{
	private String Name;
	private String Position;
	private char Geschlecht;
	private int Mitarbeiternummer;

    public string name { get => Name; set => Name = value; }
    public string position { get => Position; set => Position = value; }
    public char geschlecht { get => Geschlecht; set => Geschlecht = value; }
    public int mitarbeiternummer { get => Mitarbeiternummer; set => Mitarbeiternummer = value; }
}
