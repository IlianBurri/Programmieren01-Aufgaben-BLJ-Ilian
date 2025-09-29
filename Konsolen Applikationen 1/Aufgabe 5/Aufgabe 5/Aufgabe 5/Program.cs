using System;

namespace Aufgabe_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie viele Kilometer möchtest du rennen?");
            int eingabe = Convert.ToInt32(Console.ReadLine());
            int Strecke = 42;
            
            double rundenlänge = 0.4;
            double runden = eingabe / rundenlänge;


            if (eingabe > Strecke)
            {
                Console.WriteLine("Das schaffst du nicht");
            }

            else
            {
                Console.WriteLine("Das sind " + runden + " Runden. Bereit für den Lauf?");
                Console.WriteLine("Ja/Nein");
                Console.WriteLine("1 Schreiben für ja, 2 schreiben für nein");
                int janein = Convert.ToInt32(Console.ReadLine());

                if (janein > 1)
                    Environment.Exit(0);

                else
                {
                    int rundenanzahl = 1;
                    Console.WriteLine("Du läufst jetzt Runde " + rundenanzahl);


                    if (rundenanzahl < runden)
                    {
                        while (rundenanzahl < runden)
                        {
                            rundenanzahl++;
                            Console.WriteLine("Du läufst jetzt Runde " + rundenanzahl);
                        }
                        Console.WriteLine("Geschafft! Du hast " + eingabe + " Kilometer geschafft!");





                    }









                }
            }







        }





    }
}

