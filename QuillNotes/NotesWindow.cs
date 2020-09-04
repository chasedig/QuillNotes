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
	public partial class NotesWindow : Form
	{
		List<string[]> NoteList = new List<string[]>();
		string[] EmptyNote = {"", ""};

		public NotesWindow()
		{
			InitializeComponent();
			RefreshControls();
			Utilities.GenerateDebugNotes(this,100);
		}

		public void AddNote(string[] note)
		{
			NoteList.Add(note);
			RefreshNotes();
		}

		public void SaveNote(string[] note, int index)
		{
			if (index != -1)
			{
				NoteList[index] = note;
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
			foreach (var note in NoteList)
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
			if (NoteList.Count < 2)
			{
				upArrowButton.Enabled = false;
				downArrowButton.Enabled = false;
			}
			if (GetSelectedIndex() < 1) upArrowButton.Enabled = false;
			if (GetSelectedIndex() >= NoteList.Count-1) downArrowButton.Enabled = false;
		}

		private string[] GetSelectedNote()
		{
			int noteIndex = GetSelectedIndex();
			if (noteIndex != -1)
			{
				string[] note = NoteList[noteIndex];
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

		public string NotesToJSON()
		{
			var json = JsonConvert.SerializeObject(NoteList);
			return json;
		}

		public string[] JSONToNotes(string json)
		{
			return JsonConvert.DeserializeObject<string[]>(json);
		}

		private void NewToolbar_Click(object sender, EventArgs e)
		{
			Application.Restart();
		}

		private void OpenToolbar_Click(object sender, EventArgs e)
		{

		}
		private void SaveToolbar_Click(object sender, EventArgs e)
		{

		}

		private void SaveAsToolbar_Click(object sender, EventArgs e)
		{

		}

		private void QuitToolbar_Click(object sender, EventArgs e)
		{

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
				if (form is NoteEditor)
				{
					if (((NoteEditor)form).index == noteIndex)
					{
						form.Focus();
						return;
					}
				}
			}
			if (note != EmptyNote)
			{
				NoteEditor editorWindow = new NoteEditor(note, GetSelectedIndex(), false, this);
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
						if (form is NoteEditor || form is View) {
							int windowIndex = GetWindowIndex(form);
							SetWindowIndex(form, windowIndex - 1);
						}
					}
					NoteList.RemoveAt(selectedIndex);
					RefreshNotes();
				}
			}
		}

		private void NewButton_Click(object sender, EventArgs e)
		{
			NoteEditor editorWindow = new NoteEditor(EmptyNote,0,true, this);
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
			GetWindowIndexOfType<NoteEditor>(),
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
			SetWindowIndexOfType<NoteEditor>();
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

			ReplaceWindowIndexesOfType<NoteEditor>();
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
				string[] PrecedingNote = NoteList[selectedIndex - 1];
				NoteList[selectedIndex] = PrecedingNote;
				NoteList[newIndex] = NoteObject;
				ReplaceWindowIndexes(selectedIndex, newIndex);
				RefreshNotes();
				SelectNote(newIndex);
			}
		}

		private void downArrowButton_Click(object sender, EventArgs e)
		{
			int selectedIndex = GetSelectedIndex();
			int newIndex = GetSelectedIndex() + 1;
			if (selectedIndex != -1 && newIndex < NoteList.Count)
			{
				string[] NoteObject = GetSelectedNote();
				string[] SucceedingNote = NoteList[newIndex];
				NoteList[selectedIndex] = SucceedingNote;
				NoteList[newIndex] = NoteObject;
				ReplaceWindowIndexes(selectedIndex, newIndex);
				RefreshNotes();
				SelectNote(newIndex);
			}
		}
	}
}
