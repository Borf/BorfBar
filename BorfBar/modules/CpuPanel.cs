﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace BorfBar.modules
{
    public partial class CpuPanel : UserControl
    {
        PerformanceCounter cpuCounter = null;
        private CustomToolTip tip;
        Graph graph;

        List<float> history = new List<float>();
        public CpuPanel(Cpu cpu)
        {
            InitializeComponent();
            this.tip = new CustomToolTip(this);
            this.tip.SetToolTip(this.CPU, "this is a test");

            if (cpu.showGraph)
            {
                graph = new Graph();
                graph.Size = new Size(50, 16);
                graph.Location = new Point(75, 2);
                graph.getValues = history;
                this.Controls.Add(graph);
            }

            var bw = new BackgroundWorker();
            bw.DoWork += (s, e) => cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            bw.RunWorkerCompleted += (s, e) => timer1.Start();
            bw.RunWorkerAsync();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float value = cpuCounter.NextValue();
            history.Add(value);
            if (history.Count > 100)
                history.RemoveRange(0, history.Count-100);
            CPU.Text = Math.Round(value) + "%";
            this.tip.SetToolTip(this.CPU, "this is a test");
            if(graph != null)
                graph.Invalidate();
            
        }

        private void CPU_MouseHover(object sender, EventArgs e)
        {
        }


        class CustomToolTip : ToolTip
        {
            private CpuPanel panel;

            public CustomToolTip(CpuPanel panel)
            {
                this.panel = panel;
                this.OwnerDraw = true;
                this.Popup += new PopupEventHandler(this.OnPopup);
                this.Draw += new DrawToolTipEventHandler(this.OnDraw);
            }

            private void OnPopup(object sender, PopupEventArgs e) // use this event to set the size of the tool tip
            {
                e.ToolTipSize = new Size(200, 100);
            }

            float mapX(float x)
            {
                return x / 100 * 200;
            }

            float mapY(float y)
            {
                return 100 - y;
            }

            private void OnDraw(object sender, DrawToolTipEventArgs e) // use this event to customise the tool tip
            {
                Graphics g = e.Graphics;

                g.FillRectangle(new SolidBrush(Settings.backgroundColor), e.Bounds);

                g.DrawRectangle(new Pen(Settings.borderColor, 1), new Rectangle(e.Bounds.X, e.Bounds.Y,
                    e.Bounds.Width - 1, e.Bounds.Height - 1));


                for(int i = 0; i < 100; i+=25)
                    g.DrawLine(new Pen(Settings.borderColor, 1), 0,i,200,i);


                for (int i = 1; i < panel.history.Count; i++)
                {
                    g.DrawLine(new Pen(Color.White, 1), mapX(i - 1), mapY(panel.history[i - 1]), mapX(i), mapY(panel.history[i]));
                }

                
            }
        }
    }
}
