
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonale_Linie_zeichnen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie lang soll die Linie sein?");

            while (true)
            {
                Console.Write("Deine Eingabe: ");
                int lengthOfLine = 0;
                if (int.TryParse(Console.ReadLine(), out lengthOfLine))
                {
                    DrawLine(lengthOfLine);
                    break;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Ganzzahl erwartet.");
                }
            }

            Console.ReadKey();
        }

        static void DrawLine(int length)
        {
            Console.WriteLine();

            for (int i = 0; i < length; i++)
            {
                RepeatCharacter('*', i);
                Console.Write(" ");
                RepeatCharacter('*', length - i - 1);
                Console.WriteLine();
            }
        }

        static void RepeatCharacter(char character, int number)
        {
            for (int i = 0; i < number; i++)
                Console.Write(character);

        }
    }
}
