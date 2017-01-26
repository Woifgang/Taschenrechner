using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Rechnermodell
    {
        public Rechnermodell()
        {
            Resultat = 0;
        }

        public double Resultat { get; private set; }

        public void Berechnen(double ersteZahlWandlung, double zweiteZahlWandlung, string operand)
        {
            switch (operand)
            {
                case "+":
                    Resultat = Addieren(ersteZahlWandlung, zweiteZahlWandlung);
                    break;

                case "-":
                    Resultat = Subtrahieren(ersteZahlWandlung, zweiteZahlWandlung);
                    break;

                case "*":
                    Resultat = Multiplizieren(ersteZahlWandlung, zweiteZahlWandlung);
                    break;

                case "/":
                    Resultat = Dividieren(ersteZahlWandlung, zweiteZahlWandlung);
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
