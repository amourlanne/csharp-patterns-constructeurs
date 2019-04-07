using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Voiture
{
    public class Voiture
    {
        public String Ref { get; set; }
        public String Chassis { get; set; }
        public String Carrosserie { get; set; }
        public String Moteur { get; set; }

        public override string ToString()
        {
            return Ref + ": " + Chassis + ", " + Carrosserie + ", " + Moteur ;
        }
    }
}