using System.Drawing;
using uPLibrary.Networking.M2Mqtt;
using static System.Windows.Forms.Control;

namespace BorfBar.modules.mqtt
{
	public class MqttSeperator : MqttItem
	{
		public MqttSeperator()
		{
			showTitle = false;
			title = "seperator";
		}

		public override void BuildPanel(ControlCollection controls, MqttClient client)
		{
			Seperator seperator = new Seperator();
			seperator.Size = new Size(4, 15);
			controls.Add(seperator);
		}
	}

}
