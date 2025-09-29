using System;

namespace Aufgabe_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Breite des Stammes? ");
            int breite = Convert.ToInt32(Console.ReadLine());

            Console.Write("Höhe des Stammes? ");
            int hoehe = Convert.ToInt32(Console.ReadLine());

            Console.Write("Höhe der Krone? ");
            int krone = Convert.ToInt32(Console.ReadLine());

            ZeichneBaum(hoehe, breite, krone);

            Console.ReadKey();
        }

        static void ZeichneBaum(int hoehe, int breite, int krone)
        {
            ZeichneKrone(krone);
            ZeichneStamm(hoehe, breite, krone);
        }

        static void ZeichneStamm(int hoehe, int breite, int krone)
        {
            for (int i = 1; i <= hoehe; i++)
            {
                int anzLeer = (krone - 1) - (breite / 2);
                ZeichneZeile(anzLeer, breite);
            }
        }

        static void ZeichneKrone(int krone)
        {
            int anzSterne = 1;
            int anzLeer = krone - 1;
            for (int i = 1; i <= krone; i++)
            {
                ZeichneZeile(anzLeer, anzSterne);
                anzSterne += 2;
                anzLeer -= 1;
            }
        }

        static void ZeichneZeile(int anzahlLeerzeichen, int anzahlSterne)
        {
            Console.WriteLine();
            for (int i = 1; i <= anzahlLeerzeichen; i++)
                Console.Write(" ");
            for (int i = 1; i <= anzahlSterne; i++)
                Console.Write("*");
        }
    }
}
