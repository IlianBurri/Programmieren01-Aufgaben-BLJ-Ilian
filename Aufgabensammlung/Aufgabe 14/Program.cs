using System;

namespace Aufgabe_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Prüfen, ob es sich bei einem Jahr um ein Schaltjahr handelt.");
                while (true)
                {
                Console.WriteLine("Eingabe Jahr (q to quit): ");
                int eingabe = Convert.ToInt32(Console.ReadLine());

                if (eingabe == 'q')
                {
                    Environment.Exit(0);
                    break;


                }

                if (eingabe % 4 == 0 && eingabe % 100 != 0 || eingabe % 400 == 0)
                {
                    Console.WriteLine(eingabe + " ist ein Schaltjahr.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(eingabe + " ist kein Schaltjahr.");
                    Console.WriteLine();
                }
            }
        }
    }
}
