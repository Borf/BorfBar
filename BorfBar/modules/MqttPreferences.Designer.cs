namespace BorfBar.modules
{
    partial class MqttPreferences
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
            this.lstComponents = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lstComponents
            // 
            this.lstComponents.FormattingEnabled = true;
            this.lstComponents.Items.AddRange(new object[] {
            "NumberValue",
            "TextValue",
            "Seperator",
            "Button",
            "ValueButton",
            "Slider",
            "Spinner",
            "Combobox"});
            this.lstComponents.Location = new System.Drawing.Point(3, 3);
            this.lstComponents.Name = "lstComponents";
            this.lstComponents.Size = new System.Drawing.Size(176, 121);
            this.lstComponents.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(3, 130);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(176, 365);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // MqttPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lstComponents);
            this.Name = "MqttPreferences";
            this.Size = new System.Drawing.Size(788, 500);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstComponents;
        private System.Windows.Forms.ListView listView1;
    }
}
