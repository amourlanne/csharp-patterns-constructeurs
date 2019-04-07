using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonopolyPropriete
{
    public class EEFactory : ProprieteFactory
    {
        public override Propriete CreerPropriete() => new EE();
    }
}