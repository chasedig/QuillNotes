﻿using System;
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
        public NotesWindow()
        {
            InitializeComponent();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            NoteEditor editorWindow = new NoteEditor("title test","contents test\ntest lol");
            editorWindow.Show();
        }
    }
}
