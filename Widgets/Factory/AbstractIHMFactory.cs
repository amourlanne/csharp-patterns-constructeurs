using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Widgets
{
    public abstract class AbstractIHMFactory
    {
        public abstract AbstractButton GetButton();
        public abstract AbstractCheckBox GetCheckBox();
        public abstract AbstractTextBox GetTextBox();
    }
}