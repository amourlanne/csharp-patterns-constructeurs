using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biscuit
{
    class MachineABiscuit
    {
        public Biscuit Biscuit { get; set; }

        public List<Biscuit> FairePaquetBiscuit()
        {
            List<Biscuit> paquet = new List<Biscuit>();
            if (Biscuit != null)
            {
                for(int i = 0; i < 24; i++)
                {
                    paquet.Add((Biscuit)Biscuit.Clone());
                }
            }
            return paquet;
        }

        public void SetBiscuit(Biscuit biscuit) => Biscuit = biscuit;
    }
}
