using System;
using System.Windows.Forms;

namespace QuillNotes
{
	partial class MainWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.toolbar = new System.Windows.Forms.MenuStrip();
			this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.menu_File_new = new System.Windows.Forms.ToolStripMenuItem();
			this.menu_File_open = new System.Windows.Forms.ToolStripMenuItem();
			this.menu_File_save = new System.Windows.Forms.ToolStripMenuItem();
			this.menu_File_saveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.menu_File_DividingLine = new System.Windows.Forms.ToolStripSeparator();
			this.menu_File_Settings = new System.Windows.Forms.ToolStripMenuItem();
			this.menu_File_quit = new System.Windows.Forms.ToolStripMenuItem();
			this.SearchMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.menu_Search_findAnywhere = new System.Windows.Forms.ToolStripMenuItem();
			this.menu_Search_findInTitle = new System.Windows.Forms.ToolStripMenuItem();
			this.menu_Search_findInContent = new System.Windows.Forms.ToolStripMenuItem();
			this.EncryptMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.menu_Encrypt_openEncrypted = new System.Windows.Forms.ToolStripMenuItem();
			this.menu_Encrypt_saveAsEncrypted = new System.Windows.Forms.ToolStripMenuItem();
			this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.menu_Help_manual = new System.Windows.Forms.ToolStripMenuItem();
			this.menu_Help_markdownHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.menu_Help_DividingLine = new System.Windows.Forms.ToolStripSeparator();
			this.menu_Help_credits = new System.Windows.Forms.ToolStripMenuItem();
			this.NotesBox = new System.Windows.Forms.ListBox();
			this.ViewButton = new System.Windows.Forms.Button();
			this.EditButton = new System.Windows.Forms.Button();
			this.NewButton = new System.Windows.Forms.Button();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.copyrightNotice = new System.Windows.Forms.Label();
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
            this.SearchMenu,
            this.EncryptMenu,
            this.HelpMenu});
			this.toolbar.Location = new System.Drawing.Point(0, 0);
			this.toolbar.Name = "toolbar";
			this.toolbar.Size = new System.Drawing.Size(800, 24);
			this.toolbar.TabIndex = 0;
			this.toolbar.Text = "toolbarStrip";
			// 
			// FileMenu
			// 
			this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_File_new,
            this.menu_File_open,
            this.menu_File_save,
            this.menu_File_saveAs,
            this.menu_File_DividingLine,
            this.menu_File_Settings,
            this.menu_File_quit});
			this.FileMenu.Name = "FileMenu";
			this.FileMenu.Size = new System.Drawing.Size(37, 20);
			this.FileMenu.Text = "File";
			// 
			// menu_File_new
			// 
			this.menu_File_new.Name = "menu_File_new";
			this.menu_File_new.ShortcutKeyDisplayString = "";
			this.menu_File_new.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.menu_File_new.Size = new System.Drawing.Size(186, 22);
			this.menu_File_new.Text = "New";
			this.menu_File_new.ToolTipText = "Open a new Quill Notes document";
			this.menu_File_new.Click += new System.EventHandler(this.NewToolbar_Click);
			// 
			// menu_File_open
			// 
			this.menu_File_open.Name = "menu_File_open";
			this.menu_File_open.ShortcutKeyDisplayString = "";
			this.menu_File_open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.menu_File_open.Size = new System.Drawing.Size(186, 22);
			this.menu_File_open.Text = "Open";
			this.menu_File_open.ToolTipText = "Open a .QUILL file";
			this.menu_File_open.Click += new System.EventHandler(this.OpenToolbar_Click);
			// 
			// menu_File_save
			// 
			this.menu_File_save.Name = "menu_File_save";
			this.menu_File_save.ShortcutKeyDisplayString = "";
			this.menu_File_save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.menu_File_save.Size = new System.Drawing.Size(186, 22);
			this.menu_File_save.Text = "Save";
			this.menu_File_save.ToolTipText = "Save the current document";
			this.menu_File_save.Click += new System.EventHandler(this.SaveToolbar_Click);
			// 
			// menu_File_saveAs
			// 
			this.menu_File_saveAs.Name = "menu_File_saveAs";
			this.menu_File_saveAs.ShortcutKeyDisplayString = "";
			this.menu_File_saveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.menu_File_saveAs.Size = new System.Drawing.Size(186, 22);
			this.menu_File_saveAs.Text = "Save As";
			this.menu_File_saveAs.ToolTipText = "Save the current document to file";
			this.menu_File_saveAs.Click += new System.EventHandler(this.SaveAsToolbar_Click);
			// 
			// menu_File_DividingLine
			// 
			this.menu_File_DividingLine.Name = "menu_File_DividingLine";
			this.menu_File_DividingLine.Size = new System.Drawing.Size(183, 6);
			// 
			// menu_File_Settings
			// 
			this.menu_File_Settings.Name = "menu_File_Settings";
			this.menu_File_Settings.Size = new System.Drawing.Size(186, 22);
			this.menu_File_Settings.Text = "Settings";
			this.menu_File_Settings.Click += new System.EventHandler(this.menu_File_Settings_Click);
			// 
			// menu_File_quit
			// 
			this.menu_File_quit.Name = "menu_File_quit";
			this.menu_File_quit.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Q)));
			this.menu_File_quit.Size = new System.Drawing.Size(186, 22);
			this.menu_File_quit.Text = "Quit";
			this.menu_File_quit.ToolTipText = "Exit Quill Notes";
			this.menu_File_quit.Click += new System.EventHandler(this.QuitToolbar_Click);
			// 
			// SearchMenu
			// 
			this.SearchMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Search_findAnywhere,
            this.menu_Search_findInTitle,
            this.menu_Search_findInContent});
			this.SearchMenu.Name = "SearchMenu";
			this.SearchMenu.Size = new System.Drawing.Size(54, 20);
			this.SearchMenu.Text = "Search";
			// 
			// menu_Search_findAnywhere
			// 
			this.menu_Search_findAnywhere.Name = "menu_Search_findAnywhere";
			this.menu_Search_findAnywhere.Size = new System.Drawing.Size(154, 22);
			this.menu_Search_findAnywhere.Text = "Find anywhere";
			// 
			// menu_Search_findInTitle
			// 
			this.menu_Search_findInTitle.Name = "menu_Search_findInTitle";
			this.menu_Search_findInTitle.Size = new System.Drawing.Size(154, 22);
			this.menu_Search_findInTitle.Text = "Find in title";
			// 
			// menu_Search_findInContent
			// 
			this.menu_Search_findInContent.Name = "menu_Search_findInContent";
			this.menu_Search_findInContent.Size = new System.Drawing.Size(154, 22);
			this.menu_Search_findInContent.Text = "Find in content";
			// 
			// EncryptMenu
			// 
			this.EncryptMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Encrypt_openEncrypted,
            this.menu_Encrypt_saveAsEncrypted});
			this.EncryptMenu.Name = "EncryptMenu";
			this.EncryptMenu.Size = new System.Drawing.Size(59, 20);
			this.EncryptMenu.Text = "Encrypt";
			this.EncryptMenu.Visible = false;
			// 
			// menu_Encrypt_openEncrypted
			// 
			this.menu_Encrypt_openEncrypted.Name = "menu_Encrypt_openEncrypted";
			this.menu_Encrypt_openEncrypted.Size = new System.Drawing.Size(168, 22);
			this.menu_Encrypt_openEncrypted.Text = "Open encrypted";
			// 
			// menu_Encrypt_saveAsEncrypted
			// 
			this.menu_Encrypt_saveAsEncrypted.Name = "menu_Encrypt_saveAsEncrypted";
			this.menu_Encrypt_saveAsEncrypted.Size = new System.Drawing.Size(168, 22);
			this.menu_Encrypt_saveAsEncrypted.Text = "Save as encrypted";
			// 
			// HelpMenu
			// 
			this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Help_manual,
            this.menu_Help_markdownHelp,
            this.menu_Help_DividingLine,
            this.menu_Help_credits});
			this.HelpMenu.Name = "HelpMenu";
			this.HelpMenu.Size = new System.Drawing.Size(44, 20);
			this.HelpMenu.Text = "Help";
			// 
			// menu_Help_manual
			// 
			this.menu_Help_manual.Name = "menu_Help_manual";
			this.menu_Help_manual.Size = new System.Drawing.Size(159, 22);
			this.menu_Help_manual.Text = "Manual";
			// 
			// menu_Help_markdownHelp
			// 
			this.menu_Help_markdownHelp.Name = "menu_Help_markdownHelp";
			this.menu_Help_markdownHelp.Size = new System.Drawing.Size(159, 22);
			this.menu_Help_markdownHelp.Text = "Markdown Help";
			// 
			// menu_Help_DividingLine
			// 
			this.menu_Help_DividingLine.Name = "menu_Help_DividingLine";
			this.menu_Help_DividingLine.Size = new System.Drawing.Size(156, 6);
			// 
			// menu_Help_credits
			// 
			this.menu_Help_credits.Name = "menu_Help_credits";
			this.menu_Help_credits.Size = new System.Drawing.Size(159, 22);
			this.menu_Help_credits.Text = "Credits";
			this.menu_Help_credits.Click += new System.EventHandler(this.creditsToolbar_Click);
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
			// copyrightNotice
			// 
			this.copyrightNotice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.copyrightNotice.AutoSize = true;
			this.copyrightNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.copyrightNotice.Location = new System.Drawing.Point(659, 434);
			this.copyrightNotice.Name = "copyrightNotice";
			this.copyrightNotice.Size = new System.Drawing.Size(141, 16);
			this.copyrightNotice.TabIndex = 8;
			this.copyrightNotice.Text = "© 2020, Chase Carlson";
			this.copyrightNotice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.copyrightNotice);
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
			this.Name = "MainWindow";
			this.Text = "Quill Notes";
			this.FormClosing += new FormClosingEventHandler(this.MainWindow_FormClosing);
			this.toolbar.ResumeLayout(false);
			this.toolbar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip toolbar;
		private System.Windows.Forms.ListBox NotesBox;
		private System.Windows.Forms.Button ViewButton;
		private System.Windows.Forms.Button EditButton;
		private System.Windows.Forms.Button NewButton;
		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.Button upArrowButton;
		private System.Windows.Forms.Button downArrowButton;
		private System.Windows.Forms.Label copyrightNotice;

		// Toolbar Menus

		// File Menu
		private System.Windows.Forms.ToolStripMenuItem FileMenu;
		private System.Windows.Forms.ToolStripMenuItem menu_File_new;
		private System.Windows.Forms.ToolStripMenuItem menu_File_open;
		private System.Windows.Forms.ToolStripMenuItem menu_File_save;
		private System.Windows.Forms.ToolStripMenuItem menu_File_saveAs;
		private System.Windows.Forms.ToolStripSeparator menu_File_DividingLine;
		private System.Windows.Forms.ToolStripMenuItem menu_File_quit;
		// Search Menu
		private System.Windows.Forms.ToolStripMenuItem SearchMenu;
		private System.Windows.Forms.ToolStripMenuItem menu_Search_findInTitle;
		private System.Windows.Forms.ToolStripMenuItem menu_Search_findInContent;
		private System.Windows.Forms.ToolStripMenuItem menu_Search_findAnywhere;
		// Help Menu
		private System.Windows.Forms.ToolStripMenuItem HelpMenu;
		private System.Windows.Forms.ToolStripMenuItem menu_Help_manual;
		private System.Windows.Forms.ToolStripSeparator menu_Help_DividingLine;
		private System.Windows.Forms.ToolStripMenuItem menu_Help_credits;
		private System.Windows.Forms.ToolStripMenuItem menu_Help_markdownHelp;
		// Encrypt Menu
		private System.Windows.Forms.ToolStripMenuItem EncryptMenu;
		private System.Windows.Forms.ToolStripMenuItem menu_Encrypt_saveAsEncrypted;
		private System.Windows.Forms.ToolStripMenuItem menu_Encrypt_openEncrypted;
		private System.Windows.Forms.ToolStripMenuItem menu_File_Settings;
	}
}

