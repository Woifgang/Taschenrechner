using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Consoleview
    {
        private Rechnermodel model;

        public bool BenutzerFertig { get; private set; }

        public Consoleview(Rechnermodel model)
        {
            this.model = model;
            model.Operand = "unbekannt";
            BenutzerFertig = false;
        }
        
        public void HoleBenutzerEingabe()
        {
            model.ErsteZahl = HoleZahl();
            model.Operand = GebeOperandEin();
            model.ZweiteZahl = HoleZahl();
        }

        public void Ausgabe()
        {
            //this.Operand = operand;
            switch (model.Operand)
            {
                case "+":
                    Console.WriteLine("Das Ergebnis der ~ plus ~ Rechnung lautet: {0}", model.Resultat);
                    break;
                case "-":
                    Console.WriteLine("Das Ergebnis der ~ minus ~ Rechnung lautet: {0}", model.Resultat );
                    break;
                case "*":
                    Console.WriteLine("Das Ergebnis der ~ mal ~ Rechnung lautet: {0}", model.Resultat);
                    break;
                case "/":
                    Console.WriteLine("Das Ergebnis der ~ geteilt ~ Rechnung lautet: {0}", model.Resultat);
                    break;

                default:
                    Console.WriteLine("Falsche Operation eingeben, es ist nur + - * / möglich");
                    break;
            }
        }
        
        private double HoleZahl()
        {
            Console.Write("Geben Sie bitte eine Zahl ein oder beenden mit FERTIG: ");
            string eingabe = Console.ReadLine();
            if (eingabe == "FERTIG")
            {
                BenutzerFertig = true;
                eingabe = "0.0";
            }

            return Convert.ToDouble(eingabe);
        }

        private string GebeOperandEin()
        {
            Console.Write("Geben Sie + , - , * oder / ein: ");
            string operand = Console.ReadLine();
            return operand;
        }

        public string BeendeProgramm()
        {
            Console.Write("Zum Beenden bitte Return drücken");
            return Console.ReadLine();
        }
        
    }
}
