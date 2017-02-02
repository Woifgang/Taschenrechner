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
            while (!view.BenutzerFertig)
            {
                view.HoleBenutzerEingabe();
                model.Berechnen();
                view.Ausgabe();
            }
            
            view.BeendeProgramm();
        }

    }
}
