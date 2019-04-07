using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Widgets
{
    public class WinFormIHMFactory : AbstractIHMFactory
    {
        public override AbstractButton GetButton() => new WinFormButton();

        public override AbstractCheckBox GetCheckBox() => new WinFormCheckBox();

        public override AbstractTextBox GetTextBox() => new WinFormTextBox();
    }
}