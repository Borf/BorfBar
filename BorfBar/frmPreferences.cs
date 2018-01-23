using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorfBar
{
    public partial class frmPreferences : Form
    {
        UserControl modulePreferences = null;
        frmMain main;
        public frmPreferences(frmMain main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void frmPreferences_Load(object sender, EventArgs e)
        {
            var modules = Util.getAllModules();

            foreach (var c in Util.getAllModules())
                lstAllModules.Items.Add(c.GetField("Name").GetValue(null));

            foreach( var c in Settings.Modules)
            {
                lstModules.Items.Add(c.GetType().GetField("Name").GetValue(null));
            }
        }

        private void lstAllModules_DoubleClick(object sender, EventArgs ee)
        {
            MouseEventArgs e = ee as MouseEventArgs;
            int index = lstAllModules.IndexFromPoint(e.Location);
            if (index == ListBox.NoMatches)
                return;

            Type newModule = Util.getAllModules()[index];
            lstModules.Items.Add(newModule.GetField("Name").GetValue(null));

            Settings.Modules.Add(Activator.CreateInstance(newModule) as modules.Module);
            main.buildInterface();
            Settings.save();
        }

        private void lstModules_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.lstModules.SelectedItem == null) return;
            this.lstModules.DoDragDrop(this.lstModules.SelectedItem, DragDropEffects.Move);

            this.SuspendLayout();
            if (modulePreferences != null) 
                this.Controls.Remove(modulePreferences);

            if (lstModules.SelectedIndex < 0)
                return;
            modulePreferences = Settings.Modules[this.lstModules.SelectedIndex].Preferences(main);

            modulePreferences.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            modulePreferences.Location = new System.Drawing.Point(282, 28);
            modulePreferences.Name = "panel1";
            modulePreferences.Size = new System.Drawing.Size(959, 572);

            this.Controls.Add(modulePreferences);

            this.ResumeLayout(false);
            this.PerformLayout();




        }

        private void lstModules_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void lstModules_DragDrop(object sender, DragEventArgs e)
        {
            Point point = lstModules.PointToClient(new Point(e.X, e.Y));
            int index = this.lstModules.IndexFromPoint(point);
            if (index < 0) index = this.lstModules.Items.Count - 1;
            int oldIndex = lstModules.SelectedIndex;
            object data = lstModules.SelectedItem;
            this.lstModules.Items.Remove(data);
            this.lstModules.Items.Insert(index, data);

            var old = Settings.Modules[oldIndex];
            Settings.Modules.Remove(old);
            Settings.Modules.Insert(index, old);
            main.buildInterface();
            Settings.save();
        }

        private void lstAllModules_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void lstAllModules_DragDrop(object sender, DragEventArgs e)
        {
            if (lstModules.SelectedIndex < 0)
                return;
            Settings.Modules.RemoveAt(lstModules.SelectedIndex);
            lstModules.Items.RemoveAt(lstModules.SelectedIndex);
            main.buildInterface();
            Settings.save();
        }
    }
}
