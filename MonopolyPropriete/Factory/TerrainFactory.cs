using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonopolyPropriete
{
    public class TerrainFactory : ProprieteFactory
    {
        public override Propriete CreerPropriete() => new Terrain();
    }
}