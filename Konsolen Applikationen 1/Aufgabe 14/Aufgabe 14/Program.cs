using System;

namespace Aufgabe_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(); 
                Console.WriteLine("Prüfen, ob es sich bei einem Jahr um ein Schaltjahr handelt.");
                Console.WriteLine("-------------------------------------------------------------");

                Console.Write("Eingabe Jahr (q zum Beenden): ");
                string input = Console.ReadLine();

                if (input == "q")
                {
                    Console.WriteLine("Programm wird beendet...");
                    break;
                }

                if (!int.TryParse(input, out int jahr))
                {
                    Console.WriteLine("Bitte eine gültige Jahreszahl eingeben!");
                    continue;
                }

                if ((jahr % 4 == 0 && jahr % 100 != 0) || jahr % 400 == 0)
                {
                    Console.WriteLine($"Das Jahr {jahr} ist ein Schaltjahr.");
                }
                else
                {
                    Console.WriteLine($"Das Jahr {jahr} ist kein Schaltjahr.");
                }
            }
        }
    }
}
