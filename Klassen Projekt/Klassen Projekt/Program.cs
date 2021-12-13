using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Linq;

namespace Klassen_Projekt
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }


    class Kunde
    {   //Attribute
        private string name;
        private int alter;
        private int anzahlKonten;
        private int kapital;
        private int kundennummer;

        public Kunde(string name, int alter, int anzahlKonten, int kapital, int kundennummer)
        {
            this.name = name;
            this.alter = alter;
            this.anzahlKonten = anzahlKonten;
            this.kapital = kapital;
            this.kundennummer = kundennummer;
        }

        public string Name { get => name; set => name = value; }
        public int Alter { get => alter; set => alter = value; }
        public int AnzahlKonten { get => anzahlKonten; set => anzahlKonten = value; }
        public int Kapital { get => kapital; set => kapital = value; }
        public int Kundennummer { get => kundennummer; set => kundennummer = value; }



        //Main Methode
        static void Main(string[] args) {
            Kunde pers = new Kunde("Tim Mustermann", 25, 2, 2500, 12345);
            Console.ReadKey();
        }





        //Methode

        public int Abheben(ref int Kundennummer,int summe) {

            Console.WriteLine("Geben Sie Ihre Pin ein");
            int Pin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wählen Sie die Summe aus");

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
                Console.WriteLine("Ihr Konto ist nicht genügend gedeckt, Ihre Karte wird ausgegeben");
                
            }

            Console.WriteLine("Ihr neues Saldo  beträgt " + Kapital);

        }

    }
}