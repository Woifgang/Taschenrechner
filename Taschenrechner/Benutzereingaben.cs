using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Benutzereingaben
    {
        public Benutzereingaben()
        {
            Ergebnis = 0;
            Operand = " ";
        }

        public string BenutzerEingabe(string Ausgabetext)
        {
            Console.Write(Ausgabetext);
            string eingabewert = Console.ReadLine();

            return eingabewert;
        }

        // Methode: Ausgabe

        public double Ergebnis { get; set; }
        public string Operand { get; set; }

        public void Ausgabe()
        {
            switch (Operand)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                    Console.WriteLine("Das Ergebnis lautet: {0}", Ergebnis);
                    break;

                default:
                    Console.WriteLine("Falsche Operation eingeben, es ist nur + - * / möglich");
                    break;
            }
        }
    }
}
