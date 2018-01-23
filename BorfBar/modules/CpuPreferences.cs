using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorfBar.modules
{
    public partial class CpuPreferences : UserControl
    {
        public CpuPreferences() { InitializeComponent(); }
        public CpuPreferences(Cpu cpu, frmMain main)
        {
            InitializeComponent();

            showGraph.Checked = cpu.showGraph;
            showGraph.CheckedChanged += (s, e) => { cpu.showGraph = showGraph.Checked; main.buildInterface(); Settings.save(); };
        }
    }
}
