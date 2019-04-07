using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biscuit
{
    public class Palmito : Biscuit
    {
        public int NombreOreilles { get; set; }

        public Palmito(int nombreOreilles) => NombreOreilles = nombreOreilles;
        public override object Clone()
        {
            return (Palmito)this.MemberwiseClone();
        }
        public override void Manger()
        {
            Console.WriteLine("Palmito, ça se croque par ses " + NombreOreilles + " oreilles !");
        }
    }
}