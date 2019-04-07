using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biscuit
{
    class Application
    {
        public static void Main()
        {
            Palmito palmito = new Palmito(3);
            Pepito pepito = new Pepito("olé");

            MachineABiscuit machineABiscuit = new MachineABiscuit();

            machineABiscuit.SetBiscuit(palmito);
            List<Biscuit> paquetPalmito = machineABiscuit.FairePaquetBiscuit();

            foreach (Biscuit biscuit in paquetPalmito) {
                biscuit.Manger();
            }

            machineABiscuit.SetBiscuit(pepito);
            List<Biscuit> paquetPepito = machineABiscuit.FairePaquetBiscuit();

            foreach (Biscuit biscuit in paquetPepito)
            {
                biscuit.Manger();
            }

        }
    }
}
