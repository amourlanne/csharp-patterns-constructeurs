using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Voiture
{
    public class EspaceBuilder : VoitureBuilder
    {
        public override void CreerVoiture()
        {
            Voiture = new Voiture
            {
                Ref = "Espace",
                Chassis = "châssis long",
                Carrosserie = "carrosserie 5 portes",
                Moteur = "moteur diesel"
            };
        }
    }
}