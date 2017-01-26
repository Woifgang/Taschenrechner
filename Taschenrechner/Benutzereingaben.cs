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

        public string BenutzerEingabe(string Ausgabetext)
        {
            Console.Write(Ausgabetext);
            string eingabewert = Console.ReadLine();

            return eingabewert;
        }
    }
}
