using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_4
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.Write("Zahl eingeben:  ");
            int eingabe = Convert.ToInt32(Console.ReadLine());

            string[] Monate = {"Januar", "Februar", "März", "April", "Mai", "Juni", "Juli", "August", "September", "Oktober", "November", "Dezember"};
            Console.Write("Monat:  ");
            Console.WriteLine(Monate[eingabe - 1]);







        }
    }
}
