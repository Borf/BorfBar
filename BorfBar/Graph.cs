using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorfBar
{
    public partial class Graph : Control
    {
        public Graph()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }


        public IEnumerable<float> getValues;
        public int count = 100;
        public float max = 100;

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            Graphics g = pe.Graphics;
            g.FillRectangle(new SolidBrush(Settings.backgroundColor), pe.ClipRectangle);
            g.DrawRectangle(new Pen(Settings.borderColor, 2), pe.ClipRectangle);

            if (getValues == null)
                return;


            Pen graphPen = new Pen(Color.White, 1);

            int index = 0;
            foreach(float value in getValues.Reverse())
            {
                // g.DrawLine(graphPen, (float)Math.Round((index / (float)count) * Size.Width), Size.Height, (float)Math.Round((index / (float)count) * Size.Width), Size.Height - value / max * Size.Height);
                g.FillRectangle(new SolidBrush(Color.White), new Rectangle(Size.Width - index, (int)(Size.Height - value / max * Size.Height), 1, (int)(value / max * Size.Height)));
                index++;
                if (index > Size.Width)
                    break;
            }

        }
    }
}
