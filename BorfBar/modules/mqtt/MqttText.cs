using System.Drawing;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using static System.Windows.Forms.Control;

namespace BorfBar.modules.mqtt
{
	public class MqttText : MqttItem
    {
        public string topic;

        public override void BuildPanel(ControlCollection controls, MqttClient client)
        {
            base.BuildPanel(controls, client);
            var label = new Label();
            label.Text = topic;
            label.AutoSize = true;
			label.ForeColor = Color.White;
			controls.Add(label);
        }

    }
}
