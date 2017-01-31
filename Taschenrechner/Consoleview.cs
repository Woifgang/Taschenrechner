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

        /* private string operand;

         public string Operand
         {
             get { return operand; }
             private set { operand = value; }
         }*/




        public Consoleview(Rechnermodel model)
        {
            this.model = model;
            model.Operand = "unbekannt";
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
            Console.Write("Geben Sie bitte eine Zahl ein: ");
            double zahl = Convert.ToDouble(Console.ReadLine());
            return zahl;                            
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
