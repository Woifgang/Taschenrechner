using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner_Iteration1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Addieren: Als Benutzer möchte ich 2 Zahlen eingeben um deren Summe zu berechnen zu können
            Console.Write("Geben Sie hier die erste Zahl ein die Sie addieren möchten: ");
            string ersteZahl = Console.ReadLine();
            Console.Write("Plus, Minus, Mal oder Geteilt? :");
            string Symbol = Console.ReadLine();
            Console.Write("Geben Sie hier die zweite Zahl ein die Sie addieren möchten: ");
            string zweiteZahl = Console.ReadLine();

            float ersteZahlWand;
            float tmpFloat;

            if (float.TryParse(ersteZahl, out tmpFloat))
            {
                ersteZahlWand = tmpFloat;
            }

            if (float.TryParse(zweiteZahl,out tmpFloat))
            {
                ersteZahlWand = tmpFloat;
            }


            if (tmpFloat != 0)
            {

                // Umwandlung String -> Float
                float ersteZahlWandlung = Convert.ToSingle(ersteZahl);
                float zweiteZahlWandlung = Convert.ToSingle(zweiteZahl);


                float ergebnis = 0;
                // Berechnung
                if (Symbol == "+")
                {
                    ergebnis = ersteZahlWandlung + zweiteZahlWandlung;
                }

                else if (Symbol == "-")
                {
                    ergebnis = ersteZahlWandlung - zweiteZahlWandlung;
                }

                else if (Symbol == "*")
                {
                    ergebnis = ersteZahlWandlung * zweiteZahlWandlung;
                }

                else if (Symbol == "/")
                {
                    ergebnis = ersteZahlWandlung / zweiteZahlWandlung;
                }

                //Ausgabe
                Console.WriteLine("Das Ergebnis lautet: {0}", ergebnis);
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Es wurde keine Gültige Zahl eingegeben, drücken Sie eine Taste um das Programm zu beenden.");
                Console.ReadLine();
            }
        }
    }
}
