using System;

namespace Aufgabe_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zahl: ");
            string eingabe = Console.ReadLine();


            int zahl = Convert.ToInt32(eingabe);

            int sum = 0;

            while (zahl != 0)
            {
                sum = sum + (zahl % 10);
                zahl = zahl / 10;
            }

            Console.WriteLine("Die Quersumme von " + eingabe + " ist " + sum);
        }
    }
}
