using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace BorfBar.modules
{
    class Mqtt : Module
    {
        public static string Name = "mqtt";

        public void BuildPanel(ControlCollection controls)
        {
            controls.Add(new MqttPanel());
        }

        public UserControl Preferences()
        {
            return new MqttPreferences();
        }
    }
}
