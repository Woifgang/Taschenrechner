using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Rechnermodel model = new Rechnermodel();
            Consoleview view = new Consoleview(model);
            Anwendungscontroller controller = new Anwendungscontroller(model, view);
          
            controller.Ausgabe();

            
        }
                
   }

}