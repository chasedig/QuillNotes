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

		public int index {
			get { return _index; }
			set
			{
				_index = value;
				this.Text = Convert.ToString(_index);
				Console.WriteLine("Index of " + this.titleBox.Text + " changed to " + Convert.ToString(_index));
			} 
		}

		private int _index;
		public NotesWindow mainForm { get; }

		public NoteEditor(string[] note, int index, bool creating, NotesWindow creator)
		{
			InitializeComponent();
			this.creating = creating;
			this.index = index;
			mainForm = creator;
			ActiveControl = titleBox;
			titleBox.Text = note[0];
			editBox.Text = note[1];
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
			if (titleBox.Text != "") {
				string[] noteObject = { titleBox.Text, editBox.Text };
				if (this.creating)
				{
					mainForm.AddNote(noteObject);
				}
				else {
					mainForm.SaveNote(noteObject, this.index);
				}
				this.Close();
			}
			else {
				MessageBox.Show(
					"The title field is required",
					"Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
		}
	}
}
