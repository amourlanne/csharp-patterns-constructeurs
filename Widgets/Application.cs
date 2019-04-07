using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Widgets
{
    class Application
    {
        public static void Main()
        {
            XWindowIHMFactory windowFactory = new XWindowIHMFactory();

            Process(windowFactory);

            IOSIHMFactory iosFactory = new IOSIHMFactory();

            Process(iosFactory);

        }

        public static void Process(AbstractIHMFactory factory)
        {
            AbstractButton button = factory.GetButton();
            AbstractTextBox textBox = factory.GetTextBox();
            AbstractCheckBox checkBox = factory.GetCheckBox();

            button.Draw();
            textBox.Draw();
            checkBox.Draw();
        } 
    }
}
