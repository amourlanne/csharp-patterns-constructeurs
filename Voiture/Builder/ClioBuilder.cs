using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Voiture
{
    public class ClioBuilder : VoitureBuilder
    {
        public override void CreerVoiture()
        {
            Voiture = new Voiture
            {
                Ref = "Clio",
                Chassis = "châssis court",
                Carrosserie = "carrosserie 3 portes",
                Moteur = "moteur essence"
            };
        }
    }
}