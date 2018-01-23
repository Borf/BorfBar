namespace BorfBar.modules
{
    partial class RamPreferences
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
            this.showGraph = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // showGraph
            // 
            this.showGraph.AutoSize = true;
            this.showGraph.Location = new System.Drawing.Point(13, 25);
            this.showGraph.Name = "showGraph";
            this.showGraph.Size = new System.Drawing.Size(55, 17);
            this.showGraph.TabIndex = 1;
            this.showGraph.Text = "Graph";
            this.showGraph.UseVisualStyleBackColor = true;
            // 
            // RamPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.showGraph);
            this.Name = "RamPreferences";
            this.Size = new System.Drawing.Size(148, 148);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox showGraph;
    }
}
