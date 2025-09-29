using System;

namespace Aufgabe_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Berehnung von Sekunden eines Monats in Abhängigkeit seiner Anzahl Tage");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("wie viele Tage hat der Monat, für den Sie die Sekundenzahl berechen wollen");

            int Tage = Convert.ToInt32(Console.ReadLine());
            int minitage = 28;
            int maxtage = 31;
            int sektag = 3600 * 24;
            int sekmonat = sektag * Tage;


            if (Tage < minitage || Tage > maxtage)
            {
                Console.WriteLine("Ungültige Eingabe. Ein Monat mit " + Tage + " Tagen gibt es nicht.");
            }

            else
            {
                Console.WriteLine("Ein Monat mit " + Tage + " Tagen hat " + sekmonat + " Sekunden");
            }
        }
    }
}