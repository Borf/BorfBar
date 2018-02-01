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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MqttPreferences));
			this.lstComponents = new System.Windows.Forms.ListBox();
			this.lstItems = new System.Windows.Forms.ListView();
			this.mqttIcons = new System.Windows.Forms.ImageList(this.components);
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
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
			// lstItems
			// 
			this.lstItems.Location = new System.Drawing.Point(3, 130);
			this.lstItems.MultiSelect = false;
			this.lstItems.Name = "lstItems";
			this.lstItems.Size = new System.Drawing.Size(176, 365);
			this.lstItems.SmallImageList = this.mqttIcons;
			this.lstItems.TabIndex = 1;
			this.lstItems.UseCompatibleStateImageBehavior = false;
			this.lstItems.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstItems_ItemSelectionChanged);
			// 
			// mqttIcons
			// 
			this.mqttIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("mqttIcons.ImageStream")));
			this.mqttIcons.TransparentColor = System.Drawing.Color.Transparent;
			this.mqttIcons.Images.SetKeyName(0, "glyphicons-605-text-size.png");
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.propertyGrid1.Location = new System.Drawing.Point(186, 4);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.Size = new System.Drawing.Size(599, 491);
			this.propertyGrid1.TabIndex = 2;
			// 
			// MqttPreferences
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.propertyGrid1);
			this.Controls.Add(this.lstItems);
			this.Controls.Add(this.lstComponents);
			this.Name = "MqttPreferences";
			this.Size = new System.Drawing.Size(788, 500);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstComponents;
        private System.Windows.Forms.ListView lstItems;
		private System.Windows.Forms.ImageList mqttIcons;
		private System.Windows.Forms.PropertyGrid propertyGrid1;
	}
}
