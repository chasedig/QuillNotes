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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotesWindow));
			this.toolbar = new System.Windows.Forms.MenuStrip();
			this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.menu_New = new System.Windows.Forms.ToolStripMenuItem();
			this.menu_Open = new System.Windows.Forms.ToolStripMenuItem();
			this.menu_Save = new System.Windows.Forms.ToolStripMenuItem();
			this.menu_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.menu_DividingLine = new System.Windows.Forms.ToolStripSeparator();
			this.menu_Quit = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NotesBox = new System.Windows.Forms.ListBox();
			this.ViewButton = new System.Windows.Forms.Button();
			this.EditButton = new System.Windows.Forms.Button();
			this.NewButton = new System.Windows.Forms.Button();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.downArrowButton = new System.Windows.Forms.Button();
			this.upArrowButton = new System.Windows.Forms.Button();
			this.toolbar.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolbar
			// 
			this.toolbar.BackColor = System.Drawing.Color.Gainsboro;
			this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.FileMenu,
			this.saveToolStripMenuItem});
			this.toolbar.Location = new System.Drawing.Point(0, 0);
			this.toolbar.Name = "toolbar";
			this.toolbar.Size = new System.Drawing.Size(800, 24);
			this.toolbar.TabIndex = 0;
			this.toolbar.Text = "toolbarStrip";
			// 
			// FileMenu
			// 
			this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menu_New,
			this.menu_Open,
			this.menu_Save,
			this.menu_SaveAs,
			this.menu_DividingLine,
			this.menu_Quit});
			this.FileMenu.Name = "FileMenu";
			this.FileMenu.Size = new System.Drawing.Size(37, 20);
			this.FileMenu.Text = "File";
			// 
			// menu_New
			// 
			this.menu_New.Name = "menu_New";
			this.menu_New.ShortcutKeyDisplayString = "";
			this.menu_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.menu_New.Size = new System.Drawing.Size(186, 22);
			this.menu_New.Text = "New";
			this.menu_New.ToolTipText = "Open a new Quill Notes document";
			this.menu_New.Click += new System.EventHandler(this.NewToolbar_Click);
			// 
			// menu_Open
			// 
			this.menu_Open.Name = "menu_Open";
			this.menu_Open.ShortcutKeyDisplayString = "";
			this.menu_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.menu_Open.Size = new System.Drawing.Size(186, 22);
			this.menu_Open.Text = "Open";
			this.menu_Open.ToolTipText = "Open a .QUILL file";
			this.menu_Open.Click += new System.EventHandler(this.OpenToolbar_Click);
			// 
			// menu_Save
			// 
			this.menu_Save.Name = "menu_Save";
			this.menu_Save.ShortcutKeyDisplayString = "";
			this.menu_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.menu_Save.Size = new System.Drawing.Size(186, 22);
			this.menu_Save.Text = "Save";
			this.menu_Save.ToolTipText = "Save the current document";
			this.menu_Save.Click += new System.EventHandler(this.SaveToolbar_Click);
			// 
			// menu_SaveAs
			// 
			this.menu_SaveAs.Name = "menu_SaveAs";
			this.menu_SaveAs.ShortcutKeyDisplayString = "";
			this.menu_SaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
			| System.Windows.Forms.Keys.S)));
			this.menu_SaveAs.Size = new System.Drawing.Size(186, 22);
			this.menu_SaveAs.Text = "Save As";
			this.menu_SaveAs.ToolTipText = "Save the current document to file";
			this.menu_SaveAs.Click += new System.EventHandler(this.SaveAsToolbar_Click);
			// 
			// menu_DividingLine
			// 
			this.menu_DividingLine.Name = "menu_DividingLine";
			this.menu_DividingLine.Size = new System.Drawing.Size(183, 6);
			// 
			// menu_Quit
			// 
			this.menu_Quit.Name = "menu_Quit";
			this.menu_Quit.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
			| System.Windows.Forms.Keys.Q)));
			this.menu_Quit.Size = new System.Drawing.Size(186, 22);
			this.menu_Quit.Text = "Quit";
			this.menu_Quit.ToolTipText = "Exit Quill Notes";
			this.menu_Quit.Click += new System.EventHandler(this.QuitToolbar_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.saveToolStripMenuItem.Text = "Save";
			// 
			// NotesBox
			// 
			this.NotesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NotesBox.FormattingEnabled = true;
			this.NotesBox.ItemHeight = 25;
			this.NotesBox.Location = new System.Drawing.Point(12, 38);
			this.NotesBox.Name = "NotesBox";
			this.NotesBox.Size = new System.Drawing.Size(776, 304);
			this.NotesBox.TabIndex = 1;
			this.NotesBox.SelectedIndexChanged += new System.EventHandler(this.NotesBox_SelectedIndexChanged);
			this.NotesBox.DoubleClick += new System.EventHandler(this.NotesBox_DoubleClick);
			// 
			// ViewButton
			// 
			this.ViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ViewButton.Location = new System.Drawing.Point(12, 348);
			this.ViewButton.MaximumSize = new System.Drawing.Size(75, 23);
			this.ViewButton.Name = "ViewButton";
			this.ViewButton.Size = new System.Drawing.Size(75, 23);
			this.ViewButton.TabIndex = 2;
			this.ViewButton.Text = "View";
			this.ViewButton.UseVisualStyleBackColor = true;
			this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
			// 
			// EditButton
			// 
			this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.EditButton.Location = new System.Drawing.Point(93, 348);
			this.EditButton.MaximumSize = new System.Drawing.Size(75, 23);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(75, 23);
			this.EditButton.TabIndex = 3;
			this.EditButton.Text = "Edit";
			this.EditButton.UseVisualStyleBackColor = true;
			this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
			// 
			// NewButton
			// 
			this.NewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.NewButton.Location = new System.Drawing.Point(713, 348);
			this.NewButton.MaximumSize = new System.Drawing.Size(75, 23);
			this.NewButton.Name = "NewButton";
			this.NewButton.Size = new System.Drawing.Size(75, 23);
			this.NewButton.TabIndex = 4;
			this.NewButton.Text = "New";
			this.NewButton.UseVisualStyleBackColor = true;
			this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
			// 
			// DeleteButton
			// 
			this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.DeleteButton.ForeColor = System.Drawing.Color.Red;
			this.DeleteButton.Location = new System.Drawing.Point(174, 348);
			this.DeleteButton.MaximumSize = new System.Drawing.Size(75, 23);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(75, 23);
			this.DeleteButton.TabIndex = 5;
			this.DeleteButton.Text = "Delete";
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// downArrowButton
			// 
			this.downArrowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.downArrowButton.Image = global::QuillNotes.Properties.Resources.downArrow;
			this.downArrowButton.Location = new System.Drawing.Point(371, 348);
			this.downArrowButton.MaximumSize = new System.Drawing.Size(75, 23);
			this.downArrowButton.Name = "downArrowButton";
			this.downArrowButton.Size = new System.Drawing.Size(75, 23);
			this.downArrowButton.TabIndex = 7;
			this.downArrowButton.UseVisualStyleBackColor = true;
			this.downArrowButton.Click += new System.EventHandler(this.downArrowButton_Click);
			// 
			// upArrowButton
			// 
			this.upArrowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.upArrowButton.Image = global::QuillNotes.Properties.Resources.upArrow;
			this.upArrowButton.Location = new System.Drawing.Point(290, 348);
			this.upArrowButton.MaximumSize = new System.Drawing.Size(75, 23);
			this.upArrowButton.Name = "upArrowButton";
			this.upArrowButton.Size = new System.Drawing.Size(75, 23);
			this.upArrowButton.TabIndex = 6;
			this.upArrowButton.UseVisualStyleBackColor = true;
			this.upArrowButton.Click += new System.EventHandler(this.upArrowButton_Click);
			// 
			// NotesWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.downArrowButton);
			this.Controls.Add(this.upArrowButton);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.NewButton);
			this.Controls.Add(this.EditButton);
			this.Controls.Add(this.ViewButton);
			this.Controls.Add(this.NotesBox);
			this.Controls.Add(this.toolbar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.toolbar;
			this.Name = "NotesWindow";
			this.Text = "Quill Notes";
			this.toolbar.ResumeLayout(false);
			this.toolbar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip toolbar;
		private System.Windows.Forms.ToolStripMenuItem FileMenu;
		private System.Windows.Forms.ToolStripMenuItem menu_New;
		private System.Windows.Forms.ToolStripMenuItem menu_Open;
		private System.Windows.Forms.ToolStripMenuItem menu_Save;
		private System.Windows.Forms.ToolStripMenuItem menu_SaveAs;
		private System.Windows.Forms.ToolStripSeparator menu_DividingLine;
		private System.Windows.Forms.ToolStripMenuItem menu_Quit;
		private System.Windows.Forms.ListBox NotesBox;
		private System.Windows.Forms.Button ViewButton;
		private System.Windows.Forms.Button EditButton;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.Button NewButton;
		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.Button upArrowButton;
		private System.Windows.Forms.Button downArrowButton;
	}
}

