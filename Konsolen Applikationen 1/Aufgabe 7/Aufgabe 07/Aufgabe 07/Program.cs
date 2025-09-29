using System;

namespace Aufgabe_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zahlen zwischen 1 und 30 die durch 5 und/oder 3 ohne Rest teilbar sind: ");
            Console.WriteLine("----------------------------------------------------------------------");
            string Komma = ",";



            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)

                {
                    if (i == 30)
                    {
                        Komma = "";
                    }
                    Console.Write(i + Komma);
                }
            }
        }
    }
}
