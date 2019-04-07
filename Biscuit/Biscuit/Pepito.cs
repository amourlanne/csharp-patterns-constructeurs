using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biscuit
{
    public class Pepito : Biscuit
    {
        public String TypeChocolat { get; set; }
        public Pepito(String typeChocolat) => TypeChocolat = typeChocolat;
        public override object Clone()
        {
            return (Pepito)this.MemberwiseClone();
        }

        public override void Manger()
        {
            Console.WriteLine("Aïe Pepito au chocolat " + TypeChocolat + " !");
        }
    }
}