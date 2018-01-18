using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace BorfBar.modules
{
    public partial class CpuPanel : UserControl
    {
        PerformanceCounter cpuCounter = null;
        public CpuPanel()
        {
            InitializeComponent();
            var bw = new BackgroundWorker();
            bw.DoWork += (s, e) => cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            bw.RunWorkerCompleted += (s, e) => timer1.Start();
            bw.RunWorkerAsync();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CPU.Text = Math.Round(cpuCounter.NextValue()) + "%";
        }
    }
}
