using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace QuillNotes
{
	public partial class MainWindow : Form
	{

		public Document document;
		public string savedJSON;
		public string saveFile = "";

		string[] EmptyNote = {"", ""};

		public MainWindow()
		{
			document = new Document();
			savedJSON = JsonConvert.SerializeObject(document);
			InitializeComponent();
			RefreshControls();
			this.copyrightNotice.Text = Utilities.GetCopyrightNotice();
			//Utilities.GenerateDebugNotes(this,100); // Debugging only
		}

		public void AddNote(string[] note)
		{
			document.Notes.Add(note);
			RefreshNotes();
		}

		public void SaveNote(string[] note, int index)
		{
			if (index != -1)
			{
				document.Notes[index] = note;
				RefreshNotes();
			}
		}

		public void SelectNote(int index)
		{
			NotesBox.SelectedIndex = index;
		}

		private void RefreshNotes()
		{
			NotesBox.Items.Clear();
			foreach (var note in document.Notes)
			{
				NotesBox.Items.Add(note[0]);
			}
			RefreshControls();
		}

		private void RefreshControls()
		{
			if (GetSelectedNote() != EmptyNote)
			{
				ViewButton.Enabled = true;
				EditButton.Enabled = true;
				DeleteButton.Enabled = true;
				upArrowButton.Enabled = true;
				downArrowButton.Enabled = true;

			} 
			else 
			{
				ViewButton.Enabled = false;
				EditButton.Enabled = false;
				DeleteButton.Enabled = false;
				upArrowButton.Enabled = false;
				downArrowButton.Enabled = false;
			}
			if ((document.Notes).Count < 2)
			{
				upArrowButton.Enabled = false;
				downArrowButton.Enabled = false;
			}
			if (GetSelectedIndex() < 1) upArrowButton.Enabled = false;
			if (GetSelectedIndex() >= document.Notes.Count-1) downArrowButton.Enabled = false;
		}

		private string[] GetSelectedNote()
		{
			int noteIndex = GetSelectedIndex();
			if (noteIndex != -1)
			{
				string[] note = document.Notes[noteIndex];
				return note;
			};
			return EmptyNote;
		}

		private int GetSelectedIndex()
		{
			return NotesBox.SelectedIndex;
		}

		private void OpenNoteView(int noteIndex)
		{
			string[] note = GetSelectedNote();
			View viewForm = new View(note, noteIndex);
			viewForm.Show();
		}

		private void ViewButton_Click(object sender, EventArgs e)
		{
			if (GetSelectedIndex() != -1)
			{
				OpenNoteView(GetSelectedIndex());
			}
		}

		private void EditButton_Click(object sender, EventArgs e)
		{
			int noteIndex = GetSelectedIndex();
			string[] note = GetSelectedNote();


			foreach (Form form in Application.OpenForms)
			{
				if (form is Editor)
				{
					if (((Editor)form).index == noteIndex)
					{
						form.Focus();
						return;
					}
				}
			}
			if (note != EmptyNote)
			{
				Editor editorWindow = new Editor(note, GetSelectedIndex(), false, this);
				editorWindow.Show();
				return;
			}
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			string[] note = GetSelectedNote();
			int selectedIndex = GetSelectedIndex();
			if (note != EmptyNote)
			{
				var result = MessageBox.Show(
					"Are you sure you want to delete note \"" + note[0] + "\"?",
					"Confirm Note Deletion",
					MessageBoxButtons.YesNoCancel,
					MessageBoxIcon.Exclamation
					);
				if (result == DialogResult.Yes)
				{
					for (int i=Application.OpenForms.Count - 1; i>=0; i--)
					{
						Form form = Application.OpenForms[i];
						if (GetWindowIndex(form) == selectedIndex)
						{
							form.Close();
						}
						if (form is Editor || form is View) {
							int windowIndex = GetWindowIndex(form);
							Console.WriteLine("Index of " + form.Name + " is " + Convert.ToString(windowIndex));
							if (windowIndex > selectedIndex)
							SetWindowIndex(form, windowIndex - 1);
							Console.WriteLine("Set window index of " + form.Name + " to " + Convert.ToString(windowIndex));
						}
					}
					document.Notes.RemoveAt(selectedIndex);
					RefreshNotes();
				}
			}
		}

		private void NewButton_Click(object sender, EventArgs e)
		{
			Editor editorWindow = new Editor(EmptyNote,0,true, this);
			editorWindow.Text = "New Note"; // Changes title of the editing window to "New Note"
			editorWindow.Show();
			Console.WriteLine("New editor created");
		}

		private void NotesBox_DoubleClick(object sender, EventArgs e)
		{
			if (GetSelectedIndex() != -1) OpenNoteView(GetSelectedIndex());
		}

		private void NotesBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			RefreshControls();
		}

		private int GetWindowIndex(Form form)
		{
			int[] windowIndexes = new int[2] {
			GetWindowIndexOfType<Editor>(),
			GetWindowIndexOfType<View>()
			};
			foreach (int windowIndex in windowIndexes)
			{
				if (windowIndex != -1)
				{
					return windowIndex;
				}
			}
			int GetWindowIndexOfType<T>()
			{

				if (form is T)
				{
					dynamic castedForm = Utilities.CastObject<T>(form);
					return castedForm.index;
				}
				return -1;
			}
			return -1;
		}

		private void SetWindowIndex(Form form, int index)
		{
			SetWindowIndexOfType<Editor>();
			SetWindowIndexOfType<View>();
			void SetWindowIndexOfType<T>()
			{

				if (form is T)
				{
					dynamic castedForm = Utilities.CastObject<T>(form);
					Console.WriteLine("Set window " + form.Text + " to " + index);
					castedForm.index = index;
				}
			}
		}

		private void ReplaceWindowIndexes(int x, int y)
		{

			ReplaceWindowIndexesOfType<Editor>();
			ReplaceWindowIndexesOfType<View>();
			void ReplaceWindowIndexesOfType<T>()
			{
				for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
				{
					Form form = Application.OpenForms[i];
					if (form is T)
					{
						dynamic castedForm = Utilities.CastObject<T>(form);
						if (castedForm.index == x)
						{
							Console.WriteLine("REPLACING " + x + " WITH " + y);
							castedForm.index = y;
						}
						else if (castedForm.index == y)
						{
							Console.WriteLine("REPLACING " + y + " WITH " + x);
							castedForm.index = x;
						}
					}
				}
			}
		}

		private void upArrowButton_Click(object sender, EventArgs e)
		{
			int selectedIndex = GetSelectedIndex();
			int newIndex = GetSelectedIndex() - 1;
			if (selectedIndex != -1 && newIndex != -1)
			{
				string[] NoteObject = GetSelectedNote();
				string[] PrecedingNote = document.Notes[selectedIndex - 1];
				document.Notes[selectedIndex] = PrecedingNote;
				document.Notes[newIndex] = NoteObject;
				ReplaceWindowIndexes(selectedIndex, newIndex);
				RefreshNotes();
				SelectNote(newIndex);
			}
		}

		private void downArrowButton_Click(object sender, EventArgs e)
		{
			int selectedIndex = GetSelectedIndex();
			int newIndex = GetSelectedIndex() + 1;
			if (selectedIndex != -1 && newIndex < document.Notes.Count)
			{
				string[] NoteObject = GetSelectedNote();
				string[] SucceedingNote = document.Notes[newIndex];
				document.Notes[selectedIndex] = SucceedingNote;
				document.Notes[newIndex] = NoteObject;
				ReplaceWindowIndexes(selectedIndex, newIndex);
				RefreshNotes();
				SelectNote(newIndex);
			}
		}

		public void OpenJSON(string json)
		{
			document = JsonConvert.DeserializeObject<Document>(json);
			Console.Write("OPENJSON SAVE");
			savedJSON = JsonConvert.SerializeObject(document);
			RefreshNotes();
		}

		public void SaveToJSON(string filePath)
		{
			string json = JsonConvert.SerializeObject(document);
			FileUtilities.WriteToFile(filePath, json, false);
			Console.Write("OPENJSON SAVE");
			savedJSON = json;
			saveFile = filePath;
		}

		public bool FileSaveAs()
		{
			saveFile = FileUtilities.CreateSaveDialog("QUILL files|.quill");
			if (saveFile != "")
			{
				SaveToJSON(saveFile);
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool FileSave()
		{
			if (saveFile != "" && saveFile != null)
			{
				SaveToJSON(saveFile);
				return true;
			}
			else
			{
				return FileSaveAs();
			}
		}

		public void FileOpen()
		{
			saveFile = FileUtilities.CreateOpenDialog("QUILL files|*.quill");
			if (saveFile != "")
			{
				OpenJSON(FileUtilities.ReadFromFile(saveFile));
			}
		}

		public void OpenFile(string filePath)
		{
			if (filePath != "" && filePath != null)
			{
				OpenJSON(FileUtilities.ReadFromFile(filePath));
				saveFile = filePath;
			}
		}

		private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (JsonConvert.SerializeObject(document) != savedJSON)
			{
				DialogResult unsavedWorkWarning = MessageBox.Show("Do you want to save your work?", "Unsaved Work", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
				if (unsavedWorkWarning == DialogResult.Cancel)
				{
					// Cancel the Closing event
					e.Cancel = true;
				}
				else if (unsavedWorkWarning == DialogResult.Yes)
				{
					bool saved = FileSave();
					if (!saved) e.Cancel = true;
				}
			}

		}

		private void NewToolbar_Click(object sender, EventArgs e)
		{
			Application.Restart();
		}

		private void OpenToolbar_Click(object sender, EventArgs e)
		{
			FileOpen();
		}

		private void SaveToolbar_Click(object sender, EventArgs e)
		{
			FileSave();
		}

		private void SaveAsToolbar_Click(object sender, EventArgs e)
		{
			FileSaveAs();
		}

		private void QuitToolbar_Click(object sender, EventArgs e)
		{
		}

		private void creditsToolbar_Click(object sender, EventArgs e)
		{
			MarkdownRendererForm creditsForm = new MarkdownRendererForm(Properties.Resources.credits+"\n"+Utilities.GetCopyrightNotice());
			creditsForm.Show();
		}

		private void menu_File_Settings_Click(object sender, EventArgs e)
		{
			SettingsForm settingsForm = new SettingsForm(this);
			settingsForm.Show();
		}

	}
}
