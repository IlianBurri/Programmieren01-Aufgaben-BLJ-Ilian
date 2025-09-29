using System;

namespace Aufgabe_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Zahlen Aufsummieren");
            Console.WriteLine("--------------------");
            Console.WriteLine("Geben Sie eine Liste von Zahlen ein (getrennt durch Komma):");
            string eingabe = Console.ReadLine();

            string[] inputArray = eingabe.Split(',');

            int[] zahlen = Array.ConvertAll(inputArray, int.Parse);
            int[] result = new int[zahlen.Length];

            int sum = 0;
            for (int i = 0; i < zahlen.Length; i++)
            {
                sum += zahlen[i];
                result[i] = sum;
            }

            Console.WriteLine("Resultat: ");
            Console.WriteLine(string.Join(" -> ", result));
        }
    }
}
