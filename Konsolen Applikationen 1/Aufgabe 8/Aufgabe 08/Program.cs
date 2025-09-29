using System;

namespace Aufgabe_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] forbiddenWords = { "viagra", "sex", "porno", "fick", "schlampe", "arsch" };

            Console.WriteLine("Dein Kommentar:");
            string kommentar = Console.ReadLine();

            Console.WriteLine("Dein Kommentar wird überprüft...");
            Console.WriteLine("Bitte warten...");
            System.Threading.Thread.Sleep(2000);

            int counter = 0;


            foreach (string word in forbiddenWords)
            {
                if (kommentar.ToLower().Contains(word))
                {
                    counter++;
                }
            }

            if (counter > 1)
            {
                Console.WriteLine($"Dein Kommentar enthält {counter} verbotene Wörter.");
                Console.WriteLine("Er wird nicht veröffentlicht.");
            }

            if (counter == 1)
            {
                Console.WriteLine("Dein Kommentar enthält 1 verbotenes Wort.");
                Console.WriteLine("Er wird nicht veröffentlicht.");
            }

            else
            {
                Console.WriteLine("Vielen Dank für deinen Kommentar");
            }
        }
    }
}
