using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace BorfBar.modules
{
    public partial class MqttPanel : UserControl
    {
        private MqttClient client;

        Dictionary<String, Label> labels = new Dictionary<string, Label>();


        public MqttPanel()
        {
            InitializeComponent();

            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();

            foreach (var topic in new[] { "onkyo/status/title", "onkyo/status/artist", "onkyo/status/album", "onkyo/playtime", "crypto/coin" })
            {
                Label label = new Label();
                label.Text = topic;
                label.AutoSize = true;
                this.flowLayoutPanel1.Controls.Add(label);

                labels[topic] = label;
            }
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            client.Disconnect();
            base.Dispose(disposing);
        }

        private void MqttPanel_Load(object sender, EventArgs e)
        {
            client = new MqttClient("192.168.2.201");
            client.Connect("WindowsClient");
            client.Publish("desktop/status", Encoding.ASCII.GetBytes("online"));
//            client.Subscribe(new string[] { "onkyo/volume", "onkyo/playtime", "onkyo/status/title", "onkyo/status", "onkyo/status/artist", "onkyo/status/album" },
 //                           new byte[] { 0, 0, 0, 0, 0, 0 });

            foreach(var topic in labels.Keys)
                client.Subscribe(new string[] { topic }, new byte[] { 0 });


            client.MqttMsgPublishReceived += OnPublish;

        }

        private void OnPublish(object sender, MqttMsgPublishEventArgs packet)
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                if(labels.ContainsKey(packet.Topic))
                    labels[packet.Topic].Text = Encoding.ASCII.GetString(packet.Message);
                else
                    Console.WriteLine(packet.Topic + "=> " + packet.Message);
            }));
        }
    }
}
