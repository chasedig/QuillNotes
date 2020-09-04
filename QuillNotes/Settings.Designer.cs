namespace QuillNotes
{
	partial class SettingsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
			this.settingsListBox = new System.Windows.Forms.CheckedListBox();
			this.SuspendLayout();
			// 
			// settingsListBox
			// 
			this.settingsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.settingsListBox.FormattingEnabled = true;
			this.settingsListBox.Location = new System.Drawing.Point(248, 3);
			this.settingsListBox.Name = "settingsListBox";
			this.settingsListBox.Size = new System.Drawing.Size(338, 439);
			this.settingsListBox.TabIndex = 0;
			this.settingsListBox.SelectedIndexChanged += new System.EventHandler(this.settingsListBox_SelectedIndexChanged);
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.settingsListBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SettingsForm";
			this.Text = "Settings";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.CheckedListBox settingsListBox;
	}
}