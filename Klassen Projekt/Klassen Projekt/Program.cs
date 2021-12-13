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
            Kunde pers = new Kunde();
            pers.Name = "Tim Mustermann";
            pers.Bankkartennummer();
            Console.ReadKey();
        }
    }


    class Kunde
    {
        //Eigenschaften
        public string Name { get; set; }
        
       

        //Methode
        public void Bankkartennummer()
        { 
            Console.WriteLine("DE" + "48465194651746558");
        }
        

    }
}