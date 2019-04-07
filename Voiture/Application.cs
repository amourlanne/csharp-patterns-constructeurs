using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voiture
{
    class Application
    {

        public static void Main()
        {
            Ouvrier ouvrier = new Ouvrier();

            EspaceBuilder espaceBuilder = new EspaceBuilder();

            ouvrier.SetVoitureBuilder(espaceBuilder);
            ouvrier.AssemblerVoiture();

            Voiture espace = ouvrier.GetVoiture();

            Console.WriteLine(espace);

            ClioBuilder clioBuilder = new ClioBuilder();

            ouvrier.SetVoitureBuilder(clioBuilder);
            ouvrier.AssemblerVoiture();

            Voiture clio = ouvrier.GetVoiture();

            Console.WriteLine(clio);
        }
    }
}
