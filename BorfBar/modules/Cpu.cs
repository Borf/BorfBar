﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace BorfBar.modules
{
    public class Cpu : Module
    {
        public static string Name = "CPU";


        public Boolean showGraph = true;


        public void BuildPanel(ControlCollection controls)
        {
            controls.Add(new CpuPanel(this));
        }

        public UserControl Preferences(frmMain main)
        {
            return new CpuPreferences(this, main);
        }
    }
}
