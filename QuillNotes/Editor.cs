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
	public partial class Editor : Form
	{
		public bool creating { get; }

		public int index {get; set;}

		public MainWindow mainForm { get; }

		public Editor(string[] note, int index, bool creating, MainWindow creator)
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
