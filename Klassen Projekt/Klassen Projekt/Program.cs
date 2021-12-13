using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Linq;

namespace Klassen_Projekt
{
    class Kunde
    {   //Attribute
        private string name;
        private int alter;
        private int anzahlKonten;
        private int kapital;
        private int kundennummer;
        private int pin;

        
        public Kunde(string name, int alter, int anzahlKonten, int kapital, int kundennummer, int pin)
        {
            this.name = name;
            this.alter = alter;
            this.anzahlKonten = anzahlKonten;
            this.kapital = kapital;
            this.kundennummer = kundennummer;
            this.pin = pin;
        }

        public string Name { get => name; set => name = value; }
        public int Alter { get => alter; set => alter = value; }
        public int AnzahlKonten { get => anzahlKonten; set => anzahlKonten = value; }
        public int Kapital { get => kapital; set => kapital = value; }
        public int Kundennummer { get => kundennummer; set => kundennummer = value; }
        public int Pin { get => pin; set => pin = value; }



        //Main Methode
        static void Main(string[] args) {
            Kunde pers = new Kunde("Tim Mustermann", 25, 2, 2500, 12345,1234);
            pers.Abheben(ref pers.kundennummer, 25);
            Console.ReadKey();
        }





        //Methode

        public int Abheben(ref int Kundennummer,int summe) {

            Console.WriteLine("Geben Sie Ihre Pin ein");
            int Pin = Convert.ToInt32(Console.ReadLine());
           

            switch (summe) {
                case 5:
                    summe = 5;
                    Console.WriteLine("Es werden 5€ ausgegeben");
                    break;
                case 10:
                    summe = 10;
                    Console.WriteLine("Es werden 10€ ausgegeben");
                    break;
                case 20:
                    summe = 20;
                    Console.WriteLine("Es werden 20€ ausgegeben");
                    break;
                case 50:
                    summe = 50;
                    Console.WriteLine("Es werden 5€ ausgegeben");
                    break;
                case 100:
                    summe = 100;
                    Console.WriteLine("Es werden 100€ ausgegeben");
                    break;
                case 200:
                    summe = 200;
                    Console.WriteLine("Es werden 200€ ausgegeben");
                    break;
            }
                

            Kapital -= summe;

            if(Kapital < summe)
            {
                String ErrorMessage = "Ihr Konto ist nicht genügend gedeckt, Ihre Karte wird ausgegeben";

                return Convert.ToInt32(ErrorMessage); 
                
            }

            return Kapital;

        }

        public int Überweisung(int Betrag, string IBAN, ref String Name)
        {
            Console.WriteLine("Es werden " + Betrag + " € an den Empfänger " + IBAN + "überwiesen");

            Kapital -= Betrag;

            return Kapital;}

        public int Überweisung(int Betrag,String Empfänger, ref String Name,char Indikator)
        {
            Console.WriteLine("Es werden " + Betrag + " € vom Empfänger " + Name + "empfangen"); 
            Kapital += Betrag;

            return Kapital;
        }

        public int Kontoeröffnung(int Anzahl,ref int Kundennummer)
        {
            AnzahlKonten += Anzahl;

            return AnzahlKonten;

        }
        


        
    }
}