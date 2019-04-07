using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Widgets
{
    public class IOSIHMFactory : AbstractIHMFactory
    {
        public override AbstractButton GetButton() => new IOSButton();

        public override AbstractCheckBox GetCheckBox() => new IOSCheckBox();

        public override AbstractTextBox GetTextBox() => new IOSTextBox(); 
    }
}