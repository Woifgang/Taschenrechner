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
            Rechnermodel model = new Rechnermodel();
            Consoleview view = new Consoleview(model);

            string ersteZahl = view.HoleZahl();
            string operand = view.GebeOperandEin();
            string zweiteZahl = view.HoleZahl();


            // Todo: Spätere Auslagerung in eine Methode; Umwandlung String -> Double
            double ersteZahlWandlung = Convert.ToDouble(ersteZahl);
            double zweiteZahlWandlung = Convert.ToDouble(zweiteZahl);

            // Ergebnis berechnen
            
            model.Berechnen(ersteZahlWandlung, zweiteZahlWandlung, operand);

            view.Ausgabe();

            // Programm beenden
            view.BenutzerEingabe("Zum Beenden Return drücken");
        }
                
   }

}