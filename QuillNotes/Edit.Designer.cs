namespace QuillNotes
{
    partial class NoteEditor
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
            this.SaveNoteButton = new System.Windows.Forms.Button();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.editBox = new System.Windows.Forms.RichTextBox();
            this.noteDisplay = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // SaveNoteButton
            // 
            this.SaveNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SaveNoteButton.Location = new System.Drawing.Point(12, 418);
            this.SaveNoteButton.Name = "SaveNoteButton";
            this.SaveNoteButton.Size = new System.Drawing.Size(75, 23);
            this.SaveNoteButton.TabIndex = 1;
            this.SaveNoteButton.Text = "Save Note";
            this.SaveNoteButton.UseVisualStyleBackColor = true;
            // 
            // titleBox
            // 
            this.titleBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.titleBox.Location = new System.Drawing.Point(13, 13);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(775, 20);
            this.titleBox.TabIndex = 2;
            // 
            // editBox
            // 
            this.editBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.editBox.Location = new System.Drawing.Point(12, 40);
            this.editBox.Name = "editBox";
            this.editBox.Size = new System.Drawing.Size(388, 372);
            this.editBox.TabIndex = 3;
            this.editBox.Text = "";
            // 
            // noteDisplay
            // 
            this.noteDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.noteDisplay.Location = new System.Drawing.Point(406, 40);
            this.noteDisplay.MinimumSize = new System.Drawing.Size(20, 20);
            this.noteDisplay.Name = "noteDisplay";
            this.noteDisplay.Size = new System.Drawing.Size(388, 372);
            this.noteDisplay.TabIndex = 4;
            // 
            // NoteEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.noteDisplay);
            this.Controls.Add(this.editBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.SaveNoteButton);
            this.Name = "NoteEditor";
            this.Text = "Note Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SaveNoteButton;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.RichTextBox editBox;
        private System.Windows.Forms.WebBrowser noteDisplay;
    }
}