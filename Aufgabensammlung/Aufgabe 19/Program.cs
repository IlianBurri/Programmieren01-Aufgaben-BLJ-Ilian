using System;

namespace Aufgabe_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean weiterspielen = true;

            while (true)
            {

                Console.WriteLine("Make your calculation (2 numbers only) (or press Q to quit): ");
                string eingabe = Console.ReadLine();
                if (eingabe.ToLower() == "q")
                    weiterspielen = false;
                if (!weiterspielen)
                    break;

                string[] plus = eingabe.Split('+');
                if (plus.Length == 2)
                {
                    if (int.TryParse(plus[0].Trim(), out int zahl1) && int.TryParse(plus[1].Trim(), out int zahl2))
                    {
                        int ergebnis = zahl1 + zahl2;
                        Console.WriteLine($"Result: {ergebnis}");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Error: Invalid numbers.");
                        weiterspielen = true;
                    }
                }

                string[] minus = eingabe.Split('-');
                if (minus.Length == 2)
                {
                    if (int.TryParse(minus[0].Trim(), out int zahl1) && int.TryParse(minus[1].Trim(), out int zahl2))
                    {
                        int ergebnis = zahl1 - zahl2;
                        Console.WriteLine($"Result: {ergebnis}");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Error: Invalid numbers.");
                        weiterspielen = true;
                    }
                }

                string[] mal = eingabe.Split('*');
                if (mal.Length == 2)
                {
                    if (int.TryParse(mal[0].Trim(), out int zahl1) && int.TryParse(mal[1].Trim(), out int zahl2))
                    {
                        int ergebnis = zahl1 * zahl2;
                        Console.WriteLine($"Result: {ergebnis}");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Error: Invalid numbers.");
                        weiterspielen = true;
                    }
                }

                string[] geteilt = eingabe.Split('/');
                if (geteilt.Length == 2)
                {
                    if (int.TryParse(geteilt[0].Trim(), out int zahl1) && int.TryParse(geteilt[1].Trim(), out int zahl2))
                    {
                        if (zahl2 != 0)
                        {
                            int ergebnis = zahl1 / zahl2;
                            Console.WriteLine($"Result: {ergebnis}");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: Invalid numbers.");
                        weiterspielen = true;
                    }
                }
            }

        }
    }
}