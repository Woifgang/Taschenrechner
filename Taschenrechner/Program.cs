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
            benutzeraktion.Ergebnis= model.Resultat ;
            benutzeraktion.Operand  = operand ;

            benutzeraktion.Ausgabe();

            // Programm beenden
            benutzeraktion.BenutzerEingabe("Zum Beenden Return drücken");
        }


        
        }
}