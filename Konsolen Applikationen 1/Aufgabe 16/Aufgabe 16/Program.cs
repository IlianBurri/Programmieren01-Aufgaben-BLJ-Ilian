using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int versuche = 0;
            int zahl = new Random().Next(1, 101);




            Console.WriteLine("Deine Zahl (1..100): ");
            int eingabe = Convert.ToInt32(Console.ReadLine());


            if (eingabe < 1 | eingabe > 100)
            {
                Console.WriteLine("Ungültige Eingabe. Bitte eine Zahl zwischen 1 und 100 eingeben.");
            }
            else
            {
                while (eingabe != zahl)
                {
                    versuche++;
                    if (eingabe < zahl)
                    {
                        Console.WriteLine("Die gesuchte Zahl ist größer. Versuch es nochmal: ");
                        eingabe = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (eingabe > zahl)
                    {
                        Console.WriteLine("Die gesuchte Zahl ist kleiner. Versuch es nochmal: ");
                        eingabe = Convert.ToInt32(Console.ReadLine());
                    }
                }
                versuche++;
                Console.WriteLine("Herzlichen Glückwunsch! Du hast die Zahl " + zahl + " in " + versuche + " Versuchen erraten.");
            }






        }
    }
}
