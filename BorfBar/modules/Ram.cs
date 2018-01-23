using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace BorfBar.modules
{
    public class Ram : Module
    {
        public static string Name = "RAM";


        public Boolean showGraph = true;


        public void BuildPanel(ControlCollection controls)
        {
            controls.Add(new RamPanel(this));
        }

        public UserControl Preferences(frmMain main)
        {
            return new RamPreferences(this, main);
        }
    }
}
