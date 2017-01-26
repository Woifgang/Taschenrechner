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
            string operand = BenutzerEingabe("Geben sie + , - , * oder / ein: ");

            // Todo: Spätere Auslagerung in eine Methode; Umwandlung String -> Double
            double ersteZahlWandlung = Convert.ToDouble(ersteZahl);
            double zweiteZahlWandlung = Convert.ToDouble(zweiteZahl);

            // Ergebnis berechnen
            Rechnermodell model = new Rechnermodell();
            model.Berechnen(ersteZahlWandlung, zweiteZahlWandlung, operand);

            // Ergebnis ausgeben
            Ausgabe(model.Resultat, operand);
           
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