using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Türsteher_aufgabe_Gruppe
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Wie alt bist du");
            int Alter = Convert.ToInt32(Console.ReadLine());
            

            {
                if (Alter >= 18)
                {
                    Console.WriteLine("Hast du deinen Ausweis dabei?");
                   
                }
                else
                {
                    Console.WriteLine("Du bist zu Jung aber mit einem Trinkgeld kommst du rein");
                    int Geld = Convert.ToInt32(Console.ReadLine());
                    if (Geld >= 100)
                    {
                        Console.WriteLine("Wilkommen");


                    }

                    else

                    {
                        Console.WriteLine("Vielleicht nächstes Jahren");
                    }
                }

                string inputAusweis = Console.ReadLine();
                bool Ausweis = bool.Parse(inputAusweis);
                if (Ausweis == true)
                {
                    Console.WriteLine("Willkommen");

                }
                else
                {
                    Console.WriteLine("Komm wieder wenn du einen Ausweis hast oder du gibst mir ne kleine Spende");
                    int Geld = Convert.ToInt32(Console.ReadLine());
                    if (Geld >= 100)
                    {
                        Console.WriteLine("Wilkommen");
                       
                        
                    }

                    else

                    {
                        Console.WriteLine("Vielleicht nächstes Jahren");
                    }

                }
            }
            Console.ReadKey();

        }
    }
}

