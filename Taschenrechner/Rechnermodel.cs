using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Rechnermodel
    {
        public Rechnermodel()
        {
            Resultat = 0;
        }

        public double Resultat { get; private set; }

        public void Berechnen(double ersteZahl, double zweiteZahl, string operand)
        {
            switch (operand)
            {
                case "+":
                    Resultat = Addieren(ersteZahl, zweiteZahl);
                    break;

                case "-":
                    Resultat = Subtrahieren(ersteZahl, zweiteZahl);
                    break;

                case "*":
                    Resultat = Multiplizieren(ersteZahl, zweiteZahl);
                    break;

                case "/":
                    Resultat = Dividieren(ersteZahl, zweiteZahl);
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
