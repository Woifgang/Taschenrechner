using System;

namespace Taschenrechner
{
    class ConsoleView
    {
        private RechnerModel model;

        public ConsoleView(RechnerModel model)
        {
            this.model = model;
            BenutzerWillBeenden = false;
        }

        public bool BenutzerWillBeenden { get; private set; }

        public void HoleEingabenFuerErsteBerechnungVomBenutzer()
        {
            model.ErsteZahl = HoleZahlVomBenutzer();
            model.Operation = HoleOperatorVomBenutzer();
            model.ZweiteZahl = HoleZahlVomBenutzer();
        }

        public void HoleEingabenFuerFortlaufendeBerechnung()
        {
            string eingabe = HoleNaechsteAktionVomBenutzer();
            double zahl;

            if (eingabe == "FERTIG")
            {
                BenutzerWillBeenden = true;
            }
            else
            {
                while (!double.TryParse(eingabe,out zahl))
                {
                    Console.Write("Bitte gib eine Zahl 0-9 ein: ");
                    Console.Write("Bitte gib eine Zahl für die Berechnung ein: ");
                    eingabe = Console.ReadLine();
                }
                model.ErsteZahl = model.Resultat;
                model.ZweiteZahl = zahl;
            }
        }

        private string HoleNaechsteAktionVomBenutzer()
        {
            Console.Write("Bitte gib eine weitere Zahl ein (FERTIG zum Beenden): ");
            return Console.ReadLine();
        }

        private double HoleZahlVomBenutzer()
        {
            string eingabe;
            double zahl;
            
            Console.Write("Bitte gib eine Zahl für die Berechnung ein: ");
            eingabe = Console.ReadLine();
            
            while (!double.TryParse(eingabe, out zahl))
            {
                Console.Write("Bitte gib eine Zahl 0-9 ein: ");
                Console.Write("Bitte gib eine Zahl für die Berechnung ein: ");
                eingabe = Console.ReadLine();
                
            }

            return zahl;
        }

        private string HoleOperatorVomBenutzer()
        {
            Console.Write("Bitte gib die auszuführende Operation ein (+, -, /, *): ");
            return Console.ReadLine();
        }

        public void GibResultatAus()
        {
            switch (model.Operation)
            {
                case "+":
                    Console.WriteLine("Die Summe ist: {0}", model.Resultat);
                    break;

                case "-":
                    Console.WriteLine("Die Differenz ist: {0}", model.Resultat);
                    break;

                case "/":
                    Console.WriteLine("Der Wert des Quotienten ist: {0}", model.Resultat);
                    break;

                case "*":
                    Console.WriteLine("Das Produkt ist: {0}", model.Resultat);
                    break;

                default:
                    Console.WriteLine("Du hast eine ungültige Auswahl der Operation getroffen.");
                    break;
            }
        }
    }
}
