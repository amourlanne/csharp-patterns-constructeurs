using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Widgets
{
    public class XWindowIHMFactory : AbstractIHMFactory
    {
        public override AbstractButton GetButton() => new XWindowButton();
        public override AbstractCheckBox GetCheckBox() => new XWindowCheckBox();
        public override AbstractTextBox GetTextBox() => new XWindowTextBox();
    }
}