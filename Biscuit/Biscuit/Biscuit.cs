using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biscuit
{
    public abstract class Biscuit : ICloneable
    {
        public abstract object Clone();

        public abstract void Manger();
    }
}