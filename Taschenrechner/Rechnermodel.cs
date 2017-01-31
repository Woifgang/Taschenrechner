using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Rechnermodel
    {

        public string Operand { get; set; }
        public double ErsteZahl { get; set; }
        public double ZweiteZahl { get; set; }

        public Rechnermodel()
        {
            Resultat = 0;
        }

        public double Resultat { get; private set; }

        public void Berechnen()
        {
            switch (Operand)
            {
                case "+":
                    Resultat = Addieren(ErsteZahl, ZweiteZahl);
                    break;

                case "-":
                    Resultat = Subtrahieren(ErsteZahl, ZweiteZahl);
                    break;

                case "*":
                    Resultat = Multiplizieren(ErsteZahl, ZweiteZahl);
                    break;

                case "/":
                    Resultat = Dividieren(ErsteZahl, ZweiteZahl);
                    break;

                default:
                    Resultat = 0;
                    break;
            }
            
        }

        // Methode: Addieren
        private double Addieren(double ersteZahl, double zweiteZahl)
        {
            double ergebnis = ersteZahl + zweiteZahl;
            return ergebnis;
        }

        // Methode: Subtrahieren
        private double Subtrahieren(double ersteZahl, double zweiteZahl)
        {
            double ergebnis = ersteZahl - zweiteZahl;
            return ergebnis;
        }

        // Methode: Multiplizieren
        private double Multiplizieren(double ersteZahl, double zweiteZahl)
        {
            double ergebnis = ersteZahl * zweiteZahl;
            return ergebnis;
        }

        // Methode: Dividieren
        private double Dividieren(double ersteZahl, double zweiteZahl)
        {
            double ergebnnis = ersteZahl / zweiteZahl;
            return ergebnnis;
        }

    }
}
