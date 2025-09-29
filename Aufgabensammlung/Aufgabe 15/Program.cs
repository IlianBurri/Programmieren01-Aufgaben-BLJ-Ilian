using System;
using System.Diagnostics;

namespace Aufgabe_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Breite des Stammes? ");
            int breite = Convert.ToInt32(Console.ReadLine());
            Console.Write("Höhe des Stammes? ");
            int hoehestamm = Convert.ToInt32(Console.ReadLine());
            Console.Write("Höhe der Krone? ");
            int hoehekrone = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dein Baum wird generiert...");
            System.Threading.Thread.Sleep(1000);
            


            for (int i = 0; i < hoehekrone; i++)
            {
                for (int j = 0; j < hoehekrone - i - 1; j++)
                    Console.Write(" ");
                for (int k = 0; k < 2 * i + 1; k++)
                    Console.Write("*");
                Console.WriteLine();
            }


            for (int i = 0; i < hoehestamm; i++)
            {
                for (int j = 0; j < hoehekrone - breite / 2 - 1; j++)
                    Console.Write(" ");
                for (int b = 0; b < breite; b++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

    }
}
