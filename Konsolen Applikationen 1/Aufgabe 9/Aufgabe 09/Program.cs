using System;

namespace Aufgabe_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Geben Sie eine Ganzzahlige Dezimalzahl ein   (q to Quit):");
                string input = Console.ReadLine();


                if (input == "q")
                {
                    Console.WriteLine("Programm wird beendet...");
                    Environment.Exit(0);
                    break;
                }
                int eingabe = Convert.ToInt32(input);




                int zahl = eingabe;
                string bin = Convert.ToString(zahl, 2);

                Console.WriteLine("Deine Zahl wird überprüft...");
                Console.WriteLine("Bitte warten...");
                System.Threading.Thread.Sleep(2000);

                Console.WriteLine("Die binäre Darstellung von " + zahl + " ist: " + bin);
                Console.WriteLine();


            }
        }
    }
}
