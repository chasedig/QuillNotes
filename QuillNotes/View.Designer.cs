namespace QuillNotes
{
    partial class View
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
			this.titleLabel = new System.Windows.Forms.Label();
			this.noteDisplay = new System.Windows.Forms.WebBrowser();
			this.Separator = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleLabel.Location = new System.Drawing.Point(13, 13);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(104, 37);
			this.titleLabel.TabIndex = 0;
			this.titleLabel.Text = "TITLE";
			// 
			// noteDisplay
			// 
			this.noteDisplay.IsWebBrowserContextMenuEnabled = false;
			this.noteDisplay.Location = new System.Drawing.Point(12, 66);
			this.noteDisplay.MinimumSize = new System.Drawing.Size(20, 20);
			this.noteDisplay.Name = "noteDisplay";
			this.noteDisplay.Size = new System.Drawing.Size(768, 372);
			this.noteDisplay.TabIndex = 1;
			// 
			// Separator
			// 
			this.Separator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Separator.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Separator.Location = new System.Drawing.Point(20, 50);
			this.Separator.Name = "Separator";
			this.Separator.Size = new System.Drawing.Size(771, 2);
			this.Separator.TabIndex = 2;
			// 
			// View
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Separator);
			this.Controls.Add(this.noteDisplay);
			this.Controls.Add(this.titleLabel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "View";
			this.Text = "View";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.WebBrowser noteDisplay;
        private System.Windows.Forms.Label Separator;
    }
}