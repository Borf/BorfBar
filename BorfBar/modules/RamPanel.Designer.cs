namespace BorfBar.modules
{
    partial class RamPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.RAM = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RAM
            // 
            this.RAM.AutoSize = true;
            this.RAM.ForeColor = System.Drawing.Color.White;
            this.RAM.Location = new System.Drawing.Point(48, 2);
            this.RAM.Name = "RAM";
            this.RAM.Size = new System.Drawing.Size(24, 13);
            this.RAM.TabIndex = 0;
            this.RAM.Text = "-- %";
            this.RAM.MouseHover += new System.EventHandler(this.RAM_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Margin = new System.Windows.Forms.Padding(0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(39, 15);
            this.title.TabIndex = 1;
            this.title.Text = "RAM:";
            // 
            // CpuPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.title);
            this.Controls.Add(this.RAM);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CpuPanel";
            this.Size = new System.Drawing.Size(75, 15);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RAM;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label title;
    }
}
