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
    {   //Eigenschaften
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
        static void Main(string[]args){
            Kunde pers = new Kunde("Tim Mustermann",25,2,2500) ;
            Console.ReadKey();
        }
        
       
        
       

        //Methode
         
        public void Bankkartennummer()
        { 
            
            Console.WriteLine("DE" + "48465194651746558");
        }
        

    }
}