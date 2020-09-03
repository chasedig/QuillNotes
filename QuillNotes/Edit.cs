using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Markdig;

namespace QuillNotes
{
	public partial class NoteEditor : Form
	{
		public bool creating { get; }
		private NotesWindow mainForm = (NotesWindow)Application.OpenForms[0];

		public NoteEditor(string title, string contents, bool creating)
		{
			InitializeComponent();
			this.creating = creating;
			titleBox.Text = title;
			editBox.Text = contents;
			SyncNoteDisplay();
		}

		private void SyncNoteDisplay()
		{
			string editBoxText = editBox.Text;
			var markdownResult = Markdown.ToHtml(editBoxText);
			noteDisplay.DocumentText = markdownResult;
		}

		private void editBox_TextChanged(object sender, EventArgs e)
		{
			SyncNoteDisplay();
		}

		private void SaveNoteButton_Click(object sender, EventArgs e)
		{
			mainForm.AddNote(titleBox.Text,editBox.Text);
		}
	}
}
