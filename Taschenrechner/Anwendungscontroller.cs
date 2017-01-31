using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Anwendungscontroller
    {
        private Rechnermodel model;
        private Consoleview view;

        public Anwendungscontroller(Rechnermodel model, Consoleview view)
        {
            this.model = model;
            this.view = view;
        }

        public void AnzeigeConsole()
        {
            // Benutzereingaben holen
            view.HoleBenutzerEingabe();
            
            // Berechnen der Benutzereingaben
            model.Berechnen();
            
            // Ergebnis Ausgeben
            view.Ausgabe();

            // Programm beenden
            view.BeendeProgramm();
        }

    }
}
