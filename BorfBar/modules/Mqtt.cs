using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace BorfBar.modules
{
	public partial class Mqtt : Module
    {
        public static string Name = "mqtt";


		public List<MqttItem> items = new List<MqttItem>();


        public void BuildPanel(ControlCollection controls)
        {
            controls.Add(new MqttPanel(this));
        }

        public UserControl Preferences(frmMain main)
        {
            return new MqttPreferences(this, main);
        }


    }
}
