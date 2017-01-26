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

        }

        // Methode: Benutzerdefinierten Text ausgeben und Zahl als String aus Konsole holen

        public string Benutzertext { get; set; }

        public void Ausgabe()
        {
            Console.Write(Benutzertext);
            
        }

        public string Eingabe()
        {
            string eingabe = Console.ReadLine();

            return eingabe;
        }
    }
}
