using System;

namespace Aufgabe_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zahl 1: ");
            int zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Zahl 2: ");
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Zahl | Quersumme | Zahl / Quersumme");
            Console.WriteLine("----------------------------------------------");

            for (int aktuelleZahl = zahl1; aktuelleZahl <= zahl2; aktuelleZahl++)
            {
                int temp = aktuelleZahl;
                int quersumme = 0;

                while (temp != 0)
                {
                    quersumme += temp % 10;
                    temp /= 10;
                }

                if (quersumme != 0 && aktuelleZahl % quersumme == 0)
                {
                    int divisionErgebnis = aktuelleZahl / quersumme;
                    Console.WriteLine($"{aktuelleZahl,4} | {quersumme,9} | {divisionErgebnis,15}");
                }
            }
        }
    }
}
