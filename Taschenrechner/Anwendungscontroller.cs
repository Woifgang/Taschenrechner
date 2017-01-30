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

        public void Ausgabe()
        {

            double ersteZahl = view.HoleZahl();
            string operand = view.GebeOperandEin();
            double zweiteZahl = view.HoleZahl();

            model.Berechnen(ersteZahl, zweiteZahl, operand);
            view.Ausgabe();


            // Programm beenden
            view.BenutzerEingabe("Zum Beenden Return drücken");
        }


    }
}
