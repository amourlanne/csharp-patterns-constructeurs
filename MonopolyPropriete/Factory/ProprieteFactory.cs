using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonopolyPropriete
{
    public abstract class ProprieteFactory
    {
        public abstract Propriete CreerPropriete();
    }
}