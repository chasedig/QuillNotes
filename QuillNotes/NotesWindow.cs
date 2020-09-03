using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuillNotes

    
{
    public partial class NotesWindow : Form
    {
        List<string[]> NoteList = new List<string[]>();


        public NotesWindow()
        {
            InitializeComponent();
        }

        public void AddNote(string title, string contents)
        {
            string[] noteObject = new string[2] {title, contents};
            NoteList.Add(noteObject);
            RefreshNotes();
        }

        private void RefreshNotes()
        {
            NotesBox.Items.Clear();
            foreach (var note in NoteList)
            {
                NotesBox.Items.Add(note[0]);
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            NoteEditor editorWindow = new NoteEditor("","",true);
            editorWindow.Text = "New Note"; // Changes title of the editing window to "New Note"
            editorWindow.Show();
        }
    }
}
