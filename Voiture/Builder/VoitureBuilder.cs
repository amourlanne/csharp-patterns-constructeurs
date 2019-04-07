using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Voiture
{
    public abstract class VoitureBuilder
    {
        public Voiture Voiture;

        public abstract void CreerVoiture();

        public Voiture GetVoiture()
        {
            return Voiture;
        }
    }
}