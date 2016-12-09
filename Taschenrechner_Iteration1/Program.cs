using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner_Iteration1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Addieren: Als Benutzer möchte ich 2 Zahlen eingeben um deren Summe zu berechnen zu können
            Console.Write("Geben Sie hier die erste Zahl ein die Sie addieren möchten: ");
            string ersteZahl = Console.ReadLine();
            Console.Write("Geben Sie hier die zweite Zahl ein die Sie addieren möchten: ");
            string zweiteZahl = Console.ReadLine();

            // Umwandlung String -> Int
            int ersteZahlWandlung = Convert.ToInt32(ersteZahl);
            int zweiteZahlWandlung = Convert.ToInt32(zweiteZahl);

            // Berechnung
            int ergebnis = ersteZahlWandlung + zweiteZahlWandlung;

            //Ausgabe
            Console.WriteLine("Das Ergebnis lautet: {0}", ergebnis);
            Console.ReadLine();
            

        }
    }
}
