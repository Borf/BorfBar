using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BorfBar.modules.Mqtt;

namespace BorfBar.modules
{
    public partial class MqttPreferences : UserControl
    {
        public MqttPreferences() { InitializeComponent();        }
		Mqtt mqtt;

        public MqttPreferences(Mqtt mqtt, frmMain main)
        {
			this.mqtt = mqtt;
            InitializeComponent();


			foreach (var i in mqtt.items)
			{
				ListViewItem item = new ListViewItem(i.title);
				item.ImageIndex = 0;
				lstItems.Items.Add(item);
			}

        }

		private void lstItems_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			if (lstItems.SelectedIndices.Count == 0)
				return;
			MqttItem item = mqtt.items[lstItems.SelectedIndices[0]];
			propertyGrid1.SelectedObject = item;
			Console.WriteLine(item);

		}
	}
}
