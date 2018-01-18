using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace BorfBar.modules
{
    interface Module
    {
        UserControl Preferences();
        void BuildPanel(ControlCollection controls);


    }
}
