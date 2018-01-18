namespace BorfBar
{
    partial class frmPreferences
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstModules = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstAllModules = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstModules
            // 
            this.lstModules.AllowDrop = true;
            this.lstModules.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstModules.FormattingEnabled = true;
            this.lstModules.Location = new System.Drawing.Point(12, 129);
            this.lstModules.Name = "lstModules";
            this.lstModules.Size = new System.Drawing.Size(255, 472);
            this.lstModules.TabIndex = 0;
            this.lstModules.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstModules_DragDrop);
            this.lstModules.DragOver += new System.Windows.Forms.DragEventHandler(this.lstModules_DragOver);
            this.lstModules.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstModules_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modules";
            // 
            // lstAllModules
            // 
            this.lstAllModules.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstAllModules.FormattingEnabled = true;
            this.lstAllModules.Location = new System.Drawing.Point(12, 28);
            this.lstAllModules.Name = "lstAllModules";
            this.lstAllModules.Size = new System.Drawing.Size(255, 95);
            this.lstAllModules.TabIndex = 3;
            this.lstAllModules.DoubleClick += new System.EventHandler(this.lstAllModules_DoubleClick);
            // 
            // frmPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 618);
            this.Controls.Add(this.lstAllModules);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstModules);
            this.Name = "frmPreferences";
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.frmPreferences_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstModules;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstAllModules;
    }
}