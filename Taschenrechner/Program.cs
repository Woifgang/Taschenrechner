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
            Benutzereingaben benutzeraktion = new Benutzereingaben();

            string ersteZahl = benutzeraktion.BenutzerEingabe("Geben Sie hier die erste Zahl ein: ");
            string zweiteZahl = benutzeraktion.BenutzerEingabe("Geben Sie hier die zweite Zahl ein: ");
            string operand = benutzeraktion.BenutzerEingabe("Geben sie + , - , * oder / ein: ");

            // Todo: Spätere Auslagerung in eine Methode; Umwandlung String -> Double
            double ersteZahlWandlung = Convert.ToDouble(ersteZahl);
            double zweiteZahlWandlung = Convert.ToDouble(zweiteZahl);

            // Ergebnis berechnen
            Rechnermodell model = new Rechnermodell();
            model.Berechnen(ersteZahlWandlung, zweiteZahlWandlung, operand);

            // Ergebnis ausgeben
            Ausgabe(model.Resultat, operand);

            // Programm beenden
            benutzeraktion.BenutzerEingabe("Zum Beenden Return drücken");
        }


        // Methode: Ausgabe
        static void Ausgabe(double ergebnis, string operand)
        {
            switch (operand)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                    Console.WriteLine("Das Ergebnis lautet: {0}", ergebnis);
                    break;

                default:
                    Console.WriteLine("Falsche Operation eingeben, es ist nur + - * / möglich");
                    break;
            }
        }
    }
}