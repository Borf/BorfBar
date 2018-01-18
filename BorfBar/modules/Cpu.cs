using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace BorfBar.modules
{
    class Cpu : Module
    {
        public static string Name = "CPU";

        public void BuildPanel(ControlCollection controls)
        {
            controls.Add(new CpuPanel());
        }

        public UserControl Preferences()
        {
            return new CpuPreferences();
        }
    }
}
