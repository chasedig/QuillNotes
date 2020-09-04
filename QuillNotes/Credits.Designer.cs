namespace QuillNotes
{
	partial class CreditsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditsForm));
			this.creditsRenderer = new System.Windows.Forms.WebBrowser();
			this.SuspendLayout();
			// 
			// creditsRenderer
			// 
			this.creditsRenderer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.creditsRenderer.IsWebBrowserContextMenuEnabled = false;
			this.creditsRenderer.Location = new System.Drawing.Point(0, 0);
			this.creditsRenderer.MinimumSize = new System.Drawing.Size(20, 20);
			this.creditsRenderer.Name = "creditsRenderer";
			this.creditsRenderer.Size = new System.Drawing.Size(345, 450);
			this.creditsRenderer.TabIndex = 0;
			// 
			// CreditsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(345, 450);
			this.Controls.Add(this.creditsRenderer);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CreditsForm";
			this.Text = "Credits";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.WebBrowser creditsRenderer;
	}
}