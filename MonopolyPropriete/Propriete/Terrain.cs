using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonopolyPropriete
{
    public class Terrain : Propriete
    {
        public override void calculLoyer()
        {
            Console.WriteLine("Je calcule le loyer d’un terrain");
        }
    }
}