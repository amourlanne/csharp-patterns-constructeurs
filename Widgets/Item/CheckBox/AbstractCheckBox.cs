using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Widgets
{
    public abstract class AbstractCheckBox : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}