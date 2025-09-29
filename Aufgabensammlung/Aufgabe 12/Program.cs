using System;

namespace Aufgabe_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Zahlen Aufsummieren");
            Console.WriteLine("-------------------");

            Console.WriteLine("Geben sie die zu summierenden Ganzzahlen mit Komma getrennt ein:");
            string eingabe = Console.ReadLine();
            string[] zahlenStrings = eingabe.Split(',');
            Console.WriteLine("\t");
            int summe = SumUp(zahlenStrings);

            Console.WriteLine("Resultat: ");
            Console.WriteLine(string.Join(" -> ", zahlenStrings) + " -> " + summe);

        }
        static int SumUp(string[] zahlenStrings)
        {
            int summe = 0;
            foreach (string zahlString in zahlenStrings)
            {
                if (int.TryParse(zahlString.Trim(), out int zahl))
                {
                    summe += zahl;
                }
                else
                {
                    Console.WriteLine($"Warnung: '{zahlString}' ist keine gültige Ganzzahl und wird ignoriert.");
                }
            }
            return summe;


        }
    }
}


