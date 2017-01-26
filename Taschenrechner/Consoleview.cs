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

        public Consoleview(Rechnermodel model)
        {
            this.model = model;
        }

        public string BenutzerEingabe(string Ausgabetext)
        {
            Console.Write(Ausgabetext);
            string eingabewert = Console.ReadLine();

            return eingabewert;
        }

        public void Ausgabe()
        {
            switch (operand )
            {
                case "+":
                case "-":
                case "*":
                case "/":
                    Console.WriteLine("Das Ergebnis lautet: {0}", model.Resultat);
                    break;

                default:
                    Console.WriteLine("Falsche Operation eingeben, es ist nur + - * / möglich");
                    break;
            }
        }

        public string HoleZahl()
        {
            Console.Write("Geben Sie bitte eine Zahl ein: ");
            return Console.ReadLine();             
        }

        private string operand;

        public string GebeOperandEin()
        {
            Console.Write("Geben Sie + , - , * oder / ein: ");
            operand = Console.ReadLine();
            return operand;
        }

        public string BeendeProgramm()
        {
            Console.Write("Zum Beenden bitte Return drücken");
            return Console.ReadLine();
        }
    }
}
