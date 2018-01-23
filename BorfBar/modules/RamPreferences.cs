using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BorfBar.modules;

namespace BorfBar.modules
{
    public partial class RamPreferences : UserControl
    {
        public RamPreferences() { InitializeComponent(); }
        public RamPreferences(Ram ram, frmMain main)
        {
            InitializeComponent();

            showGraph.Checked = ram.showGraph;
            showGraph.CheckedChanged += (s, e) => { ram.showGraph = showGraph.Checked; main.buildInterface(); Settings.save(); };
        }
    }
}
