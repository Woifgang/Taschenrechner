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
            string ersteZahl = BenutzerEingabe("Geben Sie hier die erste Zahl ein: ");
            string zweiteZahl = BenutzerEingabe("Geben Sie hier die zweite Zahl ein: ");
            string operand = BenutzerEingabe("Geben sie den Operanden + oder - ein: ");

            // Todo: Spätere Auslagerung in eine Methode; Umwandlung String -> Double
            double ersteZahlWandlung = Convert.ToDouble(ersteZahl);
            double zweiteZahlWandlung = Convert.ToDouble(zweiteZahl);

            double ergebnis = 0;

            // Berechnung
            switch (operand)
            {
                case "+":
                    ergebnis = Addieren(ersteZahlWandlung, zweiteZahlWandlung);
                    Console.WriteLine("Das Ergebnis lautet: {0}", ergebnis);
                    break;

                case "-":
                    ergebnis = Subtrahieren(ersteZahlWandlung, zweiteZahlWandlung);
                    Console.WriteLine("Das Ergebnis lautet: {0}", ergebnis);
                    break;

                case "*":
                    ergebnis = Multiplizieren(ersteZahlWandlung, zweiteZahlWandlung);
                    Console.WriteLine("Das Ergebnis lautet: {0}", ergebnis);
                    break;

                case "/":
                    ergebnis = Dividieren(ersteZahlWandlung, zweiteZahlWandlung);
                    Console.WriteLine("Das Ergebnis lautet: {0}", ergebnis);
                    break;
                    
                default:
                    BenutzerEingabe("Bitte Eingabe prüfen");
                    break;
            }
           
            // Programm beenden
            BenutzerEingabe("Zum Beenden Return drücken");
            
        }

        // Methode: Benutzerdefinierten Text ausgeben und Zahl als String aus Konsole holen
        static string BenutzerEingabe(string Ausgabetext)
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

        // Methode: Subtrahieren
        static double Subtrahieren(double ersteZahl, double zweiteZahl)
        {
            double ergebnis = ersteZahl - zweiteZahl;
            return ergebnis;
        }

        // Methode: Multiplizieren
        static double Multiplizieren(double ersteZahl, double zweiteZahl)
        {
            double ergebnis = ersteZahl * zweiteZahl;
            return ergebnis;
        }

        // Methode: Dividieren
        static double Dividieren(double ersteZahl, double zweiteZahl)
        {
            double ergebnnis = ersteZahl / zweiteZahl;
            return ergebnnis;
        }
    }
}
