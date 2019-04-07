using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Voiture
{
    public class Ouvrier
    {
        public Voiture Voiture;

        public VoitureBuilder VoitureBuilder;

        public void SetVoitureBuilder(VoitureBuilder voitureBuilder) => VoitureBuilder = voitureBuilder;

        public void AssemblerVoiture()
        {
            if(VoitureBuilder != null)
            {
                VoitureBuilder.CreerVoiture();
                Voiture = VoitureBuilder.GetVoiture();
            }
        }

        public Voiture GetVoiture() => Voiture;
    }
}