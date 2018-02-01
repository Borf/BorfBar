using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using static System.Windows.Forms.Control;

namespace BorfBar.modules
{
	public class MqttItem
    {
        public virtual void BuildPanel(ControlCollection controls, MqttClient client)
        {
            if(showTitle)
            {
                var label = new Label();
                label.Text = title;
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label.AutoSize = true;
				label.ForeColor = Color.White;
				controls.Add(label);
            }

        }


		public virtual void buildPreferences()
		{

		}

		[Category("MQTT")]
		[Description("The title to display")]
		[DisplayName("Title")]
		public String title { get; set; }

		[Category("MQTT")]
		[Description("Show the title")]
		[DisplayName("Show Title")]
		public bool showTitle { get; set; } = true;
    }

}
