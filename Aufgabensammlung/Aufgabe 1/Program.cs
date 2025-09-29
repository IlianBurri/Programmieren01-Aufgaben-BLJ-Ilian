using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsolen_Applikationen_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dieses Programm berechnet die Summe von zwei Zahlen.");
            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("Deine erste Zahl");
            string eingabe1 = Console.ReadLine();
            int erstezahl = Convert.ToInt32(eingabe1);

            Console.WriteLine("Deine zweite Zahl");
            string eingabe2 = Console.ReadLine();
            int zweitezahl = Convert.ToInt32(eingabe2);

            int ergebnis = erstezahl + zweitezahl;

           Console.WriteLine("Ihre Summe ist" + ergebnis);

            Console.WriteLine("Drücken sie eine beliebige Taste um zu beeden");
            Console.ReadKey();
        }
    }
}
