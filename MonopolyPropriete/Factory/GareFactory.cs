using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonopolyPropriete
{
    public class GareFactory : ProprieteFactory
    {
        public override Propriete CreerPropriete() => new Gare();
    }
}