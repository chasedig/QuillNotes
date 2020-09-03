namespace QuillNotes
{
    partial class NotesWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_New = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_NewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_New,
            this.menu_NewWindow,
            this.menu_Open,
            this.menu_Save,
            this.menu_SaveAs});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menu_New
            // 
            this.menu_New.Name = "menu_New";
            this.menu_New.ShortcutKeyDisplayString = "Ctrl+N";
            this.menu_New.Size = new System.Drawing.Size(220, 22);
            this.menu_New.Text = "New";
            // 
            // menu_NewWindow
            // 
            this.menu_NewWindow.Name = "menu_NewWindow";
            this.menu_NewWindow.ShortcutKeyDisplayString = "Ctrl+Shift+N";
            this.menu_NewWindow.Size = new System.Drawing.Size(220, 22);
            this.menu_NewWindow.Text = "New Window";
            this.menu_NewWindow.ToolTipText = "Open a new Quill Notes window";
            // 
            // menu_Open
            // 
            this.menu_Open.Name = "menu_Open";
            this.menu_Open.ShortcutKeyDisplayString = "Ctrl+O";
            this.menu_Open.Size = new System.Drawing.Size(220, 22);
            this.menu_Open.Text = "Open";
            this.menu_Open.ToolTipText = "Open a .QUILL file";
            // 
            // menu_Save
            // 
            this.menu_Save.Name = "menu_Save";
            this.menu_Save.ShortcutKeyDisplayString = "Ctrl+S";
            this.menu_Save.Size = new System.Drawing.Size(220, 22);
            this.menu_Save.Text = "Save";
            this.menu_Save.ToolTipText = "Save the current document";
            // 
            // menu_SaveAs
            // 
            this.menu_SaveAs.Name = "menu_SaveAs";
            this.menu_SaveAs.ShortcutKeyDisplayString = "Ctrl+Shift+S";
            this.menu_SaveAs.Size = new System.Drawing.Size(220, 22);
            this.menu_SaveAs.Text = "Save As";
            this.menu_SaveAs.ToolTipText = "Save the current document to file";
            // 
            // NotesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NotesWindow";
            this.Text = "Quill Notes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_New;
        private System.Windows.Forms.ToolStripMenuItem menu_Open;
        private System.Windows.Forms.ToolStripMenuItem menu_Save;
        private System.Windows.Forms.ToolStripMenuItem menu_SaveAs;
        private System.Windows.Forms.ToolStripMenuItem menu_NewWindow;
    }
}

