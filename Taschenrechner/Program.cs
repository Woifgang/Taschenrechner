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
            // Benutzereingabe: Als Benutzer möchte ich 2 Zahlen eingeben um deren Ergebnis zu berechnen          
            string ersteZahl = Benutzereingabe("Geben Sie hier die erste Zahl ein: ");
            string zweiteZahl = Benutzereingabe("Geben Sie hier die zweite Zahl ein: ");

            // Todo: Spätere Auslagerung in eine Methode; Umwandlung String -> Double
            double ersteZahlWandlung = Convert.ToDouble(ersteZahl);
            double zweiteZahlWandlung = Convert.ToDouble(zweiteZahl);

            // Berechnung
            double ergebnis = Addieren(ersteZahlWandlung, zweiteZahlWandlung);

            // Ergebnis ausgeben
            Console.WriteLine("Das Ergebnis lautet: {0}", ergebnis);

            // Programm beenden
            Benutzereingabe("Zum Beenden Return drücken");
            
        }

        // Methode: Benutzerdefinierten Text ausgeben und Zahl als String aus Konsole holen
        static string Benutzereingabe(string Ausgabetext)
        {
            Console.Write(Ausgabetext);
            string eingabewert = Console.ReadLine();

            return eingabewert;
        }

        // Methode: Addieren
        static double Addieren(double ersteZahl, double zweiteZahl)
        {
            double ergebnis = ersteZahl + zweiteZahl;
            return ergebnis;         
        }

        // Methode: Dividieren
        static double Dividieren(double ersteZahl, double zweiteZahl)
        {
            double ergebnis = ersteZahl - zweiteZahl;
            return ergebnis;
        }

    }
}
