using System;

namespace Aufgabe_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte gib ein Geburtsdatum ein: ");
            string eingabe = Console.ReadLine();

           
            DateTime geburtsdatum;
            if (DateTime.TryParse(eingabe, out geburtsdatum))
            {
                DateTime heute = DateTime.Now;

               
                int alterJahre = heute.Year - geburtsdatum.Year;
                if (heute < geburtsdatum.AddYears(alterJahre))
                {
                    alterJahre--; 
                }

                
                int alterMonate = alterJahre * 12;
                int alterWochen = alterJahre * 52;  
                int alterTage = (heute - geburtsdatum).Days;

                Console.WriteLine("Alter in Jahren: " + alterJahre);
                Console.WriteLine("Alter in Monaten: " + alterMonate);
                Console.WriteLine("Alter in Wochen (ca.): " + alterWochen);
                Console.WriteLine("Alter in Tagen: " + alterTage);
            }
            else
            {
                Console.WriteLine("Ungültiges Datum! Bitte im Format TT.MM.JJJJ eingeben.");
            }
        }
    }
}
