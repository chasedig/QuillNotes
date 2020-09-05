using CefSharp.WinForms;
using System.Windows.Forms;

namespace QuillNotes
{
	partial class MarkdownRendererForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarkdownRendererForm));
			this.MarkdownRenderer = new System.Windows.Forms.WebBrowser();
			this.SuspendLayout();
			// 
			// MarkdownRenderer
			// 
			this.MarkdownRenderer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MarkdownRenderer.Location = new System.Drawing.Point(0, 0);
			this.MarkdownRenderer.MinimumSize = new System.Drawing.Size(20, 20);
			this.MarkdownRenderer.Name = "MarkdownRenderer";
			this.MarkdownRenderer.Size = new System.Drawing.Size(960, 450);
			this.MarkdownRenderer.TabIndex = 0;
			// 
			// MarkdownRendererForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(359, 450);
			this.Controls.Add(this.MarkdownRenderer);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MarkdownRendererForm";
			this.Text = "MarkdownRenderer";
			this.ResumeLayout(false);

		}

		#endregion

		private WebBrowser MarkdownRenderer;
	}
}