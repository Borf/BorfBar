using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using static System.Windows.Forms.Control;

namespace BorfBar.modules
{
    public class Mqtt : Module
    {
        public static string Name = "mqtt";


		List<MqttItem> items = new List<MqttItem>();


        public void BuildPanel(ControlCollection controls)
        {
            controls.Add(new MqttPanel(this));
        }

        public UserControl Preferences(frmMain main)
        {
            return new MqttPreferences(this, main);
        }


        class MqttItem
        {
            public virtual void BuildPanel(ControlCollection controls, MqttClient client)
            {
                if(showTitle)
                {
                    var label = new Label();
                    label.Text = title;
                    label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    label.AutoSize = true;
                    controls.Add(label);
                }

            }
            String title;
            bool showTitle = true;
        }

		class MqttSeperator : MqttItem
		{
			public override void BuildPanel(ControlCollection controls, MqttClient client)
			{
				Seperator seperator = new Seperator();
				seperator.Size = new Size(4, 15);
				controls.Add(seperator);
			}
		}



        class MqttText : MqttItem
        {
            public string topic;

            public override void BuildPanel(ControlCollection controls, MqttClient client)
            {
                base.BuildPanel(controls, client);
                var label = new Label();
                label.Text = topic;
                label.AutoSize = true;
                controls.Add(label);
            }

        }

        class MqttNumber: MqttItem
        {
            public string topic;
            public bool showGraph = true;
            public float maxValue = 100;
            public float minValue = 0;
            public float graphWidth = 50;
			public int roundDigits = 0;
			public int divider = 1;

            public override void BuildPanel(ControlCollection controls, MqttClient client)
            {
                base.BuildPanel(controls, client);
                var label = new Label();
                label.Text = topic;
                label.AutoSize = true;
                controls.Add(label);
            }

        }


    }
}
