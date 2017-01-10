using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            //Addieren: Als Benutzer möchte ich 2 Zahlen eingeben um deren Summe zu berechnen zu können
            
            string ersteZahl = HoleSummanden("Geben Sie hier die erste Zahl ein die Sie addieren möchten: ");
            string zweiteZahl = HoleSummanden("Geben Sie hier die zweite Zahl ein die Sie addieren möchten: ");

            // Umwandlung String -> Int
            double ersteZahlWandlung = Convert.ToDouble(ersteZahl);
            double zweiteZahlWandlung = Convert.ToDouble(zweiteZahl);

            // Berechnung
            double ergebnis = Addieren(ersteZahlWandlung, zweiteZahlWandlung);

            Console.WriteLine("Das Ergebnis lautet: {0}", ergebnis);

            WarteAufBenutzerEingabe();
            
        }


        static string HoleSummanden(string Ausgabetext)
        {
            Console.Write(Ausgabetext);
            string summand = Console.ReadLine();

            return summand;
        }


        static double Addieren(double ersteZahl, double zweiteZahl)
        {
            double summe = ersteZahl + zweiteZahl;
            return summe;         
        }


        static void WarteAufBenutzerEingabe()
        {         
            Console.WriteLine("Zum Beenden Return drücken");
            Console.ReadLine();
        }
    }
}
