using System;

namespace Aufgabe_18
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] vokale = { "a", "e", "i", "o", "u", "ä", "ö", "ü", "A", "E", "I", "O", "U", "Ä", "Ö", "Ü" };
            int anzahlVokale = 0;
            int total = 0;
            Console.WriteLine("Deine eingabe: ");
            string eingabe = Console.ReadLine();

            foreach (string vokal in vokale)
            {
                if (eingabe.Contains(vokal))
                {
                    anzahlVokale = eingabe.Split(new string[] { vokal }, StringSplitOptions.None).Length - 1;
                }
                else
                {
                    anzahlVokale = 0;
                }

                if (eingabe.Contains(vokal))
                {
                    Console.WriteLine("Dein Text hat total " + total   + "Vokale");

                    Console.WriteLine("Der Vokal " + vokal + " kommt " + anzahlVokale + " mal vor");
                    

                    
                }
            }
        }
    }
}

