using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using static System.Windows.Forms.Control;

namespace BorfBar.modules.mqtt
{
	public class MqttNumber: MqttItem
    {
		[Category("MQTT")]
		[Description("The topic to display")]
		[DisplayName("Topic")]
		public string topic { get; set; } = string.Empty;

		[Category("Graph")]
		[Description("Should a graph be added in the bar")]
		[DisplayName("Show Graph")]
		public bool showGraph { get; set; } = true;

		[Category("Graph")]
		[Description("The top value of the graph")]
		[DisplayName("Maximum Value")]
		public float maxValue { get; set; } = 100;

		[Category("Graph")]
		[Description("The bottom value of the graph")]
		[DisplayName("Minimum Value")]
		public float minValue { get; set; } = 0;

		[Category("Graph")]
		[Description("The width of the graph")]
		[DisplayName("Width")]
		public float graphWidth { get; set; } = 50;

		[Category("Value")]
		[Description("Number of digits to round. negative for no rounding")]
		[DisplayName("Rounding")]
		public int roundDigits { get; set; } = 0; //round off with 0 digits

		[Category("Value")]
		[Description("Divider to divide the value with before displaying")]
		[DisplayName("Divider")]
		public int divider { get; set; } = 1; // multiplication factor (for MB to GB)

        public override void BuildPanel(ControlCollection controls, MqttClient client)
        {
            base.BuildPanel(controls, client);
            var label = new Label();
            label.Text = topic;
            label.AutoSize = true;
			label.ForeColor = Color.White;
			controls.Add(label);


			client.Subscribe(new string[] { topic }, new byte[] { 0 });
			client.MqttMsgPublishReceived += (sender, e) =>
			{
				label.BeginInvoke(new MethodInvoker(delegate
				{
					if (e.Topic == topic)
					{
						string message = Encoding.ASCII.GetString(e.Message);

						if (divider > 1)
							message = (float.Parse(message) / divider) + "";
						if (roundDigits > 0)
							message = Math.Round(float.Parse(message), roundDigits) + "";
						label.Text = message;
					}
				}));
			};

		}

	}

}
